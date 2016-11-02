using System;
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
            Console.WriteLine("Performed data collection. Please wait");
            var result = _manager.GetResponse("http://www.active.com/");
            Console.WriteLine(result ? "Data saved" : "Error");
            Console.ReadKey();
        }
    }
}
