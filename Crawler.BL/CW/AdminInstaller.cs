using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Crawler.BL.Manager;
using Crawler.Core.Interfaces.Manager;
using Crawler.Core.Interfaces.Repository;

namespace Crawler.BL.CW
{
    public class AdminInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IRepository>().ImplementedBy<Repository.Repository>().LifestyleTransient());
            container.Register(Component.For<IManager>().ImplementedBy<Manager.Manager>().LifestyleTransient());
            container.Register(Component.For<IActivComManager>().ImplementedBy<ActivComManager>().LifestyleTransient());
        }
    }
}
