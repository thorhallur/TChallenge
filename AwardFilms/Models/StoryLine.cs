using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Spatial;

namespace AwardFilms.Models
{
    public class StoryLine
    {
        public int Id { get; set; }
        public int TitleId { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}