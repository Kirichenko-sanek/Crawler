namespace Crawler.Core.Interfaces.Manager
{
    public interface IManager
    {
        void GetInfoActivComManager(string type, string folder);
        void GetInfoActivKidsComManager(string type, string folder);
        int GetProgressMaxActivCom();
        int GetProgressNowActivCom();
        int GetProgressMaxActivKidsCom();
        int GetProgressNowActivKidsCom();
    }
}
