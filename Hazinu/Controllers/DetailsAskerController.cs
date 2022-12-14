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
    public class DetailsAskerController : ControllerBase
    {
        private IDetailsAskerBL _IDetailsAskerBL;
        public DetailsAskerController(IDetailsAskerBL d)
        {
            _IDetailsAskerBL = d;
        }

        [HttpGet]
        [Route("GetAllDetailsAsker")]
        public List<DetailsAskerDTO> GetAllDetailsAsker()
        {
            return _IDetailsAskerBL.GetAllDetailsAsker();
        }

        [HttpGet]
        [Route("GetAllDetailsAskerByResone")]
        public List<DetailsAskerDTO> GetAllDetailsAskerByResone(string id)
        {
            return _IDetailsAskerBL.GetAllDetailsAskerByResone(int.Parse(id));
        }

        [HttpPost]
        [Route("AddDetailsAsker")]
        public bool AddDetailsAsker([FromBody] DetailsAskerDTO u)
        {
            return _IDetailsAskerBL.AddDetailsAsker(u);
        }

        [HttpDelete]
        [Route("DeleatDetailsAsker")]
        public bool DeleatJobs([FromBody] string id)
        {
            return _IDetailsAskerBL.DeleatDetailsAsker(int.Parse(id));
        }
        [HttpPut]
        [Route("UpdateDetailsAsker")]
        public bool UpdateUser(string id, DetailsAskerDTO u)
        {
            return _IDetailsAskerBL.UpdateDetailsAsker(int.Parse(id), u);
        }


    }
}
