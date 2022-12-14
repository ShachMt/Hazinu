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
    public class EducationalInstitutionsApplicantController : ControllerBase
    {
        private IEducationalInstitutionsApplicantBL _IEducationalInstitutionsApplicantBL;
        public EducationalInstitutionsApplicantController(IEducationalInstitutionsApplicantBL e)
        {
            _IEducationalInstitutionsApplicantBL = e;
        }

        [HttpGet]
        [Route("GetAllEducationalInstitution")]
        public List<EducationalInstitutionsApplicantDTO> GetAllEducationalInstitution(string id)
        {
            return _IEducationalInstitutionsApplicantBL.GetAllEducationalInstitution(int.Parse(id));
        }
        [HttpGet]
        [Route("GetAllNameEducationalInstitution")]
        public List<EducationalInstitutionDTO> GetAllNameEducationalInstitution(string id, string status)
        {
            return _IEducationalInstitutionsApplicantBL.GetAllNameEducationalInstitution(int.Parse(id),status);
        }

        [HttpDelete]
        [Route("DeletEducational")]
        public bool DeletEducational([FromBody] string idEdu)
        {
            return _IEducationalInstitutionsApplicantBL.DeletEducational(int.Parse(idEdu));
        }

        // הוספת מוסד לימוד לפונה
        [HttpPost]
        [Route("AddEducational")]
        public bool AddEducational([FromBody] EducationalInstitutionsApplicantDTO u)
        {
            return _IEducationalInstitutionsApplicantBL.AddEducational(u);

        }
        //עדכון מוסד לימוד
        [HttpPut]
        [Route("UpdateAgeRange")]
        public bool UpdateEducational(int id, EducationalInstitutionsApplicantDTO u)
        {
            return _IEducationalInstitutionsApplicantBL.UpdateEducational(id,u);

        }
    }
}
