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
    public class TerapistController : ControllerBase
    {
        private ITerapistBL _ITerapistBL;
        public TerapistController(ITerapistBL e)
        {
            _ITerapistBL = e;
        }

        [HttpGet]
        [Route("GetAllTerapist")]
        public List<TerapistDTO> GetAllTerapist()
        {
            return _ITerapistBL.GetAllTerapist();
        }


        [HttpPost]
        [Route("AddTerapist")]
        public IActionResult AddTerapist([FromBody] TerapistDTO s)
        {
            try
            {
                return Ok(_ITerapistBL.AddTerapist(s));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleatTerapist/{id}")]
        public IActionResult DeleatTerapist(string id)
        {
            try
            {
                return Ok(_ITerapistBL.DeleatTerapist(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateTerapist/{id}")]
        public IActionResult UpdateTerapist(string id, TerapistDTO u)
        {
            try
            {
                return Ok(_ITerapistBL.UpdateTerapist(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
