namespace Unilevel.DTOs
{
    // DTO for displaying survey details
    public class SurveyListDTO
    {
        public int No { get; set; } 
        public string SurveyName { get; set; } 
        public string CreatorId { get; set; } 
        public int QuestionCount { get; set; }
        public string Status { get; set; }
    }

    // DTO for creating a new survey
    public class CreateSurveyDTO
    {
        public string SurveyName { get; set; } 
        public string CreatorId { get; set; }
    }

    // DTO for updating survey title
    public class UpdateSurveyTitleDTO
    {
        public int SurveyId { get; set; }
        public string SurveyName { get; set; } 
    }

    // DTO for changing survey status
    public class UpdateSurveyStatusDTO
    {
        public int SurveyId { get; set; }
        public string Status { get; set; } 
    }
    public class UpdateSurveyQuestionsDTO
    {
        public int SurveyId { get; set; }
        public List<QuestionDTO> Questions { get; set; }
    }

    public class SurveyDetailsDTO
    {
        public int SurveyId { get; set; }
        public string SurveyName { get; set; }
        public List<QuestionDTO> Questions { get; set; }
    }


}
