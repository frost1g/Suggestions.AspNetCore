using Suggestions.AspNetCore.Models;
using System.Collections.Generic;

namespace Suggestions.AspNetCore.Response
{
    public class SuggestAddressResponse
    {
        public class Suggestions : Suggestion
        {
            public AddressData data { get; set; }
        }
        public List<Suggestions> suggestions { get; set; }
    }
}
