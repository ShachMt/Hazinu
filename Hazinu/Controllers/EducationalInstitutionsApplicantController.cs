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
        //החזרת רשימת מוסדות לפי היוזר
        [HttpGet]
        [Route("GetAllEducationalInstitution/{id}")]

        public IActionResult GetAllEducationalInstitution(string id)
        {
            try
            {
                return Ok(_IEducationalInstitutionsApplicantBL.GetAllEducationalInstitution(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
       
        [HttpGet]
        [Route("GetAllNameEducationalInstitution/{id}/{status}")]
        public IActionResult GetAllNameEducationalInstitution(string id, string status)
        {
            try
            {
                return Ok(_IEducationalInstitutionsApplicantBL.GetAllNameEducationalInstitution(int.Parse(id), status));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        

        [HttpDelete]
        [Route("DeletEducational/{id}")]
        public IActionResult DeletEducational(string id)
        { 
                try
                {
                    return Ok(_IEducationalInstitutionsApplicantBL.DeletEducational(int.Parse(id)));
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            
        }

        // הוספת מוסד לימוד לפונה
        [HttpPost]
        [Route("AddEducational")]
        public IActionResult AddEducational([FromBody] EducationalInstitutionsApplicantDTO u)
        {
            try
            {
                return Ok(_IEducationalInstitutionsApplicantBL.AddEducational(u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        //עדכון מוסד לימוד
        [HttpPut]
        [Route("UpdateEducational/{id}")]
        public IActionResult UpdateEducational(string id, EducationalInstitutionsApplicantDTO u)
        {

            try
            {
                return Ok(_IEducationalInstitutionsApplicantBL.UpdateEducational(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
