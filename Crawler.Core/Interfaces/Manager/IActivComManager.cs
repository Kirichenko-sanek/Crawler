using System.Collections.Generic;
using Crawler.Core.Model;
using HtmlAgilityPack;

namespace Crawler.Core.Interfaces.Manager
{
    public interface IActivComManager
    {
        int ProgresMax { get; set; }
        int ProgresNow { get; set; }


        void GetTriathlon(string folder);
        void GetCycling(string folder);
        void GetRunning(string folder);
        void GetBaseball(string folder);
        void GetBasketball(string folder);
        void GetFootball(string folder);
        void GetGolf(string folder);
        void GetMartialArts(string folder);
        void GetSoccer(string folder);
        void GetSoftball(string folder);
        void GetSwimming(string folder);
        void GetTennis(string folder);
        void GetVolleyball(string folder);
        void GetWinterSports(string folder);

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
