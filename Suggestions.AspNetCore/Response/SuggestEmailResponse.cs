using Suggestions.AspNetCore.Models;
using System.Collections.Generic;

namespace Suggestions.AspNetCore.Response
{
    public class SuggestEmailResponse
    {
        public class Suggestions : Suggestion
        {
            public EmailData data { get; set; }
        }
        public List<Suggestions> suggestions { get; set; }
    }
}
