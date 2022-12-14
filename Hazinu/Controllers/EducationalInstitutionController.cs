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
    public class EducationalInstitutionController : ControllerBase
    {
        private IEducationalInstitutionBL _IEducationalInstitutionBL;
        public EducationalInstitutionController(IEducationalInstitutionBL e)
        {
            _IEducationalInstitutionBL = e;
        }

        [HttpGet]
        [Route("GetAllEducationalInstitution")]
        public List<EducationalInstitutionDTO> GetEducationalInstitution()
        {
            return _IEducationalInstitutionBL.GetAllEducationalInstitution();
        }
        [HttpGet]
        [Route("GetAllInstitutionsCategoriesByGender")]
        public List<EducationalInstitutionDTO> GetAllInstitutionsCategoriesByGender(string gender, string age)
        {
            return _IEducationalInstitutionBL.GetAllInstitutionsCategoriesByGender(gender,int.Parse(age));
        }

        [HttpGet]
        [Route("GetAllInstitutionsCategoriesByGenderCity")]
        public List<EducationalInstitutionDTO> GetAllInstitutionsCategoriesByGenderCity(string gender, string age, string city)
        {
            return _IEducationalInstitutionBL.GetAllInstitutionsCategoriesByGenderCity(gender, int.Parse(age),city);
        }




        [HttpPost]
        [Route("AddEducationalInstitution")]
        public bool AddEducationalInstitution([FromBody] EducationalInstitutionDTO u)
        {
            return _IEducationalInstitutionBL.AddEducationalInstitution(u);
        }

        [HttpDelete]
        [Route("DeleteEducationalInstitution")]
        public bool DeleteEducationalInstitution([FromBody] string nameI)
        {
            return _IEducationalInstitutionBL.DeleteEducationalInstitution(nameI);
        }


        [HttpPut]
        [Route("UpdateEducationalInstitution")]
        public bool UpdateEducationalInstitution(string nameI, EducationalInstitutionDTO u)
        {
            return _IEducationalInstitutionBL.UpdateEducationalInstitution(nameI, u);
        }





    }
}
