using Suggestions.AspNetCore.Models;

namespace Suggestions.AspNetCore.Query
{
    public class PartySuggestQuery : SuggestQuery
    {
        public AddressData[] locations { get; set; }
        public AddressData[] locations_boost { get; set; }
        public PartyStatus[] status { get; set; }
        public PartyType? type { get; set; }
        public PartySuggestQuery(string query) : base(query) { }
    }
}
