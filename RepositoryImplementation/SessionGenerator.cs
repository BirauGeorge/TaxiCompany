using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainMapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;



namespace Repository_Implementation
{
    public class SessionGenerator
    {
        public static SessionGenerator Instance
        {
            get { return _sessionGenerator; }
        }

        public ISession GetSession()
        {
            return SessionFactory.OpenSession();
        }

        private static readonly  SessionGenerator _sessionGenerator =new SessionGenerator();
        private static readonly ISessionFactory SessionFactory = CreateSessionFactory();

        public static ISessionFactory CreateSessionFactory()
        {
            var configuration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(builder => builder.Database("MappingDemo")
                        .Server(@"RODSK41004")
                        .TrustedConnection()))
                .Mappings(cfg => CreateMapping(cfg))
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true));
            var conf = configuration.BuildConfiguration();
            return conf.BuildSessionFactory();
        }

        private static void CreateMapping(MappingConfiguration mappingConfiguration)
        {
            var assembly = typeof (EmployeeMap).Assembly;
            mappingConfiguration.FluentMappings.AddFromAssembly(assembly);
            mappingConfiguration.HbmMappings.AddFromAssembly(assembly);
        }

        private SessionGenerator()
        {
            
        }
    }
}

