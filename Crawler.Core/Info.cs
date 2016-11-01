using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Core
{
    public class Info
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Place { get; set; }
        public List<string> Tag { get; set; }
        public string Organizer { get; set; }
        public string Url { get; set; }
    }
}
