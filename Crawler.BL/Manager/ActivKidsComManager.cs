﻿using Crawler.Core.Interfaces.Manager;
using Crawler.Core.Interfaces.Repository;
using Crawler.Core.Interfaces.Services;

namespace Crawler.BL.Manager
{
    public class ActivKidsComManager : IActivKidsComManager
    {
        private readonly IActivService _activService;
        private readonly IRepository _repository;

        public ActivKidsComManager(IActivService activService, IRepository repository)
        {
            _activService = activService;
            _repository = repository;
        }

        public int GetProgressMax()
        {
            return _activService.ProgresMax;
        }

        public int GetProgressNow()
        {
            return _activService.ProgresNow;
        }

        public void GetInfoActivKidsCom(string type, string folder)
        {
            _activService.ProgresMax = 0;
            _activService.ProgresNow = 0;
            var pages = _activService.GetListPages(type, "http://www.activekids.com/");
            _activService.ProgresNow = _activService.ProgresMax;
            _activService.ProgresMax = _activService.ProgresMax + pages.Count + 15;
            var info = _activService.ParsePages(pages, type, "http://www.active.com/");

            var stringInfo = _activService.ConvertInfoToString(info);
            _repository.WriteToFile(stringInfo, type, folder);
            _activService.ProgresNow = _activService.ProgresMax;
        }
    }
}
