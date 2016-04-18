using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Castle.Windsor;

namespace Taxi.CastleWindsorInfrastructure
{
    public class WindsorContainerBuilder
    {
        public static void BuildContainer()
        {
            var container = new WindsorContainer();
            var applicationInstaller = new ApplicationCastleIntaller();
            container.Install(applicationInstaller);
            var controllerFactory = new CastleControllerFactory(container);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}