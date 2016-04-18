using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using Factories;
using Infrastructure;
using RepositoryInterface;

namespace Taxi.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
   
        private static IEmployeeRepository _employeeRepository;

        public AdminController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
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
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: Employee/Create
        [Authorize]
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
               Employee thisnew = new Employee(employee.FirstName, employee.FirstName, employee.Adress, employee.Phone, employee.Salary);
               _employeeRepository.Save(thisnew);
            
                return View();
            
        }
        
        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
           var employee = _employeeRepository.Get(id);
            return View(employee);
        }

        // POST: Employee/Edit/5
        [Authorize]
        [HttpPost]
        public ActionResult Edit(int id, Employee collection)
        {
         
            _employeeRepository.Update(collection);
            return RedirectToAction("Index");
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
