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
        private ISongRepo songsRepo;
        public HomeController(ISongRepo Songs)
        {
            songsRepo = Songs;
        }
        // GET: Home
        public ActionResult Index()
        {
            var songs = songsRepo.Songs;
            return View(songs);
        }
    }
}