using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using RepositoryInterface;
using Domain;
using Domain.Dto;
using FluentNHibernate.Utils;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace Repository_Implementation
{
    public class EmployeeRepository: IEmployeeRepository
    {
        public void Save(Employee entity)
        {
            using (ITransaction transaction = _session.BeginTransaction())
            {
                _session.SaveOrUpdate(entity);
               
                transaction.Commit(); 
            }
           
        }

        public IList<Employee> SlectAllEmployees()
        {
            Employee employeealias = null;
            IList<Employee> employees = _session.QueryOver(() => employeealias).List();
            return employees;
        }

        public Employee Get(long id)
        {
            return _session.Get<Employee>(id);
        }

        public void Update(Employee entity)
        {
            _session.Update(entity);
           
        }

        public IList<Employee> ShowTop3EmployeesbySalary()
        {
            Employee employeealias = null;
            IList<Employee> employees = _session.QueryOver(() => employeealias)
                .OrderBy(x => x.Salary).Desc
                .Take(3).List();

            return employees;

        }
        public IList<Employee> ShowDriverSalary()
        {
            Employee employeeAlias = null;
            Driver driverAlias = null;
           
            using (ITransaction transaction = _session.BeginTransaction())
            {
                IList<Employee> employees = _session.QueryOver(() => employeeAlias)
                    .JoinAlias(x => x.Drivers, () => driverAlias)
                  
                    .List();

                return employees;
            }
        }
        public IList<DriverDetailsDto> EmployeeDate()
        {
            DriverDetailsDto driverDetailsDto=null;
            Employee employeeAlias = null;
         //   Driver driverAlias = null;

            using (ITransaction transaction = _session.BeginTransaction())
            {
                var employeeData = _session.QueryOver(() => employeeAlias)
                    .SelectList(
                        list => list.Select(() => employeeAlias.FirstName)
                            .WithAlias(() => driverDetailsDto.FirstName)
                            .Select(() => employeeAlias.LastName)
                            .WithAlias(() => driverDetailsDto.LastName)
                            .Select(() => employeeAlias.Salary)
                            .WithAlias(() => driverDetailsDto.Salary)
                    ).TransformUsing(Transformers.AliasToBean<DriverDetailsDto>()).List<DriverDetailsDto>();
                  

                return employeeData;
            }

        }
     //   select * from dbo.Driver where DayEarnings > (select AVG(DayEarnings) from Driver)

        //public IList<Employee> SubSelectEmployees()
        //{
        //    Employee employeeAlias = null;
        //    Driver driverAlias = null;
        //    var subselect = QueryOver.Of<Driver>().SelectList(list => list.SelectAvg(x => x.DayEarnings));

        //    return subselect();
        //}

        public IList<Driver> SubSelectEmployees()
        {
            Employee employeeAlias = null;
            Driver driverAlias = null;
            //var subselect = QueryOver.Of<Driver>().SelectList(list => list.SelectAvg(x => x.DayEarnings));


            IList<Driver> employees =
                _session.QueryOver<Driver>(() => driverAlias)
                    .JoinAlias(() => driverAlias.Employee, () => employeeAlias)
                    .WithSubquery.WhereAll(p => p.DayEarnings > QueryOver.Of<Driver>()
                        .SelectList(list => list.SelectAvg(x => x.DayEarnings)).As<double>())
                    .List<Driver>();


            return employees;
        }
        protected readonly ISession _session = SessionGenerator.Instance.GetSession();
    }
}
