using System.Collections.Generic;
using Crawler.Core.Model;
using HtmlAgilityPack;

namespace Crawler.Core.Interfaces.Services
{
    public interface IActivService
    {
        int ProgresMax { get; set; }
        int ProgresNow { get; set; }

        List<string> GetListPages(string type, string url);
        List<Info> ParsePages(List<string> elementList, string type, string replace);
        string ConvertInfoToString(List<Info> info);
        string GetOrganizerEmail(string organizer);
        string FormatName(HtmlDocument html);
        string FormatDate(HtmlDocument html);
    }
}
