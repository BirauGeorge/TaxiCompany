using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using FluentNHibernate.Mapping;

namespace DomainMapping
{
    public class TaxiCarMap : ClassMap<TaxiCar>
    {
        public TaxiCarMap()
        {
            Id(x => x.Id);
            Map(x => x.Plate).Nullable();
            Map(x => x.UniquieId).Not.Nullable();
            Map(x => x.Brand).Not.Nullable();
            Map(x => x.Price).Not.Nullable();
            Map(x => x.GeoLat).Nullable();
            Map(x => x.GeoLong).Nullable();
           
        }
    }
}
