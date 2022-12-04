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
        [Route("GetAllAppliesByStatus")]
        public List<ApplyDTO> GetAllAppliesByStatus(string status)
        {
            return _IApplyBL.GetAllAppliesByStatus(int.Parse(status));
        }

        [HttpGet]
        [Route("GetAllApplies")]
        public List<ApplyDTO> GetAllApplies()
        {
            return _IApplyBL.GetAllApplies();
        }

    }
}
