using HibernatingRhinos.Profiler.Appender.NHibernate;
using Infrastructure;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Taxi.Startup))]
namespace Taxi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            NHibernateProfiler.Initialize();
            ConfigureAuth(app);
            ServiceLocator.All();
        }
    }
}
