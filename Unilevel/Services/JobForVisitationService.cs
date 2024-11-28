using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Unilevel.DTOs;
using Unilevel.Hubs;
using Unilevel.Models;

namespace Unilevel.Services
{
    public class JobForVisitationService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IConfiguration _configuration;
        private readonly IHubContext<CommentHub> _commentHubContext;

        public JobForVisitationService(AppDbContext appDbContext, IConfiguration configuration, IHubContext<CommentHub> commentHubContext)
        {
            _appDbContext = appDbContext;
            _configuration = configuration;
            _commentHubContext = commentHubContext; // Initialize the HubContext
        }

        // Lấy danh sách công việc theo VisitCalendarId
        public List<JobForVisitationDTO> GetJobsByVisitCalendarId(int visitCalendarId)
        {
            return _appDbContext.JobForVisitation
                .Where(j => j.VisitCalendarId == visitCalendarId)
                .Select(j => new JobForVisitationDTO
                {
                    Id = j.Id,
                    WorkingPerson = j.WorkingPerson,
                    Reporter = j.Reporter,
                    Description = j.Description,
                    StartDate = j.StartDate,
                    EndDate = j.EndDate,
                    VisitCalendarId = j.VisitCalendarId
                })
                .ToList();
        }

        // Tạo một công việc mới
        public string CreateJob(JobForVisitationDTO jobDto, string userId)
        {
            if (userId.IsNullOrEmpty())
            {
                throw new ArgumentNullException("userId cannot be null");
            }
            var newJob = new JobForVisitation
            {
                WorkingPerson = jobDto.WorkingPerson,
                Reporter = jobDto.Reporter,
                Description = jobDto.Description,
                Creator = userId,
                StartDate = jobDto.StartDate,
                EndDate = jobDto.EndDate,
                VisitCalendarId = jobDto.VisitCalendarId
            };

            // Thêm và lưu newJob trước
            _appDbContext.JobForVisitation.Add(newJob);
            _appDbContext.SaveChanges(); // Lưu để lấy giá trị Id của newJob

            // Sử dụng newJob.Id để tạo JobDetail
            var jobDetail = new JobDetail
            {
                Id = newJob.Id,
            };
            _appDbContext.JobDetail.Add(jobDetail);

            // Lưu lại thay đổi
            _appDbContext.SaveChanges();

            return "Thêm Công việc thành công";
        }


        // Lấy công việc của chính mình dựa vào WorkingPerson
        public List<JobForVisitationDTO> GetJobsByWorkingPerson(string workingPerson)
        {
            return _appDbContext.JobForVisitation
                .Where(j => j.WorkingPerson == workingPerson)
                .Select(j => new JobForVisitationDTO
                {
                    Id = j.Id,
                    WorkingPerson = j.WorkingPerson,
                    Reporter = j.Reporter,
                    Description = j.Description,
                    StartDate = j.StartDate,
                    EndDate = j.EndDate,
                    VisitCalendarId = j.VisitCalendarId
                })
                .ToList();
        }


        //lay job dua tren nguoi tao 
        public List<JobForVisitationDTO> GetJobsByCreateorId(string CreatorId)
        {
            return _appDbContext.JobForVisitation
                .Where(j => j.Creator == CreatorId)
                .Select(j => new JobForVisitationDTO
                {
                    Id = j.Id,
                    WorkingPerson = j.WorkingPerson,
                    Reporter = j.Reporter,
                    Description = j.Description,
                    StartDate = j.StartDate,
                    EndDate = j.EndDate,
                    VisitCalendarId = j.VisitCalendarId
                })
                .ToList();
        }


        // tai len hinh anh

        public async Task<string> UploadImageAsync(int jobId, IFormFile file, string uploadPerson)
        {
            
            if (file == null || file.Length == 0)
            {
                return "File không hợp lệ.";
            }

            var jobDetail = _appDbContext.JobDetail.FirstOrDefault(j => j.Id == jobId);
            if (jobDetail == null)
            {
                return "Công việc không tồn tại.";
            }

            // tao duong dan luu file 
            var folderPath = Path.Combine("wwwroot", "uploads", "images");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            var filePath = Path.Combine(folderPath, fileName);

            // Luu file len server
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // Luu duong dan file vao csdl
            var fileUrl = $"/uploads/images/{fileName}";
            if (uploadPerson == "CreatorReporter")
            {
                jobDetail.LinkFileForCreatorReporter = fileUrl;
            }
            else if (uploadPerson == "WorkingPerson")
            {
                jobDetail.LinkFileForWorkingPerson = fileUrl;
            }
            else
            {
                return "UploadPerson không hợp lệ.";
            }

            _appDbContext.SaveChanges();
            return "Tải lên hình ảnh thành công.";
        }


        //dong job
        public async Task<string> changeJobStatus(int jobId, string jobStatus)
        {
            // Tìm công việc theo jobId
            var job = _appDbContext.JobForVisitation.FirstOrDefault(j => j.Id == jobId);

            // Kiểm tra nếu công việc không tồn tại
            if (job == null)
            {
                return "Công việc không tồn tại.";
            }

            // Chuyển đổi jobStatus từ string sang enum JobStatuses
            if (Enum.TryParse(jobStatus, out JobForVisitation.JobStatuses status))
            {
                job.JobStatus = status; 
            }
            else
            {
                return "Trạng thái công việc không hợp lệ.";
            }

            // Lưu thay đổi vào cơ sở dữ liệu
            await _appDbContext.SaveChangesAsync();

            return "Trạng thái công việc đã được thay đổi thành công.";
        }

        public async Task SendComment(string userId, CommentForJobDTO commentForJobDTO)
        {
            var user = await _appDbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null)
            {
                throw new Exception("UserId not found");
            }

            var Comment = new CommentForJob
            {
                UserComment = commentForJobDTO.UserComment,
                Comment = commentForJobDTO.Comment,
                JobId = commentForJobDTO.JobId,

            };
            await _commentHubContext.Clients.All.SendAsync("ReceiveMessage", user.UserName, commentForJobDTO.Comment);
        }



    }
}
