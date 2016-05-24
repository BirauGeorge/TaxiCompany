using Interface.Action;
using Ninject;
using RepositoryInterface;
using Repository_Implementation;

namespace Infrastructure
{
   public static class ServiceLocator
    {

        public static void All()
        {
            Kernel.Bind<IStudentNotify>().To<EmailNotification>();
            Kernel.Bind<IEmployeeRepository>().To<EmployeeRepository>();
            Kernel.Bind<IDriverRepository>().To<DriverRepository>();
        }
        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }
        private static readonly IKernel Kernel = new StandardKernel();
    }
}
