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

        // Lay danh sach cong viec theo Id 
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

        // Tao cong viec moi 
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

            // Luu job vao truoc
            _appDbContext.JobForVisitation.Add(newJob);
            _appDbContext.SaveChanges(); 

            // dung Id cua newjob de tao Jobdetail
            var jobDetail = new JobDetail
            {
                Id = newJob.Id,
            };
            _appDbContext.JobDetail.Add(jobDetail);

            // Luu lai
            _appDbContext.SaveChanges();

            return "Thêm Công việc thành công";
        }


        // Lay cong viec cua ban than
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
            var folderPath = Path.Combine("wwwroot", "uploads", "report");
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
            var fileUrl = $"/uploads/report/{fileName}";
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


        // Dong job
        public async Task<string> changeJobStatus(int jobId, string jobStatus)
        {
            // Check tham so
            var job = _appDbContext.JobForVisitation.FirstOrDefault(j => j.Id == jobId);

            if (job == null)
            {
                return "Cong viec khong ton tai.";
            }

            // Chuyen doi tu string sang enum
            if (Enum.TryParse(jobStatus, out JobForVisitation.JobStatuses status))
            {
                job.JobStatus = status; 
            }
            else
            {
                return "Trang thai khong hop le.";
            }

            // Luu
            await _appDbContext.SaveChangesAsync();

            return "Thay doi thanh cong.";
        }


        // Gui binh luan
        public async Task SendComment(string userId, CommentForJobDTO commentForJobDTO)
        {
            var user = await _appDbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null)
            {
                throw new Exception("UserId khong hop le");
            }

            var Comment = new CommentForJob
            {
                UserComment = commentForJobDTO.UserComment,
                Comment = commentForJobDTO.Comment,
                JobId = commentForJobDTO.JobId,

            };
            await _commentHubContext.Clients.All.SendAsync("ReceiveComment", user.UserName, commentForJobDTO.Comment);
        }

       // Danh gia task
        public async Task<string> RateTaskAsync(int jobId, int taskStar,int miniumStar, int maxStar)
        {

            // Check tham so
            if (taskStar < miniumStar || taskStar > maxStar)
            {
                return "Diem danh gia khong hop le.";
            }

            var jobDetail = await _appDbContext.JobDetail.FirstOrDefaultAsync(j => j.Id == jobId);
            if (jobDetail == null)
            {
                return "jobId khong hop le.";
            }

            // Cap nhat taskstar
            jobDetail.TaskStar = taskStar;

            // Luu thay doi
            await _appDbContext.SaveChangesAsync();

            return $"Danh gia thanh cong voi {taskStar} sao.";
        }


    }
}
