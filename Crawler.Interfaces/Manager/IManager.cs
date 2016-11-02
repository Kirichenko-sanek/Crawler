using System.Collections.Generic;
using Crawler.Core;

namespace Crawler.Interfaces.Manager
{
    public interface IManager
    {
        bool GetResponse(string url);
        List<Info> GetInfo(string url, string type);
    }
}
