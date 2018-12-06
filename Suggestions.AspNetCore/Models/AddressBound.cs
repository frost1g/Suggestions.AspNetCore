namespace Suggestions.AspNetCore.Models
{
    public class AddressBound
    {
        public string value { get; set; }
        public AddressBound(string name)
        {
            this.value = name;
        }
    }
}