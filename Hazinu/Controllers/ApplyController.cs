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
        [Route("GetAllAppliesByPhone")]
        public List<ApplyDTO> GetAllAppliesByPhone(string phon)
        {
            return _IApplyBL.GetAllAppliesByPhone(phon);
        }
        [HttpGet]
        [Route("GetAllAppliesUserEmployee")]
        public List<ApplyDTO> GetAllAppliesUserEmployee(string email)
        {
            return _IApplyBL.GetAllAppliesUserEmployee(email);

        }
        [HttpPost]
        [Route("AddJob")]
        public bool AddApply([FromBody] ApplyDTO u)
        {
            return _IApplyBL.AddApply(u);
        }

        [HttpDelete]
        [Route("DeleatApply")]
        public bool DeleatApply([FromBody] string id)
        {
            return _IApplyBL.DeleatApply(int.Parse(id));
        }
        [HttpPut]
        [Route("UpdateApply")]
        public bool UpdateApply(string id, ApplyDTO u)
        {
            return _IApplyBL.UpdateApply(int.Parse(id), u);
        }

        //[HttpGet]
        //[Route("GetAllAppliesByStatus")]
        //public List<ApplyDTO> GetAllAppliesByStatus(string status)
        //{
        //    return _IApplyBL.GetAllAppliesByStatus(int.Parse(status));
        //}



    }
}
