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
    public class SectorController : ControllerBase
    {
       
            private ISectorBL _ISectorBL;
            public SectorController(ISectorBL e)
            {
            _ISectorBL = e;
            }

            [HttpGet]
            [Route("GetAllSector")]
            public List<SectorDTO> GetAllSector()
            {
                return _ISectorBL.GetAllSector();
            }


            [HttpPost]
            [Route("AddSector")]
            public bool AddJob([FromBody] SectorDTO u)
            {
                return _ISectorBL.AddSector(u);
            }

            [HttpDelete]
            [Route("DeleatSector")]
            public bool DeleatSector([FromBody] string id)
            {
                return _ISectorBL.DeleteSector(int.Parse(id));
            }
            [HttpPut]
            [Route("UpdateSector")]
            public bool UpdateSector(string id, SectorDTO u)
            {
                return _ISectorBL.UpdateSector(int.Parse(id), u);
            }


        }
}
