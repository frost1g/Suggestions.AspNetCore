using Suggestions.AspNetCore.Models;

namespace Suggestions.AspNetCore.Query
{
    public class BankSuggestQuery : SuggestQuery
    {
        public PartyStatus[] status { get; set; }
        public BankType[] type { get; set; }
        public BankSuggestQuery(string query) : base(query) { }
    }
}
