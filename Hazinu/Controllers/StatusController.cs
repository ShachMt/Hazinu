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
    public class StatusController : ControllerBase
    {
          private IStatusBL _IStatusBL;
        public StatusController(IStatusBL e)
            {
            _IStatusBL = e;
            }

            [HttpGet]
            [Route("GetAllStatus")]
            public List<StatusDTO> GetAllStatus()
            {
                return _IStatusBL.GetAllStatus();
            }


            [HttpPost]
            [Route("AddStatus")]
            public bool AddJob([FromBody] StatusDTO status)
            {
                return _IStatusBL.AddStatus(status);
            }

            [HttpDelete]
            [Route("DeleatStatus")]
            public bool DeleatStatus([FromBody] string id)
            {
                return _IStatusBL.DeleteStatus(int.Parse(id));
            }
            [HttpPut]
            [Route("UpdateStatus")]
            public bool UpdateUser(string id, StatusDTO u)
            {
                return _IStatusBL.UpdateStatus(int.Parse(id), u);
            }

        }
}
