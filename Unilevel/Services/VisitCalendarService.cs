using DocumentFormat.OpenXml.Office2013.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Unilevel.DTOs;
using Unilevel.Models;
using static Unilevel.Models.VisitCalendar;

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


        // Ham tinh nang lay quyen truy cap User
        public (List<string> Permissions, string UserId) GetUserPermissions()
        {
            var user = _httpContextAccessor.HttpContext?.User;

            if (user == null || !user.Identity.IsAuthenticated)
            {
                throw new UnauthorizedAccessException("User chua dang nhap.");
            }

            var permissions = user.Claims
                                  .Where(c => c.Type == "Permission")
                                  .Select(c => c.Value)
                                  .ToList();

            var userId = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                throw new UnauthorizedAccessException("UserId khong hop le.");
            }

            return (permissions, userId);
        }


        // Len lich vieng tham
        public void ScheduleVisitCalendar(
            List<DateTime> implementationDates,
            string implementationTime,
            string visitPurpose,
            List<string> visitorIds,
            string distributorId
           
        )
        {
            var (_, userId) = GetUserPermissions();

            // Lay danh sach khac moi
            var visitors = _appDbContext.Users
                .Where(u => visitorIds.Contains(u.Id))
                .ToList();

            if (visitors.Count != visitorIds.Count)
            {
                throw new Exception("Khong tim thay khach moi.");
            }

            // dung foreach de tao lich
            foreach (var date in implementationDates)
            {
                var visitCalendar = new VisitCalendar
                {
                    CalendarCreatorId = userId,
                    ImplementationTime = Enum.Parse<Times>(implementationTime),
                    VisitPurpose = visitPurpose,
                    DistributorId = distributorId,
                    Visitors = visitors.Select(v => new Visitor { VisitorId = v.Id }).ToList(),
                    VisitCalendarStatus = VisitCalendar.Status.isVisited

                };

                // Them ngay thuc hien vao ImplementionDate
                _appDbContext.ImplementationDate.Add(new ImplementationDate
                {
                    Date = date,
                    VisitCalendar = visitCalendar
                });

                _appDbContext.VisitCalendar.Add(visitCalendar);
            }

            // Luu vao csdl
            _appDbContext.SaveChanges();
        }


        // Lay ten nha phan phoi ( ham tinh nang )
        private string GetDistributorName(string distributorId)
        {
            return _appDbContext.Users
                .Where(u => u.Id == distributorId)
                .Select(u => u.UserName)
                .FirstOrDefault() ?? "Unknown";
        }


        // Lay tat ca lich vieng tham
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
                VisitCalendarStatus = vc.VisitCalendarStatus.ToString() 
            }).ToList();
        }


        // Lay lich vieng tham theo AreaId
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
                VisitCalendarStatus = vc.VisitCalendarStatus.ToString()
            }).ToList();
        }


        // Ham tim kiem 
        public List<VisitCalendarDTO> SearchVisitCalendars(string keyword)
        {
            var calendars = _appDbContext.VisitCalendar
                .Include(vc => vc.User)
                .Include(vc => vc.Distributor)
                .Where(vc =>
                    vc.VisitPurpose.Contains(keyword) ||
                    vc.User.UserName.Contains(keyword) ||
                    vc.Distributor.UserId.Contains(keyword))
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
                VisitCalendarStatus = vc.VisitCalendarStatus.ToString()
            }).ToList();
        }


        // Ham loc Lich vieng tham
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
                query = query.Where(vc => vc.VisitCalendarStatus.ToString() == status);
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
                ImplementationTime = vc.ImplementationTime.ToString(),
                VisitPurpose = vc.VisitPurpose,
                Visitors = vc.Visitors.Select(v => v.VisitorId).ToList(),
                DistributorId = vc.DistributorId,
                DistributorName = GetDistributorName(vc.DistributorId),
                VisitCalendarStatus = vc.VisitCalendarStatus.ToString()
            }).ToList();
        }


        // Lay lich vieng tham trong qua khu
        public List<VisitCalendarDTO> GetVisitHistory()
        {
            var today = DateTime.Now.Date;

            var calendars = _appDbContext.VisitCalendar
                .Include(vc => vc.User)
                .Include(vc => vc.Visitors)
               .Where(vc =>
                       (vc.ImplementationDates.All(date => date.Date < today) || // Tat ca ngay thuc hien trong qua khu
                        vc.VisitCalendarStatus == VisitCalendar.Status.isVisited ||
                        vc.VisitCalendarStatus == VisitCalendar.Status.notVisited) ||
                        vc.VisitCalendarStatus == VisitCalendar.Status.Abort)
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
                ImplementationTime = vc.ImplementationTime.ToString(),
                VisitPurpose = vc.VisitPurpose,
                Visitors = vc.Visitors.Select(v => v.VisitorId).ToList(),
                VisitCalendarStatus = vc.VisitCalendarStatus.ToString(),
                DistributorId = vc.DistributorId,
                DistributorName = users.ContainsKey(vc.DistributorId) ? users[vc.DistributorId] : "Unknown"
            }).ToList();
        }


        // Lay danh sach lich vieng tham sap toi
        public List<VisitCalendarDTO> GetUpcomingVisits()
        {
            var today = DateTime.Now.Date;

            var calendars = _appDbContext.VisitCalendar
                .Include(vc => vc.User)
                .Include(vc => vc.Visitors)
                .Where(vc =>
                    vc.ImplementationDates.Any(date => date.Date >= today) && // Co it nhat mot ngay thuc hien trong hom nay hoac ngay mai
                    vc.VisitCalendarStatus != VisitCalendar.Status.isVisited && // Chua thuc hien
                    vc.VisitCalendarStatus != VisitCalendar.Status.Abort)  // Chua huy
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
                ImplementationTime = vc.ImplementationTime.ToString(),
                VisitPurpose = vc.VisitPurpose,
                Visitors = vc.Visitors.Select(v => v.VisitorId).ToList(),
                DistributorId = vc.DistributorId,
                VisitCalendarStatus = vc.VisitCalendarStatus.ToString(),
                DistributorName = users.ContainsKey(vc.DistributorId) ? users[vc.DistributorId] : "Unknown"
            }).ToList();
        }


        // Tu choi lich vieng tham
        public void RefuseVisitInvitation(int visitCalendarId, string visitorId)
        {
            // check tham so
            var visitCalendar = _appDbContext.VisitCalendar
                .Include(vc => vc.Visitors)
                .FirstOrDefault(vc => vc.Id == visitCalendarId);

            if (visitCalendar == null)
            {
                throw new Exception("visitCalendarId khong hop le.");
            }

            var visitor = visitCalendar.Visitors
                .FirstOrDefault(v => v.VisitorId == visitorId);

            if (visitor == null)
            {
                throw new Exception("visitorId khong hop le.");
            }

            // cap nhat trang thai tu choi
            visitor.IsRefuseInvitation = true;

            _appDbContext.SaveChanges();
        }


        // Huy lich vieng tham
        public void CancelVisitCalendar(int visitCalendarId)
        {
            // Check tham so
            var visitCalendar = _appDbContext.VisitCalendar
                .FirstOrDefault(vc => vc.Id == visitCalendarId);

            if (visitCalendar == null)
            {
                throw new Exception("Khong tim thay lich vieng tham.");
            }

            // Chuyen lich vieng tham sang trang thai Abort
            visitCalendar.VisitCalendarStatus = VisitCalendar.Status.Abort;

            _appDbContext.SaveChanges();
        }


        //Xoa lich vieng tham
        public void DeleteVisitCalendar(int visitCalendarId)
        {
            // Check tham so
            var visitCalendar = _appDbContext.VisitCalendar
                .Include(vc => vc.Visitors)
                .FirstOrDefault(vc => vc.Id == visitCalendarId);

            if (visitCalendar == null)
            {
                throw new Exception("Không tìm thấy lịch viếng thăm.");
            }

            // kiem tra trang thai lich vieng tham
            if (visitCalendar.VisitCalendarStatus != VisitCalendar.Status.Abort)
            {
                throw new Exception("Chỉ có thể xóa lịch viếng thăm có trạng thái 'Abort'.");
            }

            // Xoa cac ngay lien quan den lich
            var implementationDates = _appDbContext.ImplementationDate
                .Where(d => d.VisitCalendarId == visitCalendarId)
                .ToList();
            _appDbContext.ImplementationDate.RemoveRange(implementationDates);

            // Xoa khach moi 
            _appDbContext.Visitors.RemoveRange(visitCalendar.Visitors);

            // Xoa Lich vieng tham
            _appDbContext.VisitCalendar.Remove(visitCalendar);

            // Luu lai
            _appDbContext.SaveChanges();
        }


    }
}
