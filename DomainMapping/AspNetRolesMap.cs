using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using FluentNHibernate.Mapping;

namespace DomainMapping
{
   public class AspNetRolesMap:ClassMap<AspNetRoles>
   {
        public AspNetRolesMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);

        }
    }
}
