using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using FluentNHibernate.Mapping;

namespace DomainMapping
{
    public class AspNetUserClaimsMap :ClassMap<AspNetUserClaims>
    {
        public AspNetUserClaimsMap()
        {
            Id(x => x.Id);
            Map(x =>x.UserId );
            Map(x => x.ClaimType );
            Map(x => x.ClaimValue );
          
        }
    }
}
