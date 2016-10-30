using DomainModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class NavController : Controller
    {
        private ISongRepo repository;
        public NavController(ISongRepo repo)
        {
            repository = repo;
        }
        // GET: Nav
        public ActionResult Navigation()
        {
            repository.Songs.Select(x => x.Rate);
            var navigation = new NavigationViewModel() {
                Rates = repository.Songs.Select(x => x.Rate).Distinct(),
                Genres = repository.Songs.Select(x => x.Genre).Distinct(),
                Years = repository.Songs.Select(x => x.Year).Distinct()
            };
        
            return PartialView(navigation);
        }
    }
}