using Suggestions.AspNetCore.Models;
using System.Collections.Generic;

namespace Suggestions.AspNetCore.Response
{
    public class SuggestCurrencyResponse
    {
        public class Suggestions : Suggestion
        {
            public CurrencyData data { get; set; }
        }
        public List<Suggestions> suggestions { get; set; }
    }
}
