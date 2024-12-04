using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unilevel.Models;

namespace Unilevel.Services
{
    public class SurveyResponseService
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;

        public SurveyResponseService(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        
        // Cap nhat cau hoi va cau tra loi
        public async Task<bool> UpdateSurveyResponseAsync(SurveyResponse response)
        {
            // Lay thong tin 
           var user = await _userManager.FindByIdAsync(response.UserId);
            if (user == null || user.Id != response.UserId)
                return false;

            // Check tham so
            var surveyReceiver = await _context.SurveyReceiver
    .FirstOrDefaultAsync(sr => sr.SurveyId == response.SurveyId && sr.UserId == response.UserId);

            if (surveyReceiver == null)
                return false;

            // Them moi va cap nhat cau tra loi
            var existingResponse = await _context.SurveyResponse
                .FirstOrDefaultAsync(r => r.SurveyId == response.SurveyId &&
                                          r.UserId == response.UserId &&
                                          r.QuestionId == response.QuestionId);

            if (existingResponse == null)
            {
                var newResponse = new SurveyResponse
                {
                    Id = Guid.NewGuid().ToString(),
                    SurveyId = response.SurveyId,
                    UserId = response.UserId,
                    QuestionId = response.QuestionId,
                    UserAnswerContent = response.UserAnswerContent
                };
                await _context.SurveyResponse.AddAsync(newResponse);
            }
            else
            {
                existingResponse.UserAnswerContent = response.UserAnswerContent;
                _context.SurveyResponse.Update(existingResponse);
            }

            // Danh dau hoan thanh
            if (!surveyReceiver.IsCompleted)
            {
                surveyReceiver.IsCompleted = true;
                _context.SurveyReceiver.Update(surveyReceiver);
            }

            await _context.SaveChangesAsync();
            return true;
        }


        // Lay toan bo cau hoi va cau tra loi
        public async Task<IEnumerable<object>> GetSurveyResponsesByUserIdAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return null;

            var responses = await _context.SurveyResponse
                .Where(r => r.UserId == userId)
                .Join(
                    _context.Questions, 
                    response => response.QuestionId,
                    question => question.Id,
                    (response, question) => new
                    {
                        QuestionName = question.QuestionContent,
                        UserAnswer = response.UserAnswerContent
                    })
                .ToListAsync();

            return responses;
        }
    }
}
