using System;
using System.Collections.Generic;
using System.Net;
using Crawler.Core;
using Crawler.Interfaces.Manager;
using Crawler.Interfaces.Repository;
using HtmlAgilityPack;


namespace Crawler.BL
{
    public class Manager : IManager
    {
        private readonly IRepository _repository;

        public Manager(IRepository repository)
        {
            _repository = repository;
        }

        public bool GetResponse(string url)
        {

            var raning = GetInfo(url, "running");
            var cycling = GetInfo(url, "cycling");
            var triathlon = GetInfo(url, "triathlon");
            _repository.WriteToFile(raning, "running");
            _repository.WriteToFile(cycling, "cycling");
            _repository.WriteToFile(triathlon, "triathlon");
            return true;

        }

        public List<Info> GetInfo(string url,string type)
        {
            var wClient = new WebClient();
            var html = new HtmlDocument();
            var elementList = new List<string>();
            Console.WriteLine("Search activities. Please wait");
            for (int i = 1; ; i++)
            {
                html.LoadHtml(wClient.DownloadString(url + type + "?page=" + i));
                var elements = html.DocumentNode.SelectNodes("//a[@data-asset-id]");
                if (elements == null)
                {
                    break;
                }
                foreach (var item in elements)
                {
                    elementList.Add(url + item.GetAttributeValue("href", "") + item.GetAttributeValue("data-asset-id", ""));
                }
            };
            
            var htmlInfo = new HtmlDocument();
            var info = new List<Info>();
            
            foreach (var item in elementList)
            {
                var tagsList = new List<string>();
                var information = new Info();
                htmlInfo.LoadHtml(wClient.DownloadString(item.Replace("http://www.activekids.com/","")));

                information.Name =
                    htmlInfo.DocumentNode.SelectSingleNode("//div[@class='ed-details']/h1")?
                        .InnerText.Replace("&amp;", "and") ?? " ";
                Console.WriteLine("Information about the event collection:" + information.Name);
                

                information.Date =
                    htmlInfo.DocumentNode.SelectSingleNode(
                        "//div[@class='ed-details']/div[@class='visible-desktop']/h5")?
                        .InnerText ?? " ";
                
                try
                {
                    var adressName = htmlInfo.DocumentNode.SelectSingleNode(
                        "//div[@class='ed-details']/div[@class='visible-desktop']/div[@class='event-details-address']/span[@class='ed-address-name']")?
                        .InnerText.Trim() ?? " ";
                    var adress = htmlInfo.DocumentNode.SelectNodes("//div[@class='ed-details']/div[@class='visible-desktop']/div[@class='event-details-address']/span[@class='ed-address-text']/span");
                    information.Place = adressName.Replace("&nbsp;", "").Replace("&amp;", "and") + " ";
                    foreach (var str in adress)
                    {
                        information.Place = information.Place +
                                            str.InnerText.Replace("&nbsp;", "").Replace("&amp;", "and") + " ";
                    }
                }
                catch (Exception e)
                {
                    information.Place = " ";
                }

                try
                {
                    var tags = htmlInfo.DocumentNode.SelectNodes("//ul[@class='inline breadcrumb']/li/p/a");
                    foreach (var tag in tags)
                    {
                        tagsList.Add(tag.InnerText);
                    }
                    
                }
                catch (Exception)
                {
                    tagsList.Add(" ");
                }
                information.Tag = tagsList;

                information.OrganizerName =
                    htmlInfo.DocumentNode.SelectSingleNode("//div[@class='sectioncontent']/ul/li/h5")?.InnerText.Replace("&amp;", "and") ?? " ";

                information.Organizer =
                    htmlInfo.DocumentNode.SelectSingleNode("//div[@class='sectioncontent']/ul/li/p/a")?
                        .GetAttributeValue("href", "") ?? " ";

                information.Url = item;
                information.Category = type;
                info.Add(information);
            }


            return info;
        }
    }
}
