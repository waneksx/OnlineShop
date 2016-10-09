using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainModel.Entities;
using DomainModel.Abstract;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ISongRepo Songs;
        public HomeController(ISongRepo Songs)
        {
            this.Songs = Songs;
        }
        // GET: Home
        public ActionResult Index()
        {
            var songs = Songs.Songs;
            return View(songs);
        }
    }
}