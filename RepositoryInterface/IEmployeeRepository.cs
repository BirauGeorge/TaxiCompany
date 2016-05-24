using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Dto;

namespace RepositoryInterface
{
    public interface IEmployeeRepository
    {
        void Save(Employee entity);
        Employee Get(long id);
        void Delete(Employee entity);
        void  Update(Employee entity);
        IList<Employee> SlectAllEmployees();
        IList<Employee> ShowTop3EmployeesbySalary();
        IList<Employee> ShowDriverSalary();
        IList<DriverDetailsDto> EmployeeDate();
        IList<Driver> SubSelectEmployees();
        IList<DriverInfo> SelectAllInfo();
        IList<DriverInfo> SelectDriverDetail(int id);
    }
}
