using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Domain;

namespace DomainMapping
{
   public class EmployeeMap : EntityMap<Employee>
    {
        public EmployeeMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Adress);
            Map(x => x.Phone);
            Map(x => x.Salary);
            Map(x => x.DataAngajarii);
            HasMany(x => x.Drivers).Cascade.All().Inverse();
        }
    }
}
