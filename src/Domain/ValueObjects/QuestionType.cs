namespace MicCleanArchitecture.Domain.ValueObjects
{
    public class QuestionType : ValueObject
    {
        static QuestionType() { }
        private QuestionType() { }

        private QuestionType(string name)
        {
            Name = name;
        }

        public static QuestionType From(string name)
        {
            var questionType = new QuestionType { Name = name };
            if(!SupportedQuestionType.Contains(questionType))
            {
                throw new UnsupportedQuestionTypeException(name);
            }

            return questionType;
        }
        public static QuestionType SingleAnswer => new("Single Answer");
        public static QuestionType MultipleAnswers => new("Multiple Answers");
        public static QuestionType FillTheBlank => new("Fill The Blank");

        public string Name { get; private set; } = "";

        public static implicit operator string(QuestionType type)
        {
            return type.ToString();
        }

        public override string ToString()
        {
            return Name;
        }

        protected static IEnumerable<QuestionType> SupportedQuestionType
        {
            get
            {
                yield return SingleAnswer;
                yield return MultipleAnswers;
                yield return FillTheBlank;
            }
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
        }
    }
}
