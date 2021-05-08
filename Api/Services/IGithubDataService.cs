using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Models;
using Api.ResourcesParamters;
using Refit;

namespace Api.Services
{
    [Headers("User-Agent: chatbotBlip")]
    public interface IGithubDataService
    {

        [Get("/users/{user}/repos?per_page=100")]
        Task<List<GithubData>> getRepositories([AliasAs("user")] string user, [Query] RefitResourcesParamters paramters);

    }
}