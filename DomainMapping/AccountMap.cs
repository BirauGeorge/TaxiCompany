using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using FluentNHibernate.Mapping;

namespace DomainMapping
{
    class AccountMap:ClassMap<Account>
    {
        public AccountMap()
        {
            Id(x => x.Id);
            Map(x => x.Email);
            Map(x => x.Password);
        }
    }
}
