﻿namespace Crawler.Core.Interfaces.Repository
{
    public interface IRepository
    {
        void WriteToFile(string info, string fileName, string folder);
    }
}
