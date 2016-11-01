
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Crawler.Interfaces.Manager;
using Crawler.Interfaces.Repository;
using Crawler.Model;

namespace Crawler.BL.CW
{
    public class AdminInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IRepository>().ImplementedBy<Repository>().LifestyleTransient());

            container.Register(Component.For<IManager>().ImplementedBy<Manager>().LifestyleTransient());
        }
    }
}
