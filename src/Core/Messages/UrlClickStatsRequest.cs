namespace Cloud5mins.ShortenerTools.Core.Messages
{
    public class UrlClickStatsRequest
    {
        public string Vanity { get; set; } = string.Empty;
        public string StartDate { get; set; } = string.Empty;
        public string EndDate { get; set; } = string.Empty;

        public UrlClickStatsRequest() { }
        public UrlClickStatsRequest(string vanity, string startDate, string endDate)
        {
            Vanity = vanity ?? string.Empty;
            StartDate = startDate ?? string.Empty;
            EndDate = endDate ?? string.Empty;
        }
    }
}