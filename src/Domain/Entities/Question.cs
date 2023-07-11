namespace MicCleanArchitecture.Domain.Entities
{
    public class Question : BaseAuditableEntity
    {
        public string QuestionId { get; set; }
        public string Text { get; set; }
        public int Point { get; set; }
        public string Media { get; set; }
        public string QuestionType { get; set; } //questionType
        public string Label { get; set; }
        public string Section { get; set; }
        public IEnumerable<Option> Options { get; set; }
    }
}
