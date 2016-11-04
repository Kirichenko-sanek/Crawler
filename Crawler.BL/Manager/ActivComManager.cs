using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Crawler.Core.Interfaces.Manager;
using Crawler.Core.Interfaces.Repository;
using Crawler.Core.Model;
using HtmlAgilityPack;

namespace Crawler.BL.Manager
{
    public class ActivComManager : IActivComManager
    {
        private readonly IRepository _repository;

        public ActivComManager(IRepository repository)
        {
            _repository = repository;
        }

        public void GetTriathlon()
        {
            GetInfoActivCom("triathlon");
        }

        public void GetCycling()
        {
            GetInfoActivCom("cycling");
        }

        public void GetRunning()
        {
            GetInfoActivCom("running");
        }

        public void GetInfoActivCom(string type)
        {
            Console.WriteLine("Search events. Please wait(" + type + ")");
            var pages = GetListPages(type);
            Console.WriteLine("Events found(" + type + ")");
            var info = ParsePages(pages, type);
            Console.WriteLine("Data processing(" + type + ")");
            var stringInfo = ConvertInfoToString(info);
            _repository.WriteToFile(stringInfo, type);
            Console.WriteLine("Data save(" + type + ")");
        }

        public List<string> GetListPages(string type)
        {

            var wClient = new WebClient();
            var html = new HtmlDocument();
            var elementList = new List<string>();           
            for (int i = 1; ; i++)
            {
                html.LoadHtml(wClient.DownloadString("http://www.active.com/" + type + "?radius=infinity" + "&page=" + i));
                var elements = html.DocumentNode.SelectNodes("//a[@data-asset-id]");
                if (elements == null)
                {
                    break;
                }
                foreach (var item in elements)
                {
                    elementList.Add("http://www.active.com/" + item.GetAttributeValue("href", "") +
                                    item.GetAttributeValue("data-asset-id", ""));
                }
            }

            //var elementList = new List<string>();
            //int cout = 1;
            //var wClientStart = new WebClient();
            //var htmlStart = new HtmlDocument();
            //htmlStart.LoadHtml(wClientStart.DownloadString("http://www.active.com/" + type + "?radius=infinity" + "&page=" + 1));
            //try
            //{
            //    var pages = htmlStart.DocumentNode.SelectNodes("//div[@id='paging']/ul/li");
            //    if (pages != null)
            //    {
            //        cout = Convert.ToInt32((pages[pages.Count - 1]).InnerText);
            //    }
            //    elementList.Clear();

            //    Parallel.For(1, cout, i =>
            //    {
            //        var wClient = new WebClient();
            //        var html = new HtmlDocument();
            //        html.LoadHtml(wClient.DownloadString("http://www.active.com/" + type + "?radius=infinity" + "&page=" + i));
            //        var elements = html.DocumentNode.SelectNodes("//a[@data-asset-id]");
            //        if (elements == null)
            //        {
            //            return;
            //        }
            //        foreach (var item in elements)
            //        {
            //            elementList.Add("http://www.active.com/" + item.GetAttributeValue("href", "") +
            //                            item.GetAttributeValue("data-asset-id", ""));
            //        }

            //    });
            //}
            //catch (Exception)
            //{
            //    var wClient = new WebClient();
            //    var html = new HtmlDocument();
            //    elementList.Clear();
            //    for (int i = 1; ; i++)
            //    {
            //        html.LoadHtml(wClient.DownloadString("http://www.active.com/" + type + "?radius=infinity" + "&page=" + i));
            //        var elements = html.DocumentNode.SelectNodes("//a[@data-asset-id]");
            //        if (elements == null)
            //        {
            //            break;
            //        }
            //        foreach (var item in elements)
            //        {
            //            elementList.Add("http://www.active.com/" + item.GetAttributeValue("href", "") +
            //                            item.GetAttributeValue("data-asset-id", ""));
            //        }
            //    }
            //}
            
            return elementList;
        }

