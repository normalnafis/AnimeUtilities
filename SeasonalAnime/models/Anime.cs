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
        public Pagination pagination { get; set; }
        public Datum[] data { get; set; }

        public class Datum
        {
            public int mal_id { get; set; }
            public string url { get; set; }
            public Images images { get; set; }
            public Trailer trailer { get; set; }
            public bool approved { get; set; }
            public string title { get; set; }
            public string title_english { get; set; }
            public string title_japanese { get; set; }
            public string[] title_synonyms { get; set; }
            public string type { get; set; }
            public string source { get; set; }
            public int? episodes { get; set; }
            public string status { get; set; }
            public bool airing { get; set; }
            public string duration { get; set; }
            public string rating { get; set; }
            public float score { get; set; }
            public int scored_by { get; set; }
            public int rank { get; set; }
            public int popularity { get; set; }
            public int members { get; set; }
            public int favorites { get; set; }
            public string synopsis { get; set; }
            public string background { get; set; }
            public string season { get; set; }
            public int year { get; set; }
        }

    }
}`
