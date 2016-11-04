using System;
using Crawler.Core.Interfaces.Manager;

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
            _manager.GetInfoActivComManager();
            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
