namespace Unilevel.DTOs
{
    public class CreateSurveyRequestDTO
    {
        public string Title { get; set; } // Tiêu đề yêu cầu khảo sát
        public int SurveyId { get; set; } // ID bài khảo sát được chọn
        public DateTime StartDate { get; set; } // Ngày bắt đầu
        public DateTime EndDate { get; set; } // Ngày kết thúc
        public List<string> UserIds { get; set; } // Danh sách ID người thực hiện
    }
}
