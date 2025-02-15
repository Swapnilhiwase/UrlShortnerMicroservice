
using UrlShortnerMicroservice.Model;

namespace UrlShortnerMicroservice.Services
{
    public class UrlShortnerService : IUrlShortnerService
    {

        public Task<string> GetOriginalUrlAsync(string shortCode)
        {
            throw new NotImplementedException();
        }

        public Task<string> ShortenUrlAsync(string originalUrl)
        {

           
            var shortcode = GenerateShortCode();
            var shortUrl = "newgen.ly" + shortcode;

            var mapping = new UrlMapping();
            mapping.shortcode=shortUrl();
            mapping.longUrl = originalUrl();
           
            throw new NotImplementedException();
        }

        private string GenerateShortCode(int length = 6)
        {
            return new string(Enumerable.Repeat(Alphabet, length).Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}
