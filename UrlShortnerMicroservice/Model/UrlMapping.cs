using System.ComponentModel.DataAnnotations;

namespace UrlShortnerMicroservice.Model
{
    public class UrlMapping
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string longUrl { get; set; } = string.Empty;

        [Required]
        public string shortUrl { get; set; } = string.Empty;

    }
}
