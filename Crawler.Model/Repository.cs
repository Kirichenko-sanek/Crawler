using System.IO;
using Crawler.Interfaces.Repository;


namespace Crawler.Model
{
    public class Repository : IRepository
    {
        public void WriteToFile(string html)
        {
            File.WriteAllText(@"\Work\Crawler\Crawler.Model\Test.txt", html);
        }

    }
}
