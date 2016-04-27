using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain;
using FluentNHibernate.Mapping;

namespace DomainMapping
{
   public class AspNetUserRolesMap:ClassMap<AspNetUserRoles>
   {
       public AspNetUserRolesMap()
       {
           Id(x => x.UserId);
           Id(x => x.RoleId);
       }
    }
}
