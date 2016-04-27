using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using RepositoryInterface;
using Domain;
using Domain.Dto;

namespace Repository_Implementation
{
    public class DriverRepository : IDriverRepository
    {
        private static IEmployeeRepository _employeeRepository;

        public DriverRepository(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public void Save(Driver entity)
        {
            Employee add = new Employee();
            add = entity.Employee;
            using (ITransaction transaction = _session.BeginTransaction())
            {
                _employeeRepository.Save(add);
                _session.SaveOrUpdate(entity);
                transaction.Commit(); 
            }
        }


        protected readonly ISession _session = SessionGenerator.Instance.GetSession();
    }
}
