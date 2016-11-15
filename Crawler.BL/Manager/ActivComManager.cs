using Crawler.Core.Interfaces.Manager;
using Crawler.Core.Interfaces.Repository;
using Crawler.Core.Interfaces.Services;

namespace Crawler.BL.Manager
{
    public class ActivComManager : IActivComManager
    {
        private readonly IActivService _activService;
        private readonly IRepository _repository;

        public ActivComManager(IActivService activService, IRepository repository)
        {
            _activService = activService;
            _repository = repository;
        }

        public void GetTriathlon(string folder)
        {
            GetInfoActivCom("Triathlon", folder);
        }

        public void GetCycling(string folder)
        {
            GetInfoActivCom("Cycling", folder);
        }

        public void GetRunning(string folder)
        {
            GetInfoActivCom("Running", folder);
        }

        public void GetBaseball(string folder)
        {
            GetInfoActivCom("Baseball",folder);
        }

        public void GetBasketball(string folder)
        {
            GetInfoActivCom("Basketball", folder);
        }

        public void GetFootball(string folder)
        {
            GetInfoActivCom("Football", folder);
        }

        public void GetGolf(string folder)
        {
            GetInfoActivCom("Golf", folder);
        }

        public void GetMartialArts(string folder)
        {
            GetInfoActivCom("Martial-Arts", folder);
        }

        public void GetSoccer(string folder)
        {
            GetInfoActivCom("Soccer", folder);
        }

        public void GetSoftball(string folder)
        {
            GetInfoActivCom("Softball", folder);
        }

        public void GetSwimming(string folder)
        {
            GetInfoActivCom("Swimming", folder);
        }

        public void GetTennis(string folder)
        {
            GetInfoActivCom("Tennis", folder);
        }

        public void GetVolleyball(string folder)
        {
            GetInfoActivCom("Volleyball", folder);
        }

        public void GetWinterSports(string folder)
        {
            GetInfoActivCom("Winter-Sports", folder);
        }

        public void GetFitness(string folder)
        {
            GetInfoActivCom("Fitness", folder);
        }

        public void GetOutdoors(string folder)
        {
            GetInfoActivCom("Outdoors", folder);
        }

        public int GetProgressMax()
        {
            return _activService.ProgresMax;
        }

        public int GetProgressNow()
        {
            return _activService.ProgresNow;
        }

        public void GetInfoActivCom(string type, string folder)
        {
            _activService.ProgresMax = 0;
            _activService.ProgresNow = 0;
            var pages = _activService.GetListPages(type, "http://www.active.com/");
            _activService.ProgresNow = _activService.ProgresMax;
            _activService.ProgresMax = _activService.ProgresMax +  pages.Count + 15;
            var info = _activService.ParsePages(pages, type, "http://www.activekids.com/");

            var stringInfo = _activService.ConvertInfoToString(info);
            _repository.WriteToFile(stringInfo, type, folder);
            _activService.ProgresNow = _activService.ProgresMax;
        } 
    }
}
