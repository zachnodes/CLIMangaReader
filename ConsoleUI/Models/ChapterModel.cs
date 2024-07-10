using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Models
{
    
    public class ChapterImg
    {
        public string hash { get; set; }
        public List<string> data { get; set; }
        public List<string> dataSaver { get; set; }
    }
    public class CAttributes
    {
        public string volume { get; set; }
        public string chapter { get; set; }
        public string title { get; set; }
        public string translatedLanguage { get; set; }
        public object externalUrl { get; set; }
        public DateTime publishAt { get; set; }
        public DateTime readableAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int pages { get; set; }
        public int version { get; set; }
    }

    public class CData
    {
        public string id { get; set; }
        public string type { get; set; }
        public CAttributes attributes { get; set; }
        public List<Relationship> relationships { get; set; }
    }

    public class CRelationship
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class CRoot
    {
        public string result { get; set; }
        public string response { get; set; }
        public List<CData> data { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int total { get; set; }
        public string baseUrl { get; set; }
        public ChapterImg chapter { get; set; }

    }


}
