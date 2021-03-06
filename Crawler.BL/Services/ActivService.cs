﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Crawler.Core.Interfaces.Services;
using Crawler.Core.Model;
using HtmlAgilityPack;

namespace Crawler.BL.Services
{
    public class ActivService : IActivService
    {
        public int ProgresMax { get; set; }
        public int ProgresNow { get; set; }

        public ActivService()
        {
            ProgresMax = 0;
            ProgresNow = 0;
        }

        public List<string> GetListPages(string type, string url)
        {
            ProgresMax = 0;
            ProgresNow = 0;
            var elementList = new List<string>();
            int cout = 1;
            var wClientStart = new WebClient();
            var htmlStart = new HtmlDocument();
            htmlStart.LoadHtml(wClientStart.DownloadString(url + type + "?radius=infinity" + "&page=" + 1));

            var pages = htmlStart.DocumentNode.SelectNodes("//div[@id='paging']/ul/li");
            if (pages != null)
            {
                cout = Convert.ToInt32((pages[pages.Count - 1]).InnerText);
                ProgresMax = cout + cout * 11;
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
                            wClient.DownloadString(url + type + "?radius=infinity" + "&page=" + i));
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
                        elementList.Add(url + item.GetAttributeValue("href", ""));
                    }
                    ProgresNow++;
                }
            });

            return elementList;
        }

        public List<Info> ParsePages(List<string> elementList, string type, string replace)
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
                        htmlInfo.LoadHtml(wClient.DownloadString(item.Replace(replace, "")));
                    }
                    catch (Exception)
                    {
                        return;
                    }

                    information.Name = FormatName(htmlInfo);

                    //Console.WriteLine("Information about the event collection:" + information.Name);
                    information.Date = FormatDate(htmlInfo).Replace(",", "/");
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

                    information.Url = item.Replace(replace, "");
                    information.Category = type;
                    info.Add(information);
                    ProgresNow++;
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
                List<string> emailsList = new List<string>();
                using (var wClientOrganizer = new WebClient())
                {
                    wClientOrganizer.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.71 Safari/537.36");
                    wClientOrganizer.Headers.Add("Content-Type", "text/html, charset=utf-8");
                    wClientOrganizer.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");

                    var htmlOrganizer = new HtmlDocument();
                    var regex = new Regex(@"\b[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}\b");

                    MatchCollection match;
                    try
                    {
                        htmlOrganizer.LoadHtml(wClientOrganizer.DownloadString(organizer + "/site/"));
                    }
                    catch (Exception e)
                    {
                        htmlOrganizer.LoadHtml(wClientOrganizer.DownloadString(organizer + "/"));
                    }
                    match = regex.Matches(htmlOrganizer.DocumentNode.InnerText);
                    if (match.Count != 0)
                    {
                        foreach (Match item in match)
                        {
                            if (emailsList.Count != 0)
                            {
                                if (emailsList.Contains(item.Value))
                                {
                                    break;
                                }
                            }
                            emailsList.Add(item.Value);
                        }

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
                                wClientContact.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.71 Safari/537.36");
                                wClientContact.Headers.Add("Content-Type", "text/html, charset=utf-8");
                                wClientContact.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");

                                var htmlContact = new HtmlDocument();
                                foreach (var cout in str)
                                {
                                    try
                                    {
                                        htmlContact.LoadHtml(wClientContact.DownloadString(cout));
                                    }
                                    catch (Exception)
                                    {
                                        try
                                        {
                                            htmlContact.LoadHtml(wClientContact.DownloadString(organizer + cout));
                                        }
                                        catch (Exception)
                                        {
                                            htmlContact.LoadHtml(wClientContact.DownloadString(organizer + "/" + cout));
                                        }

                                    }
                                    match = regex.Matches(htmlContact.DocumentNode.InnerText);
                                    if (match.Count != 0)
                                    {
                                        foreach (Match item in match)
                                        {
                                            if (emailsList.Count != 0)
                                            {
                                                if (emailsList.Contains(item.Value))
                                                {
                                                    break;
                                                }
                                            }
                                            emailsList.Add(item.Value);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (emailsList.Count != 0)
                    {
                        return string.Join("; ", emailsList.ToArray());
                    }
                    return " ";
                }
            }
            catch (Exception e)
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
                var start = date.Substring(0, date.IndexOf('-') - 1);
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
