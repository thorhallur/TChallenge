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
    public class TitlesController : ApiController
    {
        private AwardFilmsContext db = new AwardFilmsContext();

        // GET api/Titles
        public IEnumerable<Title> GetTitles(string q = "")
        {
            if (q.Length > 0)
                return db.Titles.Where(t => t.TitleName.Contains(q)).AsEnumerable();
            else
                return db.Titles.AsEnumerable();
                         
        }

        // GET api/Titles/5
        public Title GetTitle(int id)
        {
            Title title = db.Titles.Find(id);
            if (title == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return title;
        }


    }
}