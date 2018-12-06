using Suggestions.AspNetCore.Response;

namespace Suggestions.AspNetCore.Models
{
    public class PartyData
    {
        public SuggestAddressResponse.Suggestions address { get; set; }

        public string branch_count { get; set; }
        public PartyBranchType branch_type { get; set; }

        public string inn { get; set; }
        public string kpp { get; set; }
        public string ogrn { get; set; }
        public string ogrn_date { get; set; }
        public string hid { get; set; }

        public PartyManagementData management { get; set; }
        public PartyNameData name { get; set; }

        public string okpo { get; set; }
        public string okved { get; set; }
        public string okved_type { get; set; }

        public PartyOpfData opf { get; set; }
        public PartyStateData state { get; set; }
        public PartyType type { get; set; }
    }

    public enum PartyBranchType
    {
        MAIN,
        BRANCH
    }

    public class PartyManagementData
    {
        public string name { get; set; }
        public string post { get; set; }
    }

    public class PartyNameData
    {
        public string full_with_opf { get; set; }
        public string short_with_opf { get; set; }
        public string latin { get; set; }
        public string full { get; set; }
        public string @short { get; set; }
    }

    public class PartyOpfData
    {
        public string code { get; set; }
        public string full { get; set; }
        public string @short { get; set; }
    }

    public class PartyStateData
    {
        public string actuality_date { get; set; }
        public string registration_date { get; set; }
        public string liquidation_date { get; set; }
        public PartyStatus status { get; set; }
    }

    public enum PartyStatus
    {
        ACTIVE,
        LIQUIDATING,
        LIQUIDATED
    }

    public enum PartyType
    {
        LEGAL,
        INDIVIDUAL
    }
}