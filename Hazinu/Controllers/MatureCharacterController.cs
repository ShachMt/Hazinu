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
    public class MatureCharacterController : ControllerBase
    {
        private IMatureCharacterBL _IMatureCharacterBL;
        public MatureCharacterController(IMatureCharacterBL u)
        {
            _IMatureCharacterBL = u;
        }

        [HttpGet]
        [Route("GetAllMatureCharacter")]
        public List<MatureCharacterDTO> GetAllMatureCharacter()
        {
            return _IMatureCharacterBL.GetAllMatureCharacter();
        }

        [HttpPost]
        [Route("AddMatureCharacter")]
        public IActionResult AddMatureCharacter([FromBody] MatureCharacterDTO s)
        {
            try
            {
                return Ok(_IMatureCharacterBL.AddMatureCharacter(s));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
       

        [HttpDelete]
        [Route("DeleatMatureCharacter/{id}")]
        public IActionResult DeleatMatureCharacter(string id)
        {
            try
            {
                return Ok(_IMatureCharacterBL.DeleatMatureCharacter(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        
        [HttpPut]
        [Route("UpdateMatureCharacter/{id}")]
        public IActionResult UpdateMatureCharacter(string id, MatureCharacterDTO u)
        {
            try
            {
                return Ok(_IMatureCharacterBL.UpdateMatureCharacter(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
