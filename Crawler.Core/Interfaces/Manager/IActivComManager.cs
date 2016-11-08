using System.Collections.Generic;
using Crawler.Core.Model;
using HtmlAgilityPack;

namespace Crawler.Core.Interfaces.Manager
{
    public interface IActivComManager
    {
        void GetTriathlon(string folder);
        void GetCycling(string folder);
        void GetRunning(string folder);
        void GetInfoActivCom(string type, string folder);
        List<string> GetListPages(string type);
        List<Info> ParsePages(List<string> elementList, string type);
        string ConvertInfoToString(List<Info> info);
        string GetOrganizerEmail(string organizer);
        string FormatName(HtmlDocument html);
        string FormatDate(HtmlDocument html);
        string FormatPlace(HtmlDocument html);
    }
}
