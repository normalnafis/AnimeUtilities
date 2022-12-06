// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using SeasonalAnime;
using SeasonalAnime.models;

var currentSeason = Season.GetCurrentSeason();
var currentYear = Season.GetYear();
Console.WriteLine($"The current season is {currentSeason}, and the current year is {currentYear}");
var responseBody = Jikan.GetAnimeCurrentSeason();
if (responseBody != null)
{
    var animeData = JsonConvert.DeserializeObject<Anime>(responseBody);
    var data = animeData.data;
}
Console.ReadLine();