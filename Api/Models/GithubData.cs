using System;
using System.Collections.Generic;

namespace Api.Models
{
    public class GithubData
    {
        public string name { get; set; }
        public string full_name { get; set; }
        public Owner owner { get; set; }
        public string description { get; set; }
        public DateTime created_at { get; set; }
        public string language { get; set; }
    }
}


public class Owner
{
    public string avatar_url { get; set; }
}