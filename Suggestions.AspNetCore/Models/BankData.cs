using Suggestions.AspNetCore.Response;

namespace Suggestions.AspNetCore.Models
{
    public class BankData
    {
        public SuggestAddressResponse.Suggestions address { get; set; }

        public string bic { get; set; }
        public string swift { get; set; }
        public string registration_number { get; set; }
        public string correspondent_account { get; set; }

        public BankNameData name { get; set; }
        public string okpo { get; set; }
        public BankOpfData opf { get; set; }
        public string phone { get; set; }
        public string rkc { get; set; }
        public PartyStateData state { get; set; }
    }

    public class BankNameData
    {
        public string payment { get; set; }
        public string full { get; set; }
        public string @short { get; set; }
    }

    public class BankOpfData
    {
        public BankType type { get; set; }
        public string full { get; set; }
        public string @short { get; set; }
    }

    public enum BankType
    {
        BANK,
        NKO,
        BANK_BRANCH,
        NKO_BRANCH,
        RKC,
        OTHER
    }
}