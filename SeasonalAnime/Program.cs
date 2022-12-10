using Newtonsoft.Json;
using SeasonalAnime;
using SeasonalAnime.models;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", false)
               .Build();


var currentSeason = Season.GetCurrentSeason();
var currentYear = Season.GetYear();
Console.WriteLine($"The current season is {currentSeason}, and the current year is {currentYear}");
var responseBody = Jikan.GetAnimeCurrentSeason();
if (responseBody != null)
{
    var animeData = JsonConvert.DeserializeObject<Anime>(responseBody);
    if(animeData != null)
    {
        var data = animeData.Data;
    }
}