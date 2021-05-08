using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Models;
using Api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using AutoMapper;
using System.Linq;
using System.Text.Json;
using Refit;
using System.Net;
using Api.ResourcesParamters;
using Api.repositories;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/{user}/repos")]
    public class GithubDataController : ControllerBase
    {
        private readonly IGithubDataRepository _repository;

        private readonly IMapper _mapper;


        public GithubDataController(IMapper mapper, IGithubDataRepository repository)
        {
            _repository = repository ??
            throw new ArgumentNullException(nameof(repository)); ;
            _mapper = mapper ??
            throw new ArgumentNullException(nameof(mapper));
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<GithubDataToReturn>>> GetRepositories(
            [FromRoute] string user,
            [FromQuery] GithubDataResourcesParamters paramters


            )
        {
            try
            {

                if (String.IsNullOrWhiteSpace(user))
                {
                    return BadRequest();
                }

                var repostoGithub = await _repository.GetDataGithub(user, paramters);

                if (repostoGithub == null)
                {
                    return NotFound();
                }



                return Ok(_mapper.Map<IEnumerable<GithubDataToReturn>>(repostoGithub));
            }
            catch (ApiException apiException)
            {
                if (apiException.StatusCode == HttpStatusCode.Forbidden)
                {

                    return Forbid(apiException.Content);
                }

                return BadRequest(apiException.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}