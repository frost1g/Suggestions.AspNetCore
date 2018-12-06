using Suggestions.AspNetCore.Models;
using System.Collections.Generic;

namespace Suggestions.AspNetCore.Response
{
    public class SuggestFioResponse
    {
        public class Suggestions : Suggestion
        {
            public FioData data { get; set; }
        }
        public List<Suggestions> suggestions { get; set; }
    }
}
