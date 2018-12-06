using Suggestions.AspNetCore.Models;
using System.Collections.Generic;

namespace Suggestions.AspNetCore.Response
{
    public class SuggestBankResponse
    {
        public class Suggestions : Suggestion
        {
            public BankData data { get; set; }
        }
        public List<Suggestions> suggestions { get; set; }
    }
}
