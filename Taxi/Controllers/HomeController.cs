using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using HibernatingRhinos.Profiler.Appender.NHibernate;
using RepositoryInterface;

namespace Taxi.Controllers
{
    public class HomeController : Controller
    {
        private static ITaxiCarRepository _taxiCarRepository;
        private static IEmployeeRepository _employeeRepository;

        public HomeController(ITaxiCarRepository taxiCarRepository, IEmployeeRepository employeeRepository)
        {
            NHibernateProfiler.Initialize();
            _taxiCarRepository = taxiCarRepository;
            _employeeRepository = employeeRepository;
        }
        public ActionResult Index()
        {

            var date= _employeeRepository.SelectAllInfo();

            return View(date);
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