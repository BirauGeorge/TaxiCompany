using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using RepositoryInterface;

namespace Taxi.Controllers
{
    public class HomeController : Controller
    {
        private static ITaxiCarRepository _taxiCarRepository;

        public HomeController(ITaxiCarRepository taxiCarRepository)
        {
            _taxiCarRepository = taxiCarRepository;
        }
        public ActionResult Index()
        {
            IList<TaxiCar> taxiList=new List<TaxiCar>();
            taxiList = _taxiCarRepository.AllTaxi();
            return View(taxiList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}