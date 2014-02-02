using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using AwardFilms.Models;

namespace AwardFilms.Controllers
{
    public class StoryLinesController : ApiController
    {
        private AwardFilmsContext db = new AwardFilmsContext();

        // GET api/StoryLines
        public IEnumerable<StoryLine> GetStoryLines()
        {
            return db.StoryLines.AsEnumerable();
            
        }

        // GET api/StoryLines/5
        public IEnumerable<StoryLine> GetStoryLine(int id)
        {
            return db.StoryLines.Where(t => t.TitleId == id).AsEnumerable();
              
        }

    }
}