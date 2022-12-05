// See https://aka.ms/new-console-template for more information
using SeasonalAnime;

var currentSeason = Season.GetCurrentSeason();
var currentYear = Season.GetYear();
Console.WriteLine($"The current season is {currentSeason} and the current year is {currentYear}");