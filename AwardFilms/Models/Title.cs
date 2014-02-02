using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Spatial;

namespace AwardFilms.Models
{
    public class Title
    {
        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public int ReleaseYear { get; set; }
    }
}