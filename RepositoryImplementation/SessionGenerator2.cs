using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainMapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Repository_Implementation
{
    class SessionGenerator2
    {
        private static ISessionFactory _sessionFactory;
        private static readonly object factorylock = new object();

        public static ISession OpenSession()
        {
            lock (factorylock)
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = Fluently.Configure()
                                        .Database(MsSqlConfiguration.MsSql2012
                                                 .ConnectionString(c => c.FromConnectionStringWithKey("connectionString"))
                                                 .ShowSql())
                                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EmployeeMap>())
                                        .BuildSessionFactory();
                }
            }
            return _sessionFactory.OpenSession();
        }
    }
}
