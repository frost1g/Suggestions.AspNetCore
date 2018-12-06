namespace Suggestions.AspNetCore
{
    public abstract class Suggestion
    {
        public string value { get; set; }
        public string unrestricted_value { get; set; }

        public override string ToString()
        {
            return value;
        }
    }
}
