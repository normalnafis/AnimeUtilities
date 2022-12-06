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
        public static RestResponse GetAnimeCurrentSeason()
        {
            using(var client = new RestClient("https://api.jikan.moe/v4/seasons/now"))
            {
                var request = new RestRequest();
                var result = client.Get(request);
                return result;
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
