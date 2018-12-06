using Suggestions.AspNetCore.Models;

namespace Suggestions.AspNetCore.Query
{
    public class CurrencySuggestQuery : SuggestQuery
    {
        public CurrencyData[] currencies { get; set; }
        public CurrencySuggestQuery(string query) : base(query) { }
    }
}
