﻿using SeasonalAnime.models;
using System.Text;
using System.Xml.Linq;

namespace SeasonalAnime
{
    public static class HtmlString
    {
        public static string BuildHtml(Anime animeData) 
        {
            var EmailTemplate = new StringBuilder();

            EmailTemplate.Append("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">");
            EmailTemplate.Append("<html xmlns=\"http://www.w3.org/1999/xhtml\" xmlns:o=\"urn:schemas-microsoft-com:office:office\" style=\"font-family:arial, 'helvetica neue', helvetica, sans-serif\">");
            EmailTemplate.Append("<head>");
            EmailTemplate.Append("<meta charset=\"UTF-8\">");
            EmailTemplate.Append("<meta content=\"width=device-width, initial-scale=1\" name=\"viewport\">");
            EmailTemplate.Append("<meta name=\"x-apple-disable-message-reformatting\">");
            EmailTemplate.Append("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
            EmailTemplate.Append("<meta content=\"telephone=no\" name=\"format-detection\">");
            EmailTemplate.Append("<title>Anime for this season</title>");
            EmailTemplate.Append("<style type=\"text/css\">");
            EmailTemplate.Append("#outlook a{padding:0}.es-button{mso-style-priority:100!important;text-decoration:none!important}a[x-apple-data-detectors]{color:inherit!important;text-decoration:none!important;font-size:inherit!important;font-family:inherit!important;font-weight:inherit!important;line-height:inherit!important}.es-desk-hidden{display:none;float:left;overflow:hidden;width:0;max-height:0;line-height:0;mso-hide:all}[data-ogsb] .es-button{border-width:0!important;padding:10px 20px!important}.es-button-border:hover a.es-button,.es-button-border:hover button.es-button{background:#56d66b!important;border-color:#56d66b!important}.es-button-border:hover{border-color:#42d159!important;background:#56d66b!important}@media only screen and (max-width:600px){.adapt-img,.es-adapt-td,.es-adaptive table,.es-left,.es-right{width:100%!important}.adapt-img,.h-auto{height:auto!important}a,ol li,p,ul li{line-height:150%!important}h1,h1 a,h2,h2 a,h3,h3 a{line-height:120%}.es-content-body h1 a,.es-footer-body h1 a,.es-header-body h1 a,h1{font-size:30px!important;text-align:left}.es-content-body h2 a,.es-footer-body h2 a,.es-header-body h2 a,h2{font-size:24px!important;text-align:left}.es-content-body h3 a,.es-footer-body h3 a,.es-header-body h3 a,h3{font-size:20px!important;text-align:left}.es-content-body a,.es-content-body ol li,.es-content-body p,.es-content-body ul li,.es-footer-body a,.es-footer-body ol li,.es-footer-body p,.es-footer-body ul li,.es-header-body a,.es-header-body ol li,.es-header-body p,.es-header-body ul li,.es-menu td a{font-size:14px!important}.es-infoblock a,.es-infoblock ol li,.es-infoblock p,.es-infoblock ul li{font-size:12px!important}.es-hidden,.es-mobile-hidden,[class=gmail-fix]{display:none!important}.es-m-txt-c,.es-m-txt-c h1,.es-m-txt-c h2,.es-m-txt-c h3{text-align:center!important}.es-m-txt-r,.es-m-txt-r h1,.es-m-txt-r h2,.es-m-txt-r h3{text-align:right!important}.es-m-txt-l,.es-m-txt-l h1,.es-m-txt-l h2,.es-m-txt-l h3{text-align:left!important}.es-m-txt-c img,.es-m-txt-l img,.es-m-txt-r img{display:inline!important}.es-button-border,a.es-button,button.es-button,table.es-social,table.es-social td{display:inline-block!important}a.es-button,button.es-button{font-size:18px!important}.es-content,.es-content table,.es-footer,.es-footer table,.es-header,.es-header table{width:100%!important;max-width:600px!important}.es-adapt-td{display:block!important}.es-desk-hidden,tr.es-desk-hidden{display:table-row!important}.es-m-p0{padding:0!important}.es-m-p0r{padding-right:0!important}.es-m-p0l{padding-left:0!important}.es-m-p0t{padding-top:0!important}.es-m-p0b{padding-bottom:0!important}.es-m-p20b{padding-bottom:20px!important}table.es-desk-hidden,td.es-desk-hidden,tr.es-desk-hidden{width:auto!important;overflow:visible!important;float:none!important;max-height:inherit!important;line-height:inherit!important}table.es-desk-hidden{display:table!important}td.es-desk-menu-hidden{display:table-cell!important}.es-menu td{width:1%!important}.es-desk-hidden,.esd-block-html table,table.es-table-not-adapt{width:auto!important}.es-desk-hidden{overflow:visible!important;max-height:inherit!important}}");
            EmailTemplate.Append("</style>");
            EmailTemplate.Append("</head>");
            EmailTemplate.Append("<body style=\"width:100%;font-family:arial, 'helvetica neue', helvetica, sans-serif;-webkit-text-size-adjust:100%;-ms-text-size-adjust:100%;padding:0;Margin:0\">");
            EmailTemplate.Append("<div class=\"es-wrapper-color\" style=\"background-color:#F6F6F6\">");
            EmailTemplate.Append("<table class=\"es-wrapper\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;padding:0;Margin:0;width:100%;height:100%;background-repeat:repeat;background-position:center top;background-color:#F6F6F6\">");
            EmailTemplate.Append("<tr>");
            EmailTemplate.Append("<td valign=\"top\" style=\"padding:0;Margin:0\">");
            EmailTemplate.Append("<table class=\"es-content\" cellspacing=\"0\" cellpadding=\"0\" align=\"center\" style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%\">");
            EmailTemplate.Append("<tr>");
            EmailTemplate.Append("<td align=\"center\" style=\"padding:0;Margin:0\">");
            EmailTemplate.Append("<table class=\"es-content-body\" cellspacing=\"0\" cellpadding=\"0\" bgcolor=\"#ffffff\" align=\"center\" style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:#FFFFFF;width:600px\">");
            EmailTemplate.Append("<tr>");
            EmailTemplate.Append("<td align=\"left\" style=\"padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px\">");
            EmailTemplate.Append("<table width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px\">");
            EmailTemplate.Append("<tr>");
            EmailTemplate.Append("<td valign=\"top\" align=\"center\" style=\"padding:0;Margin:0;width:560px\">");
            EmailTemplate.Append("<table width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" role=\"presentation\" style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px\">");
            EmailTemplate.Append("<tr>");
            EmailTemplate.Append("<td align=\"left\" style=\"padding:40px;Margin:0\">");
            EmailTemplate.Append("<p style=\"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:'comic sans ms', 'marker felt-thin', arial, sans-serif;line-height:30px;color:#333333;font-size:20px\">");
            EmailTemplate.Append("<u>");
            EmailTemplate.Append("<strong>Welcome! here's a list of this seasons Anime :)</strong>");
            EmailTemplate.Append("</u>");
            EmailTemplate.Append("</p>");
            EmailTemplate.Append("</td>");
            EmailTemplate.Append("</tr>");
            EmailTemplate.Append("</table>");
            EmailTemplate.Append("</td>");
            EmailTemplate.Append("</tr>");
            EmailTemplate.Append("</table>");
            EmailTemplate.Append("</td>");
            EmailTemplate.Append("</tr>");
            EmailTemplate.Append("</table>");
            EmailTemplate.Append("</td>");
            EmailTemplate.Append("</tr>");
            EmailTemplate.Append("</table>");
            if (animeData.Data != null)
            {
                foreach (var anime in animeData.Data)
                {
                    if (anime != null)
                    {
                        EmailTemplate.Append("<table class=\"es-content\" cellspacing=\"0\" cellpadding=\"0\" align=\"center\" style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;table-layout:fixed !important;width:100%\">");
                        EmailTemplate.Append("<tr>");
                        EmailTemplate.Append("<td align=\"center\" style=\"padding:0;Margin:0\">");
                        EmailTemplate.Append("<table class=\"es-content-body\" cellspacing=\"0\" cellpadding=\"0\" bgcolor=\"#ffffff\" align=\"center\" style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;background-color:#FFFFFF;width:600px\">");
                        EmailTemplate.Append("<tr>");
                        EmailTemplate.Append("<td align=\"left\" style=\"padding:0;Margin:0;padding-top:20px;padding-left:20px;padding-right:20px\">");
                        EmailTemplate.Append("<table cellpadding=\"0\" cellspacing=\"0\" class=\"es-left\" align=\"left\" style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;float:left\">");
                        EmailTemplate.Append("<tr>");
                        EmailTemplate.Append("<td class=\"es-m-p20b\" align=\"left\" style=\"padding:0;Margin:0;width:270px\">");
                        EmailTemplate.Append("<table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" role=\"presentation\" style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px\">");
                        EmailTemplate.Append("<tr>");
                        EmailTemplate.Append("<td align=\"center\" style=\"padding:0;Margin:0;font-size:0px\">");
                        EmailTemplate.Append("<img class=\"adapt-img\" src=\"");
                        EmailTemplate.Append(anime.Images.Jpg.ImageUrl);
                        EmailTemplate.Append("\" alt style=\"display:block;border:0;outline:none;text-decoration:none;-ms-interpolation-mode:bicubic\" width=\"225\" height=\"319\">");
                        EmailTemplate.Append("</td>");
                        EmailTemplate.Append("</tr>");
                        EmailTemplate.Append("</table>");
                        EmailTemplate.Append("</td>");
                        EmailTemplate.Append("</tr>");
                        EmailTemplate.Append("</table>");
                        EmailTemplate.Append("<table cellpadding=\"0\" cellspacing=\"0\" class=\"es-right\" align=\"right\" style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px;float:right\">");
                        EmailTemplate.Append("<tr>");
                        EmailTemplate.Append("<td align=\"left\" style=\"padding:0;Margin:0;width:270px\">");
                        EmailTemplate.Append("<table cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" role=\"presentation\" style=\"mso-table-lspace:0pt;mso-table-rspace:0pt;border-collapse:collapse;border-spacing:0px\">");
                        EmailTemplate.Append("<tr>");
                        EmailTemplate.Append("<td align=\"left\" style=\"padding:0;Margin:0\">");
                        EmailTemplate.Append("<p style=\"Margin:0;-webkit-text-size-adjust:none;-ms-text-size-adjust:none;mso-line-height-rule:exactly;font-family:arial, 'helvetica neue', helvetica, sans-serif;line-height:21px;color:#333333;font-size:14px\">");
                        EmailTemplate.Append(anime.Synopsis);
                        EmailTemplate.Append("</p>");
                        EmailTemplate.Append("</td>");
                        EmailTemplate.Append("</tr>");
                        EmailTemplate.Append("</table>");
                        EmailTemplate.Append("</td>");
                        EmailTemplate.Append("</tr>");
                        EmailTemplate.Append("</table>");
                        EmailTemplate.Append("</td>");
                        EmailTemplate.Append("</tr>");
                        EmailTemplate.Append("</table>");
                    }
                }
            }
            EmailTemplate.Append("</td>");
            EmailTemplate.Append("</tr>");
            EmailTemplate.Append("</table>");
            EmailTemplate.Append("</div>");
            EmailTemplate.Append("<div class=\"banner-toolbar\"></div>");
            EmailTemplate.Append("</body>");
            EmailTemplate.Append("</html>");

            return EmailTemplate.ToString();
        }
    }
}
 