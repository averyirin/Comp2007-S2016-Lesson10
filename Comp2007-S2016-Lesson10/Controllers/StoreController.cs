using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comp2007_S2016_Lesson10.Models;

namespace Comp2007_S2016_Lesson10.Controllers
{
    
  //  [Authorize]
    public class StoreController : Controller
    {
        MusicStoreContext storeDB = new MusicStoreContext();

        //
        // GET: /Store/
        [AllowAnonymous]
        public ActionResult Index() {
            List<Genre> genres = storeDB.Genres.ToList();
            return View(genres);
        }
        //
        // GET: /Store/Browse?genre=Disco
      //  [AllowAnonymous]
        public ActionResult Browse(string genre="Rock")
        {
            Genre genreModel = storeDB.Genres.Include("Albums")
       .Single(g => g.Name == genre);

            return View(genreModel);
        }
        //
        // GET: /Store/Details/5
        //[AllowAnonymous]
        public ActionResult Details(int id = 1)
        {
            Album album = storeDB.Albums.Find(id);

            return View(album);
        }
    }
}