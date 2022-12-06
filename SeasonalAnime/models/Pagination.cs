using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeasonalAnime.models.Anime;

namespace SeasonalAnime.models
{
    public class Pagination
    {
        public int last_visible_page { get; set; }
        public bool has_next_page { get; set; }
        public int current_page { get; set; }
        public Items items { get; set; }
    }
}
