using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using Api.Models;
using Api.ResourcesParamters;
using Api.Services;

namespace Api.repositories
{
    public class GithubDataRepository : IGithubDataRepository
    {
        private readonly IGithubDataService _service;
        public GithubDataRepository(IGithubDataService service)
        {
            _service = service ??
             throw new ArgumentNullException(nameof(service));
        }
        public async Task<IEnumerable<GithubData>> GetDataGithub(string user, GithubDataResourcesParamters paramters)
        {




            var queryParams = new RefitResourcesParamters();



            if (String.IsNullOrWhiteSpace(paramters.direction)
            && String.IsNullOrWhiteSpace(paramters.sort)
            && paramters.limitResults <= 0
            && String.IsNullOrWhiteSpace(paramters.language))
            {

                return await _service.getRepositories(user, queryParams);
            }

            if (!String.IsNullOrWhiteSpace(paramters.sort))
            {
                queryParams.sort = paramters.sort;
            }


            if (!String.IsNullOrWhiteSpace(paramters.direction))
            {
                queryParams.direction = paramters.direction;
            }

            if (!String.IsNullOrWhiteSpace(paramters.language))
            {
                paramters.language = System.Uri.UnescapeDataString(paramters.language);
            }

            var repositories = await _service.getRepositories(user, queryParams);

            return repositories.Where(r => r.language != null && r.language.ToLower() == paramters.language.ToLower()).Take(paramters.limitResults).ToList();

        }

    }
}