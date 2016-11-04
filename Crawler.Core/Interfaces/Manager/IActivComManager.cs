using System.Collections.Generic;
using Crawler.Core.Model;

namespace Crawler.Core.Interfaces.Manager
{
    public interface IActivComManager
    {
        void GetTriathlon();
        void GetCycling();
        void GetRunning();
        void GetInfoActivCom(string type);
        List<string> GetListPages(string type);
        List<Info> ParsePages(List<string> elementList, string type);
        string ConvertInfoToString(List<Info> info);
    }
}
