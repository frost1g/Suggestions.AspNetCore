using Suggestions.AspNetCore.Models;
using System.Collections.Generic;

namespace Suggestions.AspNetCore.Response
{
    public class SuggestPartyResponse
    {
        public class Suggestions : Suggestion
        {
            public PartyData data { get; set; }
        }
        public List<Suggestions> suggestions { get; set; }
    }
}
