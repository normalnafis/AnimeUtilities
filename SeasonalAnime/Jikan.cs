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
        public static void GetAnimeFromSeason()
        {
            var apiClient = new RestClient("https://api.jikan.moe/v4/");
            var request = new RestRequest("seasons");
            var response = apiClient.Execute(request);
        }
    }
}
