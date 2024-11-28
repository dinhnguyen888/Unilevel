using DocumentFormat.OpenXml.Office2013.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Unilevel.DTOs;
using Unilevel.Models;

namespace Unilevel.Services
{
    public class VisitCalendarService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public VisitCalendarService(AppDbContext appDbContext, IHttpContextAccessor httpContextAccessor)
        {
            _appDbContext = appDbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public (List<string> Permissions, string UserId) GetUserPermissions()
        {
            var user = _httpContextAccessor.HttpContext?.User;

            if (user == null || !user.Identity.IsAuthenticated)
            {
                throw new UnauthorizedAccessException("User is not authenticated.");
            }

            var permissions = user.Claims
                                  .Where(c => c.Type == "Permission")
                                  .Select(c => c.Value)
                                  .ToList();

            var userId = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                throw new UnauthorizedAccessException("Unable to retrieve user information.");
            }

            return (permissions, userId);
        }

        public void ScheduleVisitCalendar(
            List<DateTime> implementationDates,
            string implementationTime,
            string visitPurpose,
            List<string> visitorIds,
            string distributorId
           
        )
        {
            var (_, userId) = GetUserPermissions();

            // Lấy danh sách khách mời từ IDs
            var visitors = _appDbContext.Users
                .Where(u => visitorIds.Contains(u.Id))
                .ToList();

            if (visitors.Count != visitorIds.Count)
            {
                throw new Exception("Không tìm thấy một số khách mời.");
            }

            // Lặp qua từng ngày thực hiện để tạo lịch
            foreach (var date in implementationDates)
            {
                var visitCalendar = new VisitCalendar
                {
                    CalendarCreatorId = userId, 
                    ImplementationTime = implementationTime, 
                    VisitPurpose = visitPurpose,
                    DistributorId = distributorId,
                    Visitors = visitors.Select(v => new Visitor { VisitorId = v.Id }).ToList(),
                    VisitCalendarStatus = "IsVisited"
                    
                };

                // Thêm ngày thực hiện vào ImplementationDates
                _appDbContext.ImplementationDate.Add(new ImplementationDate
                {
                    Date = date,
                    VisitCalendar = visitCalendar
                });

                _appDbContext.VisitCalendar.Add(visitCalendar);
            }

            // Lưu thay đổi vào cơ sở dữ liệu
            _appDbContext.SaveChanges();
        }
        private string GetDistributorName(string distributorId)
        {
            return _appDbContext.Users
                .Where(u => u.Id == distributorId)
                .Select(u => u.UserName)
                .FirstOrDefault() ?? "Unknown";
        }

        public List<VisitCalendarDTO> GetAllVisitCalendar()
        {
            var calendars = _appDbContext.VisitCalendar
                .Include(vc => vc.Visitors)
                .Include(vc => vc.Distributor)
                .ToList();

            return calendars.Select(vc => new VisitCalendarDTO
            {
                Id = vc.Id,
                CalendarCreatorId = vc.CalendarCreatorId,
                ImplementationDates = _appDbContext.ImplementationDate
                    .Where(d => d.VisitCalendarId == vc.Id)
                    .Select(d => d.Date)
                    .ToList(),
                ImplementationTime = vc.ImplementationTime.ToString(),
                VisitPurpose = vc.VisitPurpose,
                Visitors = vc.Visitors.Select(v => v.VisitorId).ToList(),
                DistributorId = vc.DistributorId,
                DistributorName = GetDistributorName(vc.DistributorId),
                VisitCalendarStatus = vc.VisitCalendarStatus
            }).ToList();
        }

        public List<VisitCalendarDTO> GetVisitCalendarByAreaId(string userId)
        {
            var currentUser = _appDbContext.Users
                .Where(u => u.Id == userId)
                .Select(u => new { u.AreaId })
                .FirstOrDefault();

            if (currentUser == null || string.IsNullOrEmpty(currentUser.AreaId))
            {
                throw new Exception("User's AreaId not found.");
            }

            var areaId = currentUser.AreaId;

            var calendars = _appDbContext.VisitCalendar
                .Include(vc => vc.Visitors)
                .Include(vc => vc.Distributor)
                .Where(vc => vc.User.AreaId == areaId)
                .ToList();

            return calendars.Select(vc => new VisitCalendarDTO
            {
                Id = vc.Id,
                CalendarCreatorId = vc.CalendarCreatorId,
                ImplementationDates = _appDbContext.ImplementationDate
                    .Where(d => d.VisitCalendarId == vc.Id)
                    .Select(d => d.Date)
                    .ToList(),
                ImplementationTime = vc.ImplementationTime.ToString(),
                VisitPurpose = vc.VisitPurpose,
                Visitors = vc.Visitors.Select(v => v.VisitorId).ToList(),
                DistributorId = vc.DistributorId,
                DistributorName = GetDistributorName(vc.DistributorId),
                VisitCalendarStatus = vc.VisitCalendarStatus
            }).ToList();
        }

