using System.Collections.Generic;
using Crawler.Core;

namespace Crawler.Interfaces.Repository
{
    public interface IRepository
    {
        bool WriteToFile(List<Info> info, string type);
    }
}
