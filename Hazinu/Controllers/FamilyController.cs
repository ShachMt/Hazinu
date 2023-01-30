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
    public class FamilyController : ControllerBase
    {
        private IFamilyBL _IFamilyBL;
        public FamilyController(IFamilyBL e)
        {
            _IFamilyBL = e;
        }

        [HttpGet]
        [Route("GetAllFamily")]
        public List<FamilyDTO> GetAllFamilies()
        {
            return _IFamilyBL.GetAllFamily();
        }


        [HttpPost]
        [Route("AddFamily")]
        public IActionResult AddFamily([FromBody] FamilyDTO f)
        {
            try
            {
                return Ok(_IFamilyBL.AddFamily(f));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleatFamily/{id}")]
        public IActionResult DeleatFamily(string id)
        {
            try
            {
                return Ok(_IFamilyBL.DeleatFamily(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateFamily/{id}")]
        public IActionResult UpdateFamily(string id, FamilyDTO u)
        {
            try
            {
                return Ok(_IFamilyBL.UpdateFamily(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
