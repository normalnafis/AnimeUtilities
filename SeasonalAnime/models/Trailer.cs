using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonalAnime.models
{
    public class Trailer
    {
        [JsonProperty("youtube_id")]
        public string? YoutubeId { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }
        
        [JsonProperty("embed_url")]
        public string? EmbedUrl { get; set; }
    }
}
