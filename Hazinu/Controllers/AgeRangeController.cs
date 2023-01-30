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
        [HttpGet]
        [Route("GetIdAgeRangeByAge/{age}")]
        public IActionResult GetIdAgeRangeByAge(string age)
        {
            try
            {
                return Ok(_IAgeRangeBL.GetIdAgeRangeByAge(int.Parse(age)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("AddAgeRange")]
        public IActionResult AddAgeRange([FromBody] AgeRangeDTO u)
        {
            try
            {
                return Ok(_IAgeRangeBL.AddJobsAgeRange(u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleatAgeRange/{id}")]
        public IActionResult DeleatAgeRange(string id)
        {
            try
            {
                return Ok(_IAgeRangeBL.DeleatAgeRange(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateAgeRange/{id}")]
        public IActionResult UpdateAgeRange(string id, AgeRangeDTO u)
        {
            try
            {
                return Ok(_IAgeRangeBL.UpdateAgeRange(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
