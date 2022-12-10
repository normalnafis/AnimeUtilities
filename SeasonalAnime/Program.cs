using Newtonsoft.Json;
using SeasonalAnime;
using SeasonalAnime.models;
using Microsoft.Extensions.Configuration;
using SeasonalAnime.appSettingsModels;
using System.Net.Mail;
using System.Net;

var config = new ConfigurationBuilder()
               .AddJsonFile("C:\\Users\\Nafis Rahman\\source\\repos\\AnimeUtilities\\SeasonalAnime\\appsettings.json", false)
               .Build();

var responseBody = Jikan.GetAnimeCurrentSeason();
var html = "";
if (responseBody != null)
{
    var animeData = JsonConvert.DeserializeObject<Anime>(responseBody);
    if (animeData != null)
    {
        html = HtmlString.BuildHtml(animeData);
    }
}

var emaildetails = config.GetRequiredSection("Emaildetails").Get<Emaildetails>();
if (emaildetails != null) {SmtpInitialize.SendEmail(emaildetails, html);}
