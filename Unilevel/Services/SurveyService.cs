using Microsoft.EntityFrameworkCore;
using Unilevel.DTOs;
using Unilevel.Models;

namespace Unilevel.Services
{
    public class SurveyService
    {
        private readonly AppDbContext _context;

        public SurveyService(AppDbContext context)
        {
            _context = context;
        }


        // Lay het khao sat
        public async Task<List<SurveyListDTO>> GetAllSurveysAsync()
        {
            var surveys = await _context.Surveys
                .Include(s => s.Questions)
                .ThenInclude(q => q.Answers) 
                .AsNoTracking()
                .ToListAsync();

            return surveys.Select(s => new SurveyListDTO
            {
                No = s.Id,
                SurveyName = s.SurveyName,
                CreatorId = s.CreatorId,
                QuestionCount = s.Questions.Count,
                Status = s.Status
            }).ToList();
        }

        // Tim kiem khao sat
        public async Task<List<SurveyListDTO>> SearchSurveysAsync(string keyword)
        {
            var surveys = await _context.Surveys
                .Include(s => s.Questions)
                .Where(s => EF.Functions.Like(s.SurveyName, $"%{keyword}%"))
                .AsNoTracking()
                .ToListAsync();

            return surveys.Select(s => new SurveyListDTO
            {
                No = s.Id,
                SurveyName = s.SurveyName,
                CreatorId = s.CreatorId,
                QuestionCount = s.Questions.Count,
                Status = s.Status
            }).ToList();
        }


        // Thay doi trang thai khao sat
        public async Task<bool> UpdateSurveyStatusAsync(UpdateSurveyStatusDTO dto)
        {
            var survey = await _context.Surveys.FindAsync(dto.SurveyId);
            if (survey == null) return false;

            if (survey.Status != dto.Status)
            {
                survey.Status = dto.Status;
                _context.Surveys.Update(survey);
                await _context.SaveChangesAsync();
            }
            return true;
        }


        // Xoa khao sat
        public async Task<bool> DeleteSurveyAsync(int surveyId)
        {
            var survey = await _context.Surveys
                .Include(s => s.Questions)
                .ThenInclude(q => q.Answers)
                .FirstOrDefaultAsync(s => s.Id == surveyId);

            if (survey == null) return false;

            _context.Surveys.Remove(survey);
            await _context.SaveChangesAsync();
            return true;
        }


        // Tao khao sat moi
        public async Task<Survey> CreateSurveyAsync(CreateSurveyDTO dto)
        {
            var newSurvey = new Survey
            {
                SurveyName = dto.SurveyName,
                CreatorId = dto.CreatorId,
                Status = "active",
                Questions = new List<Question>()
            };

            await _context.Surveys.AddAsync(newSurvey);
            await _context.SaveChangesAsync();
            return newSurvey;
        }


        // Sua tieu de khao sat
        public async Task<bool> UpdateSurveyTitleAsync(UpdateSurveyTitleDTO dto)
        {
            var survey = await _context.Surveys.FindAsync(dto.SurveyId);
            if (survey == null) return false;

            survey.SurveyName = dto.SurveyName;
            _context.Surveys.Update(survey);
            await _context.SaveChangesAsync();
            return true;
        }


        // Cap nhat cau hoi va cau tra loi cho khao sat
        public async Task<UpdateSurveyQuestionsDTO> UpdateSurveyQuestionsAsync(UpdateSurveyQuestionsDTO dto)
        {
            var survey = await _context.Surveys
                .Include(s => s.Questions)
                .ThenInclude(q => q.Answers)
                .FirstOrDefaultAsync(s => s.Id == dto.SurveyId);

            if (survey == null) return null; // check tham so

            // Xoa cau hoi va cau tra loi khong ton tai
            var questionIds = dto.Questions.Where(q => q.Id.HasValue).Select(q => q.Id.Value).ToList();
            var questionsToRemove = survey.Questions.Where(q => !questionIds.Contains(q.Id)).ToList();
            _context.Questions.RemoveRange(questionsToRemove);

            // Cap nhat va them cau hoi
            foreach (var questionDto in dto.Questions)
            {
                var question = survey.Questions.FirstOrDefault(q => q.Id == questionDto.Id);
                if (question == null)
                {
                    // Them cau tra loi
                    question = new Question
                    {
                        QuestionContent = questionDto.QuestionContent,
                        ImageUrl = questionDto.ImageUrl,
                        IsMultipleAnswer = questionDto.IsMultipleAnswer,
                        IsDifferentAnswer = questionDto.IsDifferentAnswer,
                        Answers = questionDto.Answers.Select(a => new Answer
                        {
                            AnswerContent = a.AnswerContent
                        }).ToList()
                    };
                    survey.Questions.Add(question);
                }
                else
                {
                    // Cap nhat cau hoi hien tai
                    question.QuestionContent = questionDto.QuestionContent;
                    question.ImageUrl = questionDto.ImageUrl;
                    question.IsMultipleAnswer = questionDto.IsMultipleAnswer;
                    question.IsDifferentAnswer = questionDto.IsDifferentAnswer;

                    // Cap nhat cau tra loi
                    var answerIds = questionDto.Answers.Where(a => a.Id.HasValue).Select(a => a.Id.Value).ToList();
                    var answersToRemove = question.Answers.Where(a => !answerIds.Contains(a.Id)).ToList();
                    _context.Answers.RemoveRange(answersToRemove);

                    foreach (var answerDto in questionDto.Answers)
                    {
                        var answer = question.Answers.FirstOrDefault(a => a.Id == answerDto.Id);
                        if (answer == null)
                        {
                            // Them cau tra loi
                            question.Answers.Add(new Answer
                            {
                                AnswerContent = answerDto.AnswerContent
                            });
                        }
                        else
                        {
                            answer.AnswerContent = answerDto.AnswerContent;
                        }
                    }
                }
            }

            await _context.SaveChangesAsync();
            return dto;
        }


        // Lay Chi tiet khao sat ( bao gom cau hoi, cau tra loi )
        public async Task<SurveyDetailsDTO> GetSurveyDetailsAsync(int surveyId)
        {
            var survey = await _context.Surveys
                .Include(s => s.Questions)
                .ThenInclude(q => q.Answers)
                .FirstOrDefaultAsync(s => s.Id == surveyId);

            if (survey == null) return null;

            return new SurveyDetailsDTO
            {
                SurveyId = survey.Id,
                SurveyName = survey.SurveyName,
                Questions = survey.Questions.Select(q => new QuestionDTO
                {
                    QuestionContent = q.QuestionContent,
                    Answers = q.Answers.Select(a => new AnswerDTO
                    {
                        AnswerContent = a.AnswerContent
                    }).ToList()
                }).ToList()
            };
        }
    }
}
