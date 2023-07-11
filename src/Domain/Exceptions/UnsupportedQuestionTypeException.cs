namespace MicCleanArchitecture.Domain.Exceptions
{
    public class UnsupportedQuestionTypeException : Exception
    {
        public UnsupportedQuestionTypeException(string name) : base($"Name \"{name}\" is unsupported") { }
    }
}
