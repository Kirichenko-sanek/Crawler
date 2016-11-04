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

        public void GetInfoActivComManager()
        {
            Parallel.Invoke(_activComManager.GetRunning, _activComManager.GetCycling, _activComManager.GetTriathlon);
        }

    }
}
