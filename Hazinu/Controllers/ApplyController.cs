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
        [Route("GetAllAppliesEmployee/{EmpId}")]
        public IActionResult GetAllAppliesEmployee(string EmpId)
        {
            try
            {
                return Ok(_IApplyBL.GetAllAppliesEmployee(int.Parse(EmpId)));
            }

            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetApplyById/{applyId}")]
        public IActionResult GetApplyById(string applyId)
        {
            try
            {
                return Ok(_IApplyBL.GetApplyById(int.Parse(applyId)));
            }

            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAllAppliesByPhone/{phone}")]
        public IActionResult GetAllAppliesByPhone(string phone)
        {
            try
            {
                return Ok(_IApplyBL.GetAllAppliesByPhone(phone));
            }

            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }
        [HttpGet]
        [Route("GetAllAppliesUserEmployee/{idEmployees}")]
        public IActionResult GetAllAppliesUserEmployee(string idEmployees)
        {
            try
            {
                return Ok(_IApplyBL.GetAllAppliesUserEmployee(int.Parse(idEmployees)));
            }

            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAllAppliesByEmployee/{idEmployees}")]
        public IActionResult GetAllAppliesByEmployee(string idEmployees)
        {
            try
            {
                return Ok(_IApplyBL.GetAllAppliesByEmployee(int.Parse(idEmployees)));
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
        [Route("DeleatApply/{id}")]
        public IActionResult DeleatApply( string id)
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
        [Route("GetAllAppliesByStatusEmailTerapist/{idEmployees}/{status}")]
        public List<ApplyDTO> GetAllApplyByStatusEmailTerapist(string idEmployees, string status)
        {

            return _IApplyBL.GetAllApplyByStatusEmailTerapist(int.Parse(status),int.Parse(idEmployees));
        }
        [HttpGet]
        [Route("GetAllApplyByStatus/{status}")]
        public List<ApplyDTO> GetAllApplyByStatus(string status)
        {
            return _IApplyBL.GetAllApplyByStatus(int.Parse(status));
        }

        

    }
}
