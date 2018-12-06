using Suggestions.AspNetCore.Models;

namespace Suggestions.AspNetCore.Query
{
    public class FioSuggestQuery : SuggestQuery
    {
        public FioPart[] parts { get; set; }
        public FioSuggestQuery(string query) : base(query) { }
    }
}
