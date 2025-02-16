
using UrlShortnerMicroservice.Model;

namespace UrlShortnerMicroservice.Services
{
    public class UrlShortnerService : IUrlShortnerService
    {
        private Random _random = new Random();
        private const string Alphabet = "abcderdghdufjsdhsjsjo65845187f";
        public Task<string> GetOriginalUrlAsync(string shortCode)
        {
            throw new NotImplementedException();
        }

        public async Task<string> ShortenUrlAsync(string originalUrl)
        {

           
            var shortcode = GenerateShortCode();
            var shortUrl = "newgen.ly" + shortcode;

            var mapping = new UrlMapping();
            mapping.ShortenUrl = shortUrl;
            mapping.OrignalUrl = originalUrl;
            
            var response= await
        }

        private string GenerateShortCode(int length = 6)
        {
            return new string(Enumerable.Repeat(Alphabet, length).Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}
