using Suggestions.AspNetCore.Models;

namespace Suggestions.AspNetCore.Query
{
    public class CountrySuggestQuery : SuggestQuery
    {
        public CountryData[] countries { get; set; }
        public CountrySuggestQuery(string query) : base(query) { }
    }
}
