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

        public IActionResult AddSector([FromBody] SectorDTO s)
        {
            try
            {
                return Ok(_ISectorBL.AddSector(s));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

            [HttpDelete]
            [Route("DeleatSector")]
        public IActionResult DeleatSector([FromBody] string id)
        {
            try
            {
                return Ok(_ISectorBL.DeleteSector(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

            [HttpPut]
            [Route("UpdateSector/{id}")]
        public IActionResult UpdateSector(string id, SectorDTO u)
        {
            try
            {
                return Ok(_ISectorBL.UpdateSector(int.Parse(id),u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        }
}
