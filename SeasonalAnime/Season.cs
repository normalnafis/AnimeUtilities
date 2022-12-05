using SeasonalAnime;

namespace SeasonalAnime
{
    public static class Season
    {
        public static string GetYear()
        {
            var today = DateTime.Now.ToLocalTime();
            return today.Year.ToString();
        }
        public static string GetCurrentSeason()
        {
            var today = DateTime.Now.ToLocalTime();
            int month_name = today.Month;
            string seasonName = "";
            switch (month_name)
            {
                case 1:
                    seasonName = "Winter";
                    break;
                case 2:
                    seasonName = "Winter";
                    break;
                case 3:
                    seasonName = "Winter";
                    break;
                case 4:
                    seasonName = "Spring";
                    break;
                case 5:
                    seasonName = "Spring";
                    break;
                case 6:
                    seasonName = "Spring";
                    break;
                case 7:
                    seasonName = "Summer";
                    break;
                case 8:
                    seasonName = "Summer";
                    break;
                case 9:
                    seasonName = "Summer";
                    break;
                case 10:
                    seasonName = "Fall";
                    break;
                case 11:
                    seasonName = "Fall";
                    break;
                case 12:
                    seasonName = "Fall";
                    break;
            }
            return seasonName;
        }
    }
}