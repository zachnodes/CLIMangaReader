using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleUI.Models
{
    
    public class AltTitle
    {
        public string ja { get; set; }

        
        public string jaro { get; set; }
        public string en { get; set; }
        public string zh { get; set; }
    }

    public class Attributes
    {
        public Title? title { get; set; }
        public List<AltTitle>? altTitles { get; set; }
        public Description? description { get; set; }
        public bool? isLocked { get; set; }
        public Links? links { get; set; }
        public string? originalLanguage { get; set; }
        public string? lastVolume { get; set; }
        public string? lastChapter { get; set; }
        public string? publicationDemographic { get; set; }
        public string? status { get; set; }
        public int? year { get; set; }
        public string? contentRating { get; set; }
        public List<Tag>? tags { get; set; }
        public string? state { get; set; }
        public bool? chapterNumbersResetOnNewVolume { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public int? version { get; set; }
        public List<string>? availableTranslatedLanguages { get; set; }
        public string? latestUploadedChapter { get; set; }
        public Name? name { get; set; }
        public string? group { get; set; }

    }

    public class Data
    {
        public string id { get; set; }
        public string type { get; set; }
        public Attributes attributes { get; set; }
        public List<Relationship> relationships { get; set; }
    }

    public class Description
    {
        public string en { get; set; }
    }

    public class Links
    {
        public string raw { get; set; }
        public string al { get; set; }
        public string kt { get; set; }
        public string mu { get; set; }
        public string amz { get; set; }
        public string ap { get; set; }
        public string bw { get; set; }
        public string mal { get; set; }
        public string cdj { get; set; }
    }

    public class Name
    {
        public string en { get; set; }
    }

    public class Relationship
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class Root
    {
        public string result { get; set; }
        public string response { get; set; }
        public List<Data> data { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int total { get; set; }
    }

    public class Tag
    {
        public string id { get; set; }
        public string type { get; set; }
        public Attributes attributes { get; set; }
        public List<object> relationships { get; set; }
    }

    public class Title
    {
        public string en { get; set; }
        
    }
    
}

