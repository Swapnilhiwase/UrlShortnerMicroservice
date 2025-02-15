namespace UrlShortnerMicroservice.Services
{
    /// <summary>
    /// Interface layer for the URL Service.
    /// </summary>
    public interface IUrlShortnerService
    {
        /// <summary>
        /// Method which will perform the shortning of the long url provided.
        /// </summary>
        /// <param name="originalUrl"></param>
        /// <returns>Instance of string indicating shortened url for longurl.</returns>
        Task<string> ShortenUrlAsync(string originalUrl);

        /// <summary>
        /// Method will return the valid long url for given shortUrl.
        /// </summary>
        /// <param name="shortCode"></param>
        /// <returns>Instance of string representing the long url for given short url.</returns>
        Task<string> GetOriginalUrlAsync(string shortCode);
    }
}
