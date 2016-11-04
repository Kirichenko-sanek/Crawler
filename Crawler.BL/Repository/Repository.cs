using System.IO;
using Crawler.Core.Interfaces.Repository;

namespace Crawler.BL.Repository
{
    public class Repository : IRepository
    {
        public void WriteToFile(string info, string fileName)
        {
            using (StreamWriter theWriter = new StreamWriter(@"\Work\Crawler\Crawler.Core\Result\" + fileName + ".csv"))
            {
                theWriter.Write(info);
            }
        }
    }
}
