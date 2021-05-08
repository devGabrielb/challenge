using System;

namespace Api.Models
{
    public class GithubDataToReturn
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string imgUrl { get; set; }
        public DateTime created_at { get; set; }
    }
}