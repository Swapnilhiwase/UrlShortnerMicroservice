
using Microsoft.EntityFrameworkCore;
using UrlShortnerMicroservice.Data;
using UrlShortnerMicroservice.Model;

namespace UrlShortnerMicroservice.Services
{
    public class UrlShortnerService : IUrlShortnerService
    {
        private UrlShortenerContext _context = new UrlShortenerContext();
        private Random _random = new Random();
        private const string Alphabet = "abcderdghdufjsdhsjsjo65845187f";


        public async Task<string> GetOriginalUrlAsync(string shortUrl)
        {
            var response = await _context.UrlMappings.FirstOrDefaultAsync(s => s.shortUrl == shortUrl);
            if (response != null)
            {
                return response.longUrl;
            }
            return null;
        }

        public async Task<string> ShortenUrlAsync(string originalUrl)
        {

           
            var shortcode = GenerateShortCode();
            var shortUrl = "newgen.ly" + shortcode;

            var mapping = new UrlMapping();
            mapping.shortUrl = shortUrl;
            mapping.longUrl = originalUrl;

            var response = await _context.UrlMappings.AddAsync(mapping);
            await _context.SaveChangesAsync();
            return response.Entity.shortUrl;
        }

        private string GenerateShortCode(int length = 6)
        {
            return new string(Enumerable.Repeat(Alphabet, length).Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}
