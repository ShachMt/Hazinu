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
        public bool AddMatureCharacter([FromBody] MatureCharacterDTO u)
        {
            return _IMatureCharacterBL.AddMatureCharacter(u);
        }

        [HttpDelete]
        [Route("DeleatMatureCharacter")]
        public bool DeleatAddress([FromBody] string id)
        {
            return _IMatureCharacterBL.DeleatMatureCharacter(int.Parse(id));
        }
        [HttpPut]
        [Route("UpdateMatureCharacter")]
        public bool UpdateMatureCharacter(string id, MatureCharacterDTO u)
        {
            return _IMatureCharacterBL.UpdateMatureCharacter(int.Parse(id), u);
        }
    }
}
