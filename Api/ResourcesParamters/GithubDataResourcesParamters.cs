namespace Api.ResourcesParamters
{
    public class GithubDataResourcesParamters
    {

        public string sort { get; set; }
        public string direction { get; set; }
        public int limitResults { get; set; } = 10;
        public string language { get; set; }
    }
}