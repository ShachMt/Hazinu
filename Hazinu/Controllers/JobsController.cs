using BLHazinu;
using DTOHazinu.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hazinu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private IJobsBL _IJobsBL;
        public JobsController(IJobsBL e)
        {
            _IJobsBL = e;
        }

        [HttpGet]
        [Route("GetAllJobs")]
        public List<JobsDTO> GetAllApplies()
        {
            return _IJobsBL.GetAllJobs();
        }


        [HttpPost]
        [Route("AddJob")]
        public IActionResult AddJob([FromBody] JobsDTO s)
        {
            try
            {
                return Ok(_IJobsBL.AddJobs(s));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleatJob/{id}")]
        public IActionResult DeleatJobs(string id)
        {
            try
            {
                return Ok(_IJobsBL.DeleatJobs(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
       
        [HttpPut]
        [Route("UpdateJobs/{id}")]
        public IActionResult UpdateJobs(string id, JobsDTO u)
        {
            try
            {
                return Ok(_IJobsBL.UpdateJobs(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        
    }
}
