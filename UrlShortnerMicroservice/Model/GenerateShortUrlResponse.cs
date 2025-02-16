﻿namespace UrlShortnerMicroservice.Model
{/// <summary>
/// response model class for generateshortUrl
/// </summary>
    public class GenerateShortUrlResponse
    {
        /// <summary>
        /// Instance of string
        /// </summary>
        public string longUrl {  get; set; }

        /// <summary>
        /// Instance of string
        /// </summary>
        public string shortUrl { get; set; }
    }
}
