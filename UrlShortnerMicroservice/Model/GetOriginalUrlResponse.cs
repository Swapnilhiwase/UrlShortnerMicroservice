namespace UrlShortnerMicroservice.Model
{
    public class GetOriginalUrlResponse:GenerateShortUrlResponse
    {
        /// <summary>
        /// This will be filled only if any error or entry not present in DB.
        /// </summary>
        public string message { get; set; }
    }
}
