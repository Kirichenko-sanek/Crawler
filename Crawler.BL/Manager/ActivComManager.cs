using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
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

        public void GetTriathlon(string folder)
        {
            GetInfoActivCom("triathlon", folder);
        }

        public void GetCycling(string folder)
        {
            GetInfoActivCom("cycling", folder);
        }

        public void GetRunning(string folder)
        {
            GetInfoActivCom("running", folder);
        }

        public void GetInfoActivCom(string type, string folder)
        {
            //Console.WriteLine("Search events. Please wait(" + type + ")");
            var pages = GetListPages(type);
            //Console.WriteLine("Events found(" + type + ")");
            var info = ParsePages(pages, type);
            //Console.WriteLine("Data processing(" + type + ")");
            var stringInfo = ConvertInfoToString(info);
            _repository.WriteToFile(stringInfo, type, folder);
            //Console.WriteLine("Data save(" + type + ")");
        }

        public List<string> GetListPages(string type)
        {

            var elementList = new List<string>();
            int cout = 1;
            var wClientStart = new WebClient();
            var htmlStart = new HtmlDocument();
            htmlStart.LoadHtml(wClientStart.DownloadString("http://www.active.com/" + type + "?radius=infinity" + "&page=" + 1));

            var pages = htmlStart.DocumentNode.SelectNodes("//div[@id='paging']/ul/li");
            if (pages != null)
            {
                cout = Convert.ToInt32((pages[pages.Count - 1]).InnerText);
            }
            elementList.Clear();

            Parallel.For(1, cout, i =>
            {
                using (var wClient = new WebClient())
                {
                    var html = new HtmlDocument();
                    try
                    {
                        html.LoadHtml(
                            wClient.DownloadString("http://www.active.com/" + type + "?radius=infinity" + "&page=" + i));
                    }
                    catch (Exception)
                    {
                        return;
                    }

                    var elements = html.DocumentNode.SelectNodes("//a[@data-asset-id]");
                    if (elements == null)
                    {
                        return;
                    }
                    foreach (var item in elements)
                    {
                        elementList.Add("http://www.active.com/" + item.GetAttributeValue("href", ""));
                    }
                }
            });

            return elementList;
        }

        public List<Info> ParsePages(List<string> elementList, string type)
        {
            var info = new List<Info>();

            Parallel.ForEach(elementList, item =>
            {
                using (var wClient = new WebClient())
                {
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

                    information.Name = FormatName(htmlInfo);
                    
                    //Console.WriteLine("Information about the event collection:" + information.Name);
                    information.Date = FormatDate(htmlInfo).Replace(",", ".");
                    information.Place = FormatPlace(htmlInfo);

                    try
                    {
                        var tags = htmlInfo.DocumentNode.SelectNodes("//ul[@class='inline breadcrumb']/li/p/a");
                        foreach (var tag in tags)
                        {
                            tagsList.Add(tag.InnerText.Replace(",", "_"));
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
                            .Replace(",", " ")
                            .Replace("&#x27;", "") ?? " ";
             

                    information.Organizer =
                        htmlInfo.DocumentNode.SelectSingleNode("//div[@class='sectioncontent']/ul/li/p/a")?
                            .GetAttributeValue("href", "").Replace(",", " ") ?? " ";
                    if (information.Organizer != " ")
                    {
                        if (information.Organizer.Contains("www.facebook.com") == false)
                        {
                            var index = information.Organizer.IndexOf('/', 9);
                            if (index != -1)
                            {
                                information.Organizer = information.Organizer.Remove(index);
                            }
                        }     
                        information.Email = GetOrganizerEmail(information.Organizer);
                    }
                    else
                    {
                        information.Email = " ";
                    }

                    information.Url = item;
                    information.Category = type;
                    info.Add(information);
                }
            });

            return info;
        }

        public string ConvertInfoToString(List<Info> info)
        {
            System.Text.StringBuilder theBuilder = new System.Text.StringBuilder();
            theBuilder.Append("Event Name");
            theBuilder.Append(",");
            theBuilder.Append("Event Date");
            theBuilder.Append(",");
            theBuilder.Append("Event Location");
            theBuilder.Append(",");
            theBuilder.Append("Event Category");
            theBuilder.Append(",");
            theBuilder.Append("Event Type");
            theBuilder.Append(",");
            theBuilder.Append("Organizing Company");
            theBuilder.Append(",");
            theBuilder.Append("Email");
            theBuilder.Append(",");
            theBuilder.Append("Company Website");
            theBuilder.Append(",");
            theBuilder.Append("Event Url");            
            theBuilder.Append("\n");
            foreach (var item in info)
            {
                string str = "";

                theBuilder.Append(item.Name);
                theBuilder.Append(",");
                theBuilder.Append(item.Date);
                theBuilder.Append(",");
                theBuilder.Append(item.Place);
                theBuilder.Append(",");
                theBuilder.Append(item.Category);
                theBuilder.Append(",");
                foreach (var tag in item.Tag)
                {
                    str = str + " " + tag;
                }
                theBuilder.Append(str);
                theBuilder.Append(",");
                theBuilder.Append(item.OrganizerName);
                theBuilder.Append(",");
                theBuilder.Append(item.Email);
                theBuilder.Append(",");
                theBuilder.Append(item.Organizer);
                theBuilder.Append(",");
                theBuilder.Append(item.Url);
                theBuilder.Append("\n");

            }
            return theBuilder.ToString();
        }

        public string GetOrganizerEmail(string organizer)
        {

            try
            {
                using (var wClientOrganizer = new WebClient())
                {
                    var htmlOrganizer = new HtmlDocument();
                    try
                    {
                        htmlOrganizer.LoadHtml(wClientOrganizer.DownloadString(organizer));
                    }
                    catch (Exception)
                    {
                        try
                        {
                            htmlOrganizer.LoadHtml(
                                wClientOrganizer.DownloadString(organizer.Replace("https://", "").Replace("http://", "")));
                        }
                        catch (Exception)
                        {
                            try
                            {
                                htmlOrganizer.LoadHtml(wClientOrganizer.DownloadString(organizer + "/site/"));
                            }
                            catch (Exception)
                            {
                                htmlOrganizer.LoadHtml(
                                    wClientOrganizer.DownloadString(
                                        organizer.Replace("https://", "").Replace("http://", "") + "/site/"));
                            }
                        }
                    }
                    
                    var regex = new Regex(@"\b[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}\b");
                    Match match = regex.Match(htmlOrganizer.DocumentNode.InnerText);
                    if (match.Success)
                    {
                        return match.Value;
                    }
                    var elements = htmlOrganizer.DocumentNode.SelectNodes("//a[@href]");

                    if (elements != null)
                    {
                        List<string> str = new List<string>();
                        foreach (var item in elements)
                        {
                            if (item.GetAttributeValue("href", "").Contains("contact"))
                            {
                                str.Add(item.GetAttributeValue("href", ""));
                                
                            }
                            if (item.GetAttributeValue("href", "").Contains("about"))
                            {
                                str.Add(item.GetAttributeValue("href", ""));
                            }
                        }
                        if (str.Count != 0)
                        {
                            using (var wClientContact = new WebClient())
                            {
                                var htmlContact = new HtmlDocument();
                                foreach (var item in str)
                                {
                                    try
                                    {
                                        htmlContact.LoadHtml(wClientContact.DownloadString(item));
                                    }
                                    catch (Exception)
                                    {
                                        try
                                        {
                                            htmlContact.LoadHtml(wClientContact.DownloadString(organizer + item));
                                        }
                                        catch (Exception)
                                        {
                                            htmlContact.LoadHtml(wClientContact.DownloadString(organizer + "/" + item));
                                        }

                                    }
                                    match = regex.Match(htmlContact.DocumentNode.InnerText);
                                    if (match.Success)
                                    {
                                        break;
                                    }
                                }
                                return match.Value;
                            }
                        }
                        return " ";
                    }
                    return " ";
                }
   
            }
            catch (Exception)
            {
                return " ";
            } 
        }

        public string FormatName(HtmlDocument html)
        {
            return html.DocumentNode.SelectSingleNode("//div[@class='ed-details']/h1")?
                .InnerText.Replace("&amp;", "and").Replace(",", ".") ?? " ";
        }

        public string FormatDate(HtmlDocument html)
        {
            var date =
                html.DocumentNode.SelectSingleNode(
                    "//div[@class='ed-details']/div[@class='visible-desktop']/h5")?
                    .InnerText ?? " ";
            if (date == " ") return date;
            if (date.Contains("-"))
            {
                var start = date.Substring(0, date.IndexOf('-') -1);
                var end = date.Substring(date.IndexOf('-') + 1);
                var index = start.IndexOf('@');
                start = Convert.ToString(
                    index != -1
                        ? Convert.ToDateTime(start.Remove(index)).Date
                        : Convert.ToDateTime(start).Date,
                    CultureInfo.InvariantCulture).Replace("00:00:00", "").Replace("0:00:00", "");
                index = end.IndexOf('@');
                end = Convert.ToString(
                    index != -1
                        ? Convert.ToDateTime(end.Remove(index)).Date
                        : Convert.ToDateTime(end).Date,
                    CultureInfo.InvariantCulture).Replace("00:00:00", "").Replace("0:00:00", "");

                return start + " - " + end;
            }
            else
            {
                var index = date.IndexOf('@');
                if (index != -1)
                {
                    return
                        Convert.ToString(
                            Convert.ToDateTime(date.Remove(index)).Date, CultureInfo.InvariantCulture)
                            .Replace("00:00:00", "")
                            .Replace("0:00:00", "");
                }
                return Convert.ToString(
                    Convert.ToDateTime(date).Date, CultureInfo.InvariantCulture)
                    .Replace("00:00:00", "")
                    .Replace("0:00:00", "");
            }
        }

        public string FormatPlace(HtmlDocument html)
        {
            try
            {

                var addressName = html.DocumentNode.SelectSingleNode(
                    "//div[@class='ed-details']/div[@class='visible-desktop']/div[@class='event-details-address']/span[@class='ed-address-name']")
                    ?.InnerText.Trim().Replace(",", " ") ?? "";

                if (addressName.Contains("-"))
                {
                    addressName = addressName.Substring(addressName.IndexOf('-') + 1);
                }
                var address =
                    html.DocumentNode.SelectNodes(
                        "//div[@class='ed-details']/div[@class='visible-desktop']/div[@class='event-details-address']/span[@class='ed-address-text']/span");


                var add = "";
                foreach (var str in address)
                {
                    add = add + str.InnerText.Replace("&nbsp;", "")
                                            .Replace("&amp;", "and")
                                            .Replace(",", " ") + " ";
                }
                if (addressName == "")
                {
                    return add;
                }
                return addressName + "; " + add;

            }
            catch (Exception)
            {
                return " ";
            }
        }
    }
}
