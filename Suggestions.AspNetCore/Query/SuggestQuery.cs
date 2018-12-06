namespace Suggestions.AspNetCore.Query
{
    public class SuggestQuery
    {
        public string query { get; set; }
        public int count { get; set; }
        public SuggestQuery(string query)
        {
            this.query = query;
        }
    }
}
