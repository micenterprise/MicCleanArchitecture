namespace MicCleanArchitecture.Domain.Exceptions
{
    public class UnsupportedOptionTypeException : Exception
    {
        public UnsupportedOptionTypeException(string name) : base($"Name \"{name}\" is unsupported") { }
    }
}
