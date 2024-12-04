using Microsoft.EntityFrameworkCore;
using Unilevel.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Unilevel.Hubs;
using System.Security.Claims;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Unilevel.Services
{
    public class NotificationService
    {
        private readonly AppDbContext _context;
        private readonly IHubContext<NotificationHub> _notificationHubContext;

        public NotificationService(AppDbContext context, IHubContext<NotificationHub> notificationHubContext)
        {
            _context = context;
            _notificationHubContext = notificationHubContext;
        }


        // Ham tao thong bao 
        private async Task<Notification> CreateNotificationInternal(string title, string description, string userId, List<string> userIds)
        {
            // Check tham so
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("title vs description khong duoc de trong.");
            }

            // Tao thong bao
            var notification = new Notification
            {
                Title = title,
                Description = description,
                UserCreateNotify = userId,
                NotifyReceiver = userIds.Select(uid => new NotifyReceiver
                {
                    UserId = uid
                }).ToList()
            };

            // Luu vao database 
            await _context.Notification.AddAsync(notification);
            await _context.SaveChangesAsync();

            return notification;
        }


        // Ham gui thong bao qua SignalR
        private async Task SendNotificationToClients(List<string> userIds, Notification notification)
        {
            
            await _notificationHubContext.Clients.Users(userIds)
                .SendAsync("ReceiveNotification", new
                {
                    Title = notification.Title,
                    Description = notification.Description,
                    CreatedBy = notification.UserCreateNotify,
                });
        }


        // Ham tao thong bao gui den user cu the
        public async Task<Notification> CreateNotificationAsync(string title, string description, List<string> userIds, ClaimsPrincipal user)
        {
            var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value
                         ?? throw new UnauthorizedAccessException("User chua dang nhap");

            // Tao thong bao, luu vao database
            var notification = await CreateNotificationInternal(title, description, userId, userIds);

            // Gui thong bao qua SignalR
            await SendNotificationToClients(userIds, notification);

            return notification;
        }


        // Ham tao thong bao gui den nguoi dung trong cung mot khu vuc
        public async Task<Notification> SendNotificationToAreaAsync(string title, string description, ClaimsPrincipal user)
        {
            // Lay AreaId va UserId tu claims
            var areaId = user.FindFirst("AreaId")?.Value
                         ?? throw new UnauthorizedAccessException("User khong co AreaId");
            var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value
                         ?? throw new UnauthorizedAccessException("User chua dang nhap");

            // Lay danh sach nguoi dung trong khu vuc ( tru nguoi thong bao )
            var userIdsInArea = await _context.Users
                .Where(u => u.AreaId == areaId && u.Id != userId)
                .Select(u => u.Id)
                .ToListAsync();

            if (!userIdsInArea.Any())
            {
                throw new InvalidOperationException("Khong co nguoi dung nao khac trong khu vuc.");
            }

            // Tao thong bao, luu vao database
            var notification = await CreateNotificationInternal(title, description, userId, userIdsInArea);

            // Gui thong bao qua SignalR
            await SendNotificationToClients(userIdsInArea, notification);

            return notification;
        }


        // Ham lay thong bao
        public async Task<List<Notification>> GetNotificationsForUserAsync(ClaimsPrincipal user)
        {
            var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value
                       ?? throw new UnauthorizedAccessException("User chua dang nhap");

            var notifications = await _context.Notification
                .Include(n => n.NotifyReceiver)
                .Where(n => n.NotifyReceiver.Any(r => r.UserId == userId))
                .ToListAsync();

            return notifications;
        }
    }
}
