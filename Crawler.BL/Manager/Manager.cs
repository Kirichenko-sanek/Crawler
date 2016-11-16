using System.Runtime.Serialization;
using Crawler.Core.Interfaces.Manager;
using Crawler.Core.Interfaces.Services;

namespace Crawler.BL.Manager
{
    public class Manager : IManager
    {
        private readonly IActivComManager _activComManager;
        private readonly IActivKidsComManager _activKidsComManager;

        public Manager(IActivComManager activComManager, IActivKidsComManager activKidsComManager)
        {
            _activComManager = activComManager;
            _activKidsComManager = activKidsComManager;
        }

        public void GetInfoActivComManager(string type, string folder)
        {
            _activComManager.GetInfoActivCom(type, folder);
        }
        public void GetInfoActivKidsComManager(string type,string folder)
        {
            _activKidsComManager.GetInfoActivKidsCom(type, folder);
        }

        public int GetProgressMaxActivCom()
        {
            return _activComManager.GetProgressMax();
        }
        public int GetProgressNowActivCom()
        {
            return _activComManager.GetProgressNow(); ;
        }
        public int GetProgressMaxActivKidsCom()
        {
            return _activKidsComManager.GetProgressMax();
        }
        public int GetProgressNowActivKidsCom()
        {
            return _activKidsComManager.GetProgressNow(); ;
        }
    }
}
