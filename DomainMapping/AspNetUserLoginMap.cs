using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using FluentNHibernate.Mapping;

namespace DomainMapping
{
   public class AspNetUserLoginMap:ClassMap<AspNetUserLogin>
    {
        public AspNetUserLoginMap()
        {  
            Id(x => x.LoginProvider);
            Id(x => x.ProviderKey);
            Id(x => x.UserId);
        }
    }
}
