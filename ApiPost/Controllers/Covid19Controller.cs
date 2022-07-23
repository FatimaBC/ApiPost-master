using ApiPost.Models;
using ApiPost.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Covid19Controller : ControllerBase
    {
        RepositoryCovid19 repo;
        public Covid19Controller(RepositoryCovid19 repo)
        {
            this.repo = repo;
        }

        [HttpGet("{searchText}/{limit}/{page}")]
        public ActionResult<List<Covid19>> GetTrialsRequest(String searchText, int limit, int page, String studyType, String condition, String gender, int targetSize, String recruitmentStatus, int inclusionAgemax, int inclusionAgemin)
        {
            try
            {
            if(this.repo.GetTrialsRequest(searchText, limit, page, studyType, condition, gender, targetSize, recruitmentStatus, inclusionAgemax, inclusionAgemin) ==null)
                {
                    Console.WriteLine("error");
                }
                
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            return this.repo.GetTrialsRequest(searchText, limit, page, studyType, condition, gender, targetSize, recruitmentStatus, inclusionAgemax, inclusionAgemin);
        }

        [HttpGet]
        public ActionResult<List<Trials>> GetTrials()
        {
            return this.repo.GetTrials();
        }

    }
}
