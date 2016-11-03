using System.Collections.Generic;
using System.IO;
using Crawler.Core;
using Crawler.Interfaces.Repository;


namespace Crawler.Model
{
    public class Repository : IRepository
    {
        public bool WriteToFile(List<Info> info, string type)
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

            using (StreamWriter theWriter = new StreamWriter(@"\Work\Crawler\Crawler.Model\" + type + ".csv"))
            {
                theWriter.Write(theBuilder.ToString());
            }

            return true;
        }

    }
}
