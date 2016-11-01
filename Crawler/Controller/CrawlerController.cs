using System;
using Castle.Windsor;
using Crawler.BL.CW;
using Crawler.Interfaces;
using Crawler.Interfaces.Manager;

namespace Crawler.Controller
{
    public class CrawlerController
    {
        private readonly IManager _manager;

        public CrawlerController(IManager manager)
        {
            _manager = manager;
        }

        public void StartCrowler()
        {
            Console.WriteLine(_manager.GetResponse("http://www.active.com/"));
            Console.ReadKey();
        }
    }
}
