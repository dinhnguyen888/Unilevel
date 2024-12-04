using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Unilevel.DTOs;
using Unilevel.Models;

namespace Unilevel.Services
{
    public class SurveyRequestService
    {
        private readonly AppDbContext _context;

        public SurveyRequestService(AppDbContext context)
        {
            _context = context;
        }

        // Tao yeu cau khao sat
        public async Task<SurveyRequest> CreateSurveyRequestAsync(CreateSurveyRequestDTO dto)
        {
            // Check tham so
            var survey = await _context.Surveys.FirstOrDefaultAsync(s => s.Id == dto.SurveyId);
            if (survey == null)
                throw new Exception("Khong tim thay yeu cau khao sat.");

            // Tao moi yeu cau khao sat
            var surveyRequest = new SurveyRequest
            {
                Id = Guid.NewGuid().ToString(), // tao guid
                Title = dto.Title,
                SurveyId = dto.SurveyId,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                Survey = survey,
                SurveyReceiver = dto.UserIds.Select(userId => new SurveyReceiver
                {
                    SurveyId = dto.SurveyId,
                
                    UserId = userId
                }).ToList()
            };

            await _context.SurveyRequest.AddAsync(surveyRequest);
            await _context.SaveChangesAsync();

            return surveyRequest;
        }

        public async Task<List<SurveyReceiver>> GetSurveyReceiversAsync(string surveyRequestId)
        {
            var surveyRequest = await _context.SurveyRequest
                .Include(sr => sr.SurveyReceiver)
                .FirstOrDefaultAsync(sr => sr.Id == surveyRequestId);

            if (surveyRequest == null)
                throw new KeyNotFoundException("Khong tim thay yeu cau khao sat.");

            return surveyRequest.SurveyReceiver.ToList();
        }


        // Lay Yeu Cau khao sat theo trang thai
        public async Task<List<SurveyRequest>> GetSurveyRequestsByCompletionStatusAsync(bool isCompleted)
        {
            var surveyRequests = await _context.SurveyRequest
                .Include(sr => sr.SurveyReceiver) 
                .Where(sr => sr.SurveyReceiver.Any(receiver => receiver.IsCompleted == isCompleted)) 
                .ToListAsync();

            return surveyRequests;
        }

    }
}
