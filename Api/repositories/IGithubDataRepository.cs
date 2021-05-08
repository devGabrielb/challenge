using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Models;
using Api.ResourcesParamters;

namespace Api.repositories
{
    public interface IGithubDataRepository
    {
        Task<IEnumerable<GithubData>> GetDataGithub(string user, GithubDataResourcesParamters paramters);
    }
}