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
        public bool AddJob([FromBody] JobsDTO u)
        {
            return _IJobsBL.AddJobs(u);
        }

        [HttpDelete]
        [Route("DeleatJob")]
        public bool DeleatJobs([FromBody] string id)
        {
            return _IJobsBL.DeleatJobs(int.Parse(id));
        }
        [HttpPut]
        [Route("UpdateJobs")]
        public bool UpdateUser(string id, JobsDTO u)
        {
            return _IJobsBL.UpdateJobs(int.Parse(id), u);
        }
    }
}
