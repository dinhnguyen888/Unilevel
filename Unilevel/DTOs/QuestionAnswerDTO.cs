namespace Unilevel.DTOs
{
    public class AnswerDTO
    {
        public int? Id { get; set; } // Nullable để hỗ trợ câu trả lời mới
        public string AnswerContent { get; set; }
    }

    public class QuestionDTO
    {
        public int? Id { get; set; } // `null` nếu là câu hỏi mới
        public string QuestionContent { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMultipleAnswer { get; set; }
        public bool IsDifferentAnswer { get; set; }
        public List<AnswerDTO> Answers { get; set; }
    }
}
