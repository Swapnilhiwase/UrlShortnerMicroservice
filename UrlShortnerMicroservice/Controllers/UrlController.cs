using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UrlShortnerMicroservice.Model;
using UrlShortnerMicroservice.Services;

namespace UrlShortnerMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrlController : ControllerBase
    {/// <summary>
     /// Instance of IUrlShortnerService
     /// </summary>
        private IUrlShortnerService _urlShortnerService;
       
        public UrlController(IUrlShortnerService urlShortnerService) 
        {
            _urlShortnerService = urlShortnerService;
        }
        /// <summary>
        /// this will provide a short url for given long url
        /// </summary>
        /// <param name="request">Instance of GenerateShortUrlRequest </param>
        /// <returns>on complition will return the long url with valid statuscode</returns>
        [HttpPost("generateshortUrl")]
        public async Task<IActionResult> generateShortUrl([FromBody] GenerateShortUrlRequest request)
        {
           await  _urlShortnerService.ShortenUrlAsync(request.longUrl);
            return Created();
        }

        [HttpPost("getOriginalUrl")]
        public IActionResult getOriginalUrl([FromBody] GetOriginalRequestUrl request)
        {
            UrlShortnerService serviceObj;
            serviceObj.GetOriginalUrlAsync("");
            return Ok();
        }
    }
}
