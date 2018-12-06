using Suggestions.AspNetCore.Models;
using System.Collections.Generic;

namespace Suggestions.AspNetCore.Response
{
    public class SuggestCountryResponse
    {
        public class Suggestions : Suggestion
        {
            public CountryData data { get; set; }
        }
        public List<Suggestions> suggestions { get; set; }
    }
}
