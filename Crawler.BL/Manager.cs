using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using Crawler.Core;
using Crawler.Interfaces;
using Crawler.Interfaces.Manager;
using Crawler.Interfaces.Repository;
using Crawler.Model;
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

        public string GetResponse(string url)
        {
            var wClient = new WebClient();
            //WebRequest request = WebRequest.Create("http://www.active.com/");
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //Stream dataStream = response.GetResponseStream();
            //StreamReader reader = new StreamReader(dataStream);
            //string responseFromServer = reader.ReadToEnd();
            //_repository.WriteToFile(responseFromServer);
            //reader.Close();
            //dataStream.Close();
            //response.Close();
            var htmlRunning = new HtmlDocument();
            var htmlCycling = new HtmlDocument();
            var htmlTriathlon = new HtmlDocument();
            htmlRunning.LoadHtml(wClient.DownloadString(url + "running"));
            htmlCycling.LoadHtml(wClient.DownloadString(url + "cycling"));
            htmlTriathlon.LoadHtml(wClient.DownloadString(url + "triathlon"));

            var raning = GetInfo(htmlRunning,url);
            var cycling = GetInfo(htmlCycling, url);
            var triathlon = GetInfo(htmlTriathlon, url);
            return "";
        }

        public List<Info> GetInfo(HtmlDocument html, string url)
        {
            var elements = html.DocumentNode.SelectNodes("//a[@data-asset-id]");
            var elementList = new List<string>();
            var tagsList = new List<string>();
            foreach (var item in elements)
            {
                elementList.Add(url + item.GetAttributeValue("href", "") + item.GetAttributeValue("data-asset-id", "")); 
            }
            var wClient = new WebClient();
            var htmlInfo = new HtmlDocument();
            var info = new List<Info>();
            var information = new Info();
            foreach (var item in elementList)
            {
                
                htmlInfo.LoadHtml(wClient.DownloadString(item));
                information.Name = htmlInfo.DocumentNode.SelectSingleNode("//div[@class='ed-details']/h1").InnerText;
                information.Date =
                    htmlInfo.DocumentNode.SelectSingleNode("//div[@class='ed-details']/div[@class='visible-desktop']/h5")
                        .InnerText;
                try
                {
                    information.Place =
                        htmlInfo.DocumentNode.SelectSingleNode(
                            "//div[@class='ed-details']/div[@class='visible-desktop']/div[@class='event-details-address']/span[@class='ed-address-name']")
                            .InnerText.Trim() + htmlInfo.DocumentNode.SelectSingleNode(
                                "//div[@class='ed-details']/div[@class='visible-desktop']/div[@class='event-details-address']/span[@class='ed-address-text']")
                                .InnerText.Trim();
                }
                catch (Exception e)
                {
                    information.Place = "";
                }
                
                
                var tags = htmlInfo.DocumentNode.SelectNodes("//ul[@class='inline breadcrumb']/li/p/a");
                foreach (var tag in tags)
                {
                    tagsList.Add(tag.InnerText);
                }
                information.Tag = tagsList;

                try
                {
                    information.Organizer = htmlInfo.DocumentNode.SelectSingleNode("//div[@class='sectioncontent']/ul/li/p/a").GetAttributeValue("href", "");

                }
                catch (Exception)
                {
                    information.Organizer = "";
                }

                information.Url = item;
                info.Add(information);
            }


            return info;
        }
    }
}
