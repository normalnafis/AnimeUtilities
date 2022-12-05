using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonalAnime
{
    public static class Jikan
    {
        public static void GetAnimeCurrentSeason()
        {
            using(var client = new RestClient("https://api.jikan.moe/v4/seasons/now"))
            {
                var request = new RestRequest();
                var result = client.GetAsync(request);
            }
        }
        public static void GetAnimeFromAnySeason(string year, string season)
        {
            using (var client = new RestClient("https://api.jikan.moe/v4/seasons/now"))
            {
                var request = new RestRequest();
                var result = client.GetAsync(request).Result;
            }
        }
    }
}