        public List<Info> ParsePages(List<string> elementList, string type)
        {      
            var info = new List<Info>();

            Parallel.ForEach(elementList, item =>
            {
                var wClient = new WebClient();
                var htmlInfo = new HtmlDocument();
                var tagsList = new List<string>();
                var information = new Info();
                try
                {
                    htmlInfo.LoadHtml(wClient.DownloadString(item.Replace("http://www.activekids.com/", "")));
                }
                catch (Exception)
                {
                    return;
                }

                information.Name =
                    htmlInfo.DocumentNode.SelectSingleNode("//div[@class='ed-details']/h1")?
                        .InnerText.Replace("&amp;", "and").Replace(";", "and") ?? " ";
                Console.WriteLine("Information about the event collection:" + information.Name);

                information.Date =
                    htmlInfo.DocumentNode.SelectSingleNode(
                        "//div[@class='ed-details']/div[@class='visible-desktop']/h5")?
                        .InnerText.Replace(";", "and") ?? " ";

                try
                {
                    var adressName = htmlInfo.DocumentNode.SelectSingleNode(
                        "//div[@class='ed-details']/div[@class='visible-desktop']/div[@class='event-details-address']/span[@class='ed-address-name']")
                        ?.InnerText.Trim().Replace(";", "and") ?? " ";
                    var adress =
                        htmlInfo.DocumentNode.SelectNodes(
                            "//div[@class='ed-details']/div[@class='visible-desktop']/div[@class='event-details-address']/span[@class='ed-address-text']/span");
                    information.Place = adressName.Replace("&nbsp;", "").Replace("&amp;", "and") + " ";
                    foreach (var str in adress)
                    {
                        information.Place = information.Place +
                                            str.InnerText.Replace("&nbsp;", "")
                                                .Replace("&amp;", "and")
                                                .Replace(";", "and") + " ";
                    }
                }
                catch (Exception)
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
                    htmlInfo.DocumentNode.SelectSingleNode("//div[@class='sectioncontent']/ul/li/h5")?
                        .InnerText.Replace("&amp;", "and")
                        .Replace(";", "and") ?? " ";

                information.Organizer =
                    htmlInfo.DocumentNode.SelectSingleNode("//div[@class='sectioncontent']/ul/li/p/a")?
                        .GetAttributeValue("href", "").Replace(";", "and") ?? " ";

                information.Url = item;
                information.Category = type;
                info.Add(information);
            });

            return info;
        }

        public string ConvertInfoToString(List<Info> info)
        {
            System.Text.StringBuilder theBuilder = new System.Text.StringBuilder();
            theBuilder.Append("Event Name");
            theBuilder.Append(";");
            theBuilder.Append("Event Date");
            theBuilder.Append(";");
            theBuilder.Append("Event Location");
            theBuilder.Append(";");
            theBuilder.Append("Event Category");
            theBuilder.Append(";");
            theBuilder.Append("Event Type");
            theBuilder.Append(";");
            theBuilder.Append("Organizing Company");
            theBuilder.Append(";");
            theBuilder.Append("Company Website");
            theBuilder.Append(";");
            theBuilder.Append("Event Url");            
            theBuilder.Append("\n");
            foreach (var item in info)
            {
                string str = "";

                theBuilder.Append(item.Name);
                theBuilder.Append(";");
                theBuilder.Append(item.Date);
                theBuilder.Append(";");
                theBuilder.Append(item.Place);
                theBuilder.Append(";");
                theBuilder.Append(item.Category);
                theBuilder.Append(";");
                foreach (var tag in item.Tag)
                {
                    str = str + " " + tag;
                }
                theBuilder.Append(str);
                theBuilder.Append(";");
                theBuilder.Append(item.OrganizerName);
                theBuilder.Append(";");
                theBuilder.Append(item.Organizer);
                theBuilder.Append(";");
                theBuilder.Append(item.Url);
                theBuilder.Append("\n");

            }
            return theBuilder.ToString();
        }

    }
}
