namespace Crawler.Core.Interfaces.Manager
{
    public interface IManager
    {
        void GetInfoActivComManagerRunning(string folder);
        void GetInfoActivComManagerCycling(string folder);
        void GetInfoActivComManagerTriathlon(string folder);

        void GetInfoActivComManagerBaseball(string folder);
        void GetInfoActivComManagerBasketball(string folder);
        void GetInfoActivComManagerFootball(string folder);
        void GetInfoActivComManagerGolf(string folder);
        void GetInfoActivComManagerMartialArts(string folder);
        void GetInfoActivComManagerSoccer(string folder);
        void GetInfoActivComManagerSoftball(string folder);
        void GetInfoActivComManagerSwimming(string folder);
        void GetInfoActivComManagerTennis(string folder);
        void GetInfoActivComManagerVolleyball(string folder);
        void GetInfoActivComManagerWinterSports(string folder);

        int GetProgressMax();
        int GetProgressNow();
    }
}
