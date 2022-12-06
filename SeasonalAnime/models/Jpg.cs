using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonalAnime.models
{
    public class Jpg
    {
        [JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        [JsonProperty("small_image_url")]
        public string? SmallImageUrl { get; set; }

        [JsonProperty("large_image_url")]
        public string? LargeImageUrl { get; set; }
    }
}
