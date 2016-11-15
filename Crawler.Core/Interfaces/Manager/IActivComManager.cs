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
        void GetFitness(string folder);
        void GetOutdoors(string folder);

        void GetInfoActivCom(string type, string folder);

        int GetProgressMax();
        int GetProgressNow();
    }
}
