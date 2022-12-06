using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SeasonalAnime.models
{
    public class Anime
    {
        [JsonProperty("pagination")]
        public Pagination? Pagination { get; set; }

        [JsonProperty("data")]
        public Datum[]? Data { get; set; }

        public class Datum
        {
            [JsonProperty("mal_id")]
            public int MalId { get; set; }

            [JsonProperty("url")]
            public string? Url { get; set; }

            [JsonProperty("images")]
            public Images? Images { get; set; }

            [JsonProperty("trailer")]
            public Trailer? Trailer { get; set; }

            [JsonProperty("approved")]
            public bool Approved { get; set; }

            [JsonProperty("title")]
            public string? Title { get; set; }

            [JsonProperty("title_english")]
            public string? TitleEnglish { get; set; }

            [JsonProperty("title_japanese")]
            public string? TitleJapanese { get; set; }

            [JsonProperty("title_synonyms")]
            public string[]? TitleSynonyms { get; set; }

            [JsonProperty("type")]
            public string? Type { get; set; }

            [JsonProperty("source")]
            public string? Source { get; set; }

            [JsonProperty("episodes")]
            public int? Episodes { get; set; }

            [JsonProperty("status")]
            public string? Status { get; set; }

            [JsonProperty("airing")]
            public bool Airing { get; set; }

            [JsonProperty("duration")]
            public string? Duration { get; set; }

            [JsonProperty("rating")]
            public string? Rating { get; set; }

            [JsonProperty("score")]
            public float Score { get; set; }

            [JsonProperty("scored_by")]
            public int ScoredBy { get; set; }

            [JsonProperty("rank")]
            public int Rank { get; set; }

            [JsonProperty("popularity")]
            public int Popularity { get; set; }

            [JsonProperty("members")]
            public int Members { get; set; }

            [JsonProperty("favorites")]
            public int Favorites { get; set; }

            [JsonProperty("synopsis")]
            public string? Synopsis { get; set; }

            [JsonProperty("background")]
            public string? Background { get; set; }

            [JsonProperty("season")]
            public string? Season { get; set; }

            [JsonProperty("year")]
            public int Year { get; set; }
        }

    }
}
