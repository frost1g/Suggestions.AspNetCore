using Suggestions.AspNetCore.Models;

namespace Suggestions.AspNetCore.Query
{
    public class AddressSuggestQuery : SuggestQuery
    {
        public AddressData[] locations { get; set; }
        public AddressData[] locations_boost { get; set; }
        public AddressBound from_bound { get; set; }
        public AddressBound to_bound { get; set; }
        public bool restrict_value { get; set; }
        public AddressSuggestQuery(string query) : base(query) { }
    }
}
