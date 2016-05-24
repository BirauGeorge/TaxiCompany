using System.Linq;
using System.Web;
using Castle.Windsor;
using RepositoryInterface;
using System.Reflection;
using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using NHibernate;
using Repository_Implementation;
namespace Taxi.CastleWindsorInfrastructure
{
    public class ApplicationCastleIntaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(Component.For(typeof(IRepository<>)).ImplementedBy(typeof(Repository<>)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IEmployeeRepository)).ImplementedBy(typeof(EmployeeRepository)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IDriverRepository)).ImplementedBy(typeof(DriverRepository)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(ITaxiCarRepository)).ImplementedBy(typeof(TaxiCarRepository)).LifestylePerWebRequest());
            container.Register(Component.For(typeof(IAccountRepository)).ImplementedBy(typeof (AccountRepository)).LifestylePerWebRequest());
           // container.Register(Component.For(typeof(ISession)).UsingFactoryMethod(m => SessionGenerator.CreateSessionFactory()));
          
            var controllers = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.BaseType == typeof(Controller)).ToList();

            foreach (var controller in controllers)
            {
                container.Register(Component.For(controller).LifestylePerWebRequest());
            }
        }
    }
}