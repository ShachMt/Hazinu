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
        public List<StylesInstitutionDTO> GetAllApplies()
        {
            return _IStylesInstitutionBL.GetAllStylesInstitution();
        }


        [HttpPost]
        [Route("AddStylesInstitution")]
        public bool AddStylesInstitution([FromBody] StylesInstitutionDTO u)
        {
            return _IStylesInstitutionBL.AddStylesInstitution(u);
        }

        [HttpDelete]
        [Route("DeleatStylesInstitution")]
        public bool DeleatJobs([FromBody] string id)
        {
            return _IStylesInstitutionBL.DeleteStylesInstitution(int.Parse(id));
        }
        [HttpPut]
        [Route("UpdateStylesInstitution")]
        public bool UpdateStylesInstitution(string id, StylesInstitutionDTO u)
        {
            return _IStylesInstitutionBL.UpdateStylesInstitution(int.Parse(id), u);
        }
    }
}
