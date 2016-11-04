using System.Collections.Generic;

namespace Crawler.Core.Model
{
    public class Info
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Place { get; set; }
        public string Category { get; set; }
        public List<string> Tag { get; set; }
        public string OrganizerName { get; set; }
        public string Organizer { get; set; }
        public string Url { get; set; }
    }
}
