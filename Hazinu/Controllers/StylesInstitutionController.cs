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
    public class StylesInstitutionController : ControllerBase
    {

        private IStylesInstitutionBL _IStylesInstitutionBL;
        public StylesInstitutionController(IStylesInstitutionBL e)
        {
            _IStylesInstitutionBL = e;
        }

        [HttpGet]
        [Route("GetAllStylesInstitution")]
        public List<StylesInstitutionDTO> GetAllStylesInstitution()
        {
            return _IStylesInstitutionBL.GetAllStylesInstitution();
        }


        [HttpPost]
        [Route("AddStylesInstitution")]
        public IActionResult AddStylesInstitution([FromBody] StylesInstitutionDTO u)
        {
            try
            {
                return Ok(_IStylesInstitutionBL.AddStylesInstitution(u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleatStylesInstitution/{id}")]

        public IActionResult DeleatJobs(string id)
        {
            try
            {
                return Ok(_IStylesInstitutionBL.DeleteStylesInstitution(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        [HttpPut]
        [Route("UpdateStylesInstitution/{id}")]
        public IActionResult UpdateStylesInstitution(string id, StylesInstitutionDTO u)
        {
            try
            {
                return Ok(_IStylesInstitutionBL.UpdateStylesInstitution(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
