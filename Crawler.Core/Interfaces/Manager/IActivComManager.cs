using System.Collections.Generic;
using Crawler.Core.Model;
using HtmlAgilityPack;

namespace Crawler.Core.Interfaces.Manager
{
    public interface IActivComManager
    {
        void GetInfoActivCom(string type, string folder);
        int GetProgressMax();
        int GetProgressNow();
    }
}
