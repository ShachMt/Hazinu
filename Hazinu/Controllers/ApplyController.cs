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
    public class ApplyController : ControllerBase
    {
        private IApplyBL _IApplyBL;
        public ApplyController(IApplyBL e)
        {
            _IApplyBL = e;
        }
        [HttpGet]
        [Route("GetAllApplies")]
        public List<ApplyDTO> GetAllApplies()
        {

            return _IApplyBL.GetAllApplies();
        }
        [HttpGet]
        [Route("GetAllAppliesByPhone/{phon}")]
        public IActionResult GetAllAppliesByPhone(string phon)
        {
            try
            {
                return Ok(_IApplyBL.GetAllAppliesByPhone(phon));
            }

            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }
        [HttpGet]
        [Route("GetAllAppliesUserEmployee")]
        public IActionResult GetAllAppliesUserEmployee(string email)
        {
            try
            {
                return Ok(_IApplyBL.GetAllAppliesUserEmployee(email));
            }

            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("AddApply")]
        public IActionResult AddApply([FromBody] ApplyDTO u)
        {
            try
            {
                return Ok(_IApplyBL.AddApply(u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleatApply")]
        public IActionResult DeleatApply([FromBody] string id)
        {
             try
            {
                return Ok(_IApplyBL.DeleatApply(int.Parse(id)));

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateApply/{id}")]
        public IActionResult UpdateApply(string id, ApplyDTO u)
        {
            try
            {
                return Ok(_IApplyBL.UpdateApply(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetAllAppliesByStatusEmailTerapist/{email}")]
        public List<ApplyDTO> GetAllApplyByStatusEmailTerapist(string status, string email)
        {
            return _IApplyBL.GetAllApplyByStatusEmailTerapist(int.Parse(status),email);
        }
        [HttpGet]
        [Route("GetAllApplyByStatus/{status}")]
        public List<ApplyDTO> GetAllApplyByStatus(string status)
        {
            return _IApplyBL.GetAllApplyByStatus(int.Parse(status));
        }

        

    }
}
