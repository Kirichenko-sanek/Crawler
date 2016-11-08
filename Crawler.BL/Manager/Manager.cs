using System.Threading.Tasks;
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
    }
}
