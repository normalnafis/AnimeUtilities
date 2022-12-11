using SeasonalAnime.appSettingsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SeasonalAnime
{
    public static class SmtpInitialize
    {
        public static void SendEmail (Emaildetails emaildetails, string html)
        {
            if (emaildetails != null)
            {
                var year = Season.GetYear();
                var season = Season.GetCurrentSeason();
                SmtpClient Client = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential()
                    {
                        UserName = emaildetails.Email,
                        Password = emaildetails.Password
                    }
                };

                var FromEmail = new MailAddress(emaildetails.Email, emaildetails.Name);
                var ToEmail = new MailAddress(emaildetails.ToEmail, emaildetails.ToName);
                var Message = new MailMessage
                {
                    From = FromEmail,
                    Subject = $"Anime for the season {season} {year}",
                    Body = html,
                    IsBodyHtml = true
                };
                Message.To.Add(ToEmail);

                try
                {
                    Client.Send(Message);
                }
                catch(Exception ex)
                {
                    throw new ArgumentException(ex.Message);
                }
            }
        }
    }
}
