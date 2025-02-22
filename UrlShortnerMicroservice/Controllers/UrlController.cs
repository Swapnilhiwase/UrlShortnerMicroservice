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
            try
            {
                var shortUrl = await _urlShortnerService.ShortenUrlAsync(request.longUrl);
                GenerateShortUrlResponse generateShortUrlResponse = new GenerateShortUrlResponse();
                generateShortUrlResponse.longUrl = request.longUrl;
                generateShortUrlResponse.shortUrl = shortUrl;

                return CreatedAtAction(nameof(generateShortUrl), generateShortUrlResponse);
            }
            catch(Exception ex) 
            {
                return StatusCode(500, "Internal server error.Unable to process request"+ ex.Message);
            }
        }


        [HttpPost("getOriginalUrl")]
        public async Task<IActionResult> getOriginalUrl([FromBody] GetOriginalRequestUrl request)
        {
            var longUrlResponse = await _urlShortnerService.GetOriginalUrlAsync(request.shortUrl);

            GetOriginalUrlResponse getOrignalUrlResponse = new GetOriginalUrlResponse();
            getOrignalUrlResponse.shortUrl = request.shortUrl;
            getOrignalUrlResponse.longUrl = longUrlResponse;

            if (longUrlResponse == null)
            {
                getOrignalUrlResponse.message = "URL not present into the database.";
            }


            return Ok(getOrignalUrlResponse);
        }
    }
}
