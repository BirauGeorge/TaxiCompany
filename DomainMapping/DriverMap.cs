using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using FluentNHibernate.Mapping;



namespace DomainMapping
{
    public class DriverMap :ClassMap<Driver>
    {
        public DriverMap()
        {
            Id(x => x.Id);        
            Map(x => x.OnDuty).Not.Nullable();
  
            References(x => x.Employee).Not.Nullable();
            References(x => x.TaxiCar).Nullable();         
        }
    }
}
