using Crawler.Core.Interfaces.Manager;

namespace Crawler.BL.Manager
{
    public class Manager : IManager
    {
        private readonly IActivComManager _activComManager;

        public Manager(IActivComManager activComManager)
        {
            _activComManager = activComManager;
        }

        public void GetInfoActivComManagerRunning(string folder)
        {
            _activComManager.GetRunning(folder);
          
        }

        public void GetInfoActivComManagerCycling(string folder)
        {
            _activComManager.GetCycling(folder);
        }

        public void GetInfoActivComManagerTriathlon(string folder)
        {
            _activComManager.GetTriathlon(folder);
        }

        public void GetInfoActivComManagerBaseball(string folder)
        {
            _activComManager.GetBaseball(folder);
        }

        public void GetInfoActivComManagerBasketball(string folder)
        {
            _activComManager.GetBasketball(folder);
        }

        public void GetInfoActivComManagerFootball(string folder)
        {
            _activComManager.GetFootball(folder);
        }

        public void GetInfoActivComManagerGolf(string folder)
        {
            _activComManager.GetGolf(folder);
        }

        public void GetInfoActivComManagerMartialArts(string folder)
        {
            _activComManager.GetMartialArts(folder);
        }

        public void GetInfoActivComManagerSoccer(string folder)
        {
            _activComManager.GetSoccer(folder);
        }

        public void GetInfoActivComManagerSoftball(string folder)
        {
            _activComManager.GetSoftball(folder);
        }

        public void GetInfoActivComManagerSwimming(string folder)
        {
            _activComManager.GetSwimming(folder);
        }

        public void GetInfoActivComManagerTennis(string folder)
        {
            _activComManager.GetTennis(folder);
        }

        public void GetInfoActivComManagerVolleyball(string folder)
        {
            _activComManager.GetVolleyball(folder);
        }

        public void GetInfoActivComManagerWinterSports(string folder)
        {
            _activComManager.GetWinterSports(folder);
        }

        public void GetInfoActivComManagerFitness(string folder)
        {
            _activComManager.GetFitness(folder);
        }

        public void GetInfoActivComManagerOutdoors(string folder)
        {
            _activComManager.GetOutdoors(folder);
        }

        public int GetProgressMaxActivCom()
        {
            return _activComManager.GetProgressMax();
        }

        public int GetProgressNowActivCom()
        {
            return _activComManager.GetProgressNow(); ;
        }
    }
}
