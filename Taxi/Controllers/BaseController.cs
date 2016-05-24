using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using Domain;
using Domain.Dto;
using Factories;
using HibernatingRhinos.Profiler.Appender.NHibernate;
using Infrastructure;
using RepositoryInterface;
using Topshelf.Configurators;

namespace Taxi.Controllers
{
    public class BaseController 
    {
        private static IEmployeeRepository _employeeRepository;
        private static IAccountRepository _accountRepository;
        private static IDriverRepository _driverRepository;
        private static ITaxiCarRepository _taxiCarRepository;

        public BaseController(IEmployeeRepository employeeRepository, IAccountRepository accountRepository,
            IDriverRepository driverRepository, ITaxiCarRepository taxiCarRepository)
        {

            _employeeRepository = employeeRepository;
            _accountRepository = accountRepository;
            _driverRepository = driverRepository;
            _taxiCarRepository = taxiCarRepository;
        }
       
    }
}