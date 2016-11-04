using Castle.Windsor;
using Crawler.BL.CW;
using Crawler.Controller;
using Crawler.Core.Interfaces.Manager;

namespace Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer().Install(new AdminInstaller());
            var contr = new CrawlerController(container.Resolve<IManager>());
            contr.StartCrowler();

        }
    }
}
