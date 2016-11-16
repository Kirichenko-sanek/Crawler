namespace Crawler.Core.Interfaces.Manager
{
    public interface IActivKidsComManager
    {
        int GetProgressMax();
        int GetProgressNow();
        void GetInfoActivKidsCom(string type, string folder);
    }
}
