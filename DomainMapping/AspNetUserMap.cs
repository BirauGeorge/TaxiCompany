using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using FluentNHibernate.Mapping;

namespace DomainMapping
{
  public class AspNetUserMap:ClassMap<AspNetUsers>
    {
        public AspNetUserMap()
        {
            Id(x => x.Id);
            Map(x => x.Email);
            Map(x => x.EmailConfirmed); 
            Map(x => x.PasswordHash);
            Map(x => x.SecurityStamp);
            Map(x => x.PhoneNumber);
            Map(x => x.PhoneNumberConfirmed);
            Map(x => x.TwoFactorEnabled);
            Map(x => x.LockoutEndDateUtc);
            Map(x => x.LockoutEnable);
            Map(x => x.AccessFailedCount);
            Map(x => x.UserName);

        }
    }
}
