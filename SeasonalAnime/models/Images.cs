using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeasonalAnime.models.Anime;

namespace SeasonalAnime.models
{
    public class Images
    {
        [JsonProperty("jpg")]
        public Jpg? Jpg { get; set; }

        [JsonProperty("webp")]
        public Webp? Webp { get; set; }
    }
}