        public List<VisitCalendarDTO> SearchVisitCalendars(string keyword)
        {
            var calendars = _appDbContext.VisitCalendar
                .Include(vc => vc.User)
                .Include(vc => vc.Distributor)
                .Where(vc =>
                    vc.VisitPurpose.Contains(keyword) ||
                    vc.User.UserName.Contains(keyword) ||
                    vc.Distributor.Id.Contains(keyword))
                .ToList();

            return calendars.Select(vc => new VisitCalendarDTO
            {
                Id = vc.Id,
                CalendarCreatorId = vc.CalendarCreatorId,
                ImplementationDates = _appDbContext.ImplementationDate
                    .Where(d => d.VisitCalendarId == vc.Id)
                    .Select(d => d.Date)
                    .ToList(),
                ImplementationTime = vc.ImplementationTime,
                VisitPurpose = vc.VisitPurpose,
                Visitors = vc.Visitors.Select(v => v.VisitorId).ToList(),
                DistributorId = vc.DistributorId,
                DistributorName = GetDistributorName(vc.DistributorId),
                VisitCalendarStatus = vc.VisitCalendarStatus
            }).ToList();
        }

        public List<VisitCalendarDTO> FilterVisitCalendars(DateTime? startDate, DateTime? endDate, string status, string distributorId)
        {
            var query = _appDbContext.VisitCalendar
                .Include(vc => vc.Visitors)
                .Include(vc => vc.Distributor)
                .Include(vc => vc.User)
                .AsQueryable();

            if (startDate.HasValue)
            {
                query = query.Where(vc =>
                    _appDbContext.ImplementationDate
                    .Where(d => d.VisitCalendarId == vc.Id)
                    .Any(d => d.Date >= startDate.Value));
            }

            if (endDate.HasValue)
            {
                query = query.Where(vc =>
                    _appDbContext.ImplementationDate
                    .Where(d => d.VisitCalendarId == vc.Id)
                    .Any(d => d.Date <= endDate.Value));
            }

            if (!string.IsNullOrEmpty(status))
            {
                query = query.Where(vc => vc.VisitCalendarStatus == status);
            }

            if (!string.IsNullOrEmpty(distributorId))
            {
                query = query.Where(vc => vc.DistributorId == distributorId);
            }

            var filteredCalendars = query.ToList();

            return filteredCalendars.Select(vc => new VisitCalendarDTO
            {
                Id = vc.Id,
                CalendarCreatorId = vc.CalendarCreatorId,
                ImplementationDates = _appDbContext.ImplementationDate
                    .Where(d => d.VisitCalendarId == vc.Id)
                    .Select(d => d.Date)
                    .ToList(),
                ImplementationTime = vc.ImplementationTime,
                VisitPurpose = vc.VisitPurpose,
                Visitors = vc.Visitors.Select(v => v.VisitorId).ToList(),
                DistributorId = vc.DistributorId,
                DistributorName = GetDistributorName(vc.DistributorId),
                VisitCalendarStatus = vc.VisitCalendarStatus
            }).ToList();
        }

        public List<VisitCalendarDTO> GetVisitHistory()
        {
            var today = DateTime.Now.Date;

            var calendars = _appDbContext.VisitCalendar
                .Include(vc => vc.User)
                .Include(vc => vc.Visitors)
               .Where(vc =>
                       (vc.ImplementationDates.All(date => date.Date < today) || // Tất cả ngày thực hiện trong quá khứ
                        vc.VisitCalendarStatus == "IsVisited" ||
                        vc.VisitCalendarStatus == "NotVisited") ||
                        vc.VisitCalendarStatus == "Abort")
                        .ToList();

            var users = _appDbContext.Users.ToDictionary(u => u.Id, u => u.UserName);

            return calendars.Select(vc => new VisitCalendarDTO
            {
                Id = vc.Id,
                CalendarCreatorId = vc.CalendarCreatorId,
                ImplementationDates = _appDbContext.ImplementationDate
                    .Where(d => d.VisitCalendarId == vc.Id)
                    .Select(d => d.Date)
                    .ToList(),
                ImplementationTime = vc.ImplementationTime,
                VisitPurpose = vc.VisitPurpose,
                Visitors = vc.Visitors.Select(v => v.VisitorId).ToList(),
                DistributorId = vc.DistributorId,
                DistributorName = users.ContainsKey(vc.DistributorId) ? users[vc.DistributorId] : "Unknown"
            }).ToList();
        }

        // Phương thức lấy danh sách chuyến thăm sắp tới
        public List<VisitCalendarDTO> GetUpcomingVisits()
        {
            var today = DateTime.Now.Date;

            var calendars = _appDbContext.VisitCalendar
                .Include(vc => vc.User)
                .Include(vc => vc.Visitors)
                .Where(vc =>
                    vc.ImplementationDates.Any(date => date.Date >= today) && // Có ít nhất một ngày thực hiện hôm nay hoặc tương lai
                    vc.VisitCalendarStatus != "IsVisited" && // Chưa thực hiện
                    vc.VisitCalendarStatus != "Abort")  // Chưa hủy
                .ToList();

            var users = _appDbContext.Users.ToDictionary(u => u.Id, u => u.UserName);

            return calendars.Select(vc => new VisitCalendarDTO
            {
                Id = vc.Id,
                CalendarCreatorId = vc.CalendarCreatorId,
                ImplementationDates = _appDbContext.ImplementationDate
                    .Where(d => d.VisitCalendarId == vc.Id)
                    .Select(d => d.Date)
                    .ToList(),
                ImplementationTime = vc.ImplementationTime,
                VisitPurpose = vc.VisitPurpose,
                Visitors = vc.Visitors.Select(v => v.VisitorId).ToList(),
                DistributorId = vc.DistributorId,
                DistributorName = users.ContainsKey(vc.DistributorId) ? users[vc.DistributorId] : "Unknown"
            }).ToList();
        }
    }
}
