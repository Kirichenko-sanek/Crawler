using System.IO;
using Crawler.Core.Interfaces.Repository;

namespace Crawler.BL.Repository
{
    public class Repository : IRepository
    {
        public void WriteToFile(string info, string fileName,string folder)
        {
            var str = folder +"/" + fileName.Replace("/","_") + ".csv";
            using (StreamWriter theWriter = new StreamWriter(@"" + str))
            {
                theWriter.Write(info);
                theWriter.Close();
            }
        }
    }
}
