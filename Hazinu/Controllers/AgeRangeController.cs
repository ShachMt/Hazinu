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
    public class AgeRangeController : ControllerBase
    {
        private IAgeRangeBL _IAgeRangeBL;
        public AgeRangeController(IAgeRangeBL e)
        {
            _IAgeRangeBL = e;
        }

        [HttpGet]
        [Route("GetAllAgeRange")]
        public List<AgeRangeDTO> GetAllAgeRange()
        {
            return _IAgeRangeBL.GetAllAgeRange();
        }


        [HttpPost]
        [Route("AddAgeRange")]
        public bool AddAgeRange([FromBody] AgeRangeDTO u)
        {
            return _IAgeRangeBL.AddJobsAgeRange(u);
        }

        [HttpDelete]
        [Route("DeleatAgeRange")]
        public bool DeleatAgeRange([FromBody] string id)
        {
            return _IAgeRangeBL.DeleatAgeRange(int.Parse(id));
        }
        [HttpPut]
        [Route("UpdateAgeRange")]
        public bool UpdateAgeRange(string id, AgeRangeDTO u)
        {
            return _IAgeRangeBL.UpdateAgeRange(int.Parse(id), u);
        }
    }
}
