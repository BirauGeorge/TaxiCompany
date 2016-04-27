using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using Factories;
using HibernatingRhinos.Profiler.Appender.NHibernate;
using Infrastructure;
using RepositoryInterface;

namespace Taxi.Controllers
{

    public class AdminController : Controller
    {
   
        private static IEmployeeRepository _employeeRepository;
        private static IAccountRepository _accountRepository;
        private static IDriverRepository _driverRepository;

        public AdminController(IEmployeeRepository employeeRepository,IAccountRepository accountRepository, IDriverRepository driverRepository)
        {
            NHibernateProfiler.Initialize();
            _employeeRepository = employeeRepository;
            _accountRepository = accountRepository;
            _driverRepository = driverRepository;
        }
        
        // GET: Employee
        public ActionResult Index()
        {
            IList<Employee> employee=new List<Employee>();
            employee = _employeeRepository.SlectAllEmployees();
            return View(employee);
        }
        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var driver = _employeeRepository.SelectDriverDetail(id);
            return View(driver);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
           
            return View();
        }

        //POST: Employee/Create
       [Authorize]
       [HttpPost]
        public ActionResult Create(Driver driver)
       {
           Driver thisnew = new Driver()
           {

           };
            

            return View();

        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
           var employee = _employeeRepository.Get(id);
           return View(employee);
        }

        // POST: Employee/Edit/5
      
      
        [HttpPost]
        public ActionResult Edit(int id, Employee collection)
        {
         
            _employeeRepository.Update(collection);
            return RedirectToAction("Index","Admin");
        }

        public ActionResult AddRoles()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRoles(AspNetRoles aspNetRoles)
        {
            AspNetRoles aspNetRolesCreate = new AspNetRoles(aspNetRoles.Name);
            
            _accountRepository.AddRoles(aspNetRoles);
            return View();
        }
        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("~/Views/Employee/Employee.aspx");
            }
            catch
            {
                return View();
            }
        }
       


    }
}
