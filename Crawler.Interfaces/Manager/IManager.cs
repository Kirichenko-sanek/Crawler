using System.Collections.Generic;
using Crawler.Core;
using HtmlAgilityPack;

namespace Crawler.Interfaces.Manager
{
    public interface IManager
    {
        string GetResponse(string url);
        List<Info> GetInfo(HtmlDocument html, string url);
    }
}
