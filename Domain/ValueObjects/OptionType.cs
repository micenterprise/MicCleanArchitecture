
namespace MicCleanArchitecture.Domain.ValueObjects
{
    public class OptionType : ValueObject
    {
        static OptionType()
        { }
        private OptionType() { }

        private OptionType(string name)
        {
            Name = name;
        }

        public static OptionType From(string name)
        {
            var optionType = new OptionType { Name = name };
            if (!SupportedOptionType.Contains(optionType))
            {
                throw new UnsupportedOptionTypeException(name);
            }
            return optionType;
        }

        public static OptionType Text => new("Text");
        public static OptionType Image => new("Image");

        public string Name { get; private set; } = "";
        public static implicit operator string(OptionType option)
        {
            return option.ToString();
        }
        public override string ToString()
        {
            return Name;
        }
        protected static IEnumerable<OptionType> SupportedOptionType
        {
            get
            {
                yield return Text;
                yield return Image;
            }
        }
       

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
        }
    }
}
