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
    public class PatientDetailsController : ControllerBase
    {
        private IPatientDetailsBL _IPatientDetailsBL;
        public PatientDetailsController(IPatientDetailsBL e)
        {
            _IPatientDetailsBL = e;
        }

        [HttpGet]
        [Route("GetAllPatientDetails")]
        public List<PatientDetailsDTO> GetAllPatientDetails()
        {
            return _IPatientDetailsBL.GetAllPatientDetails();
        }


        [HttpPost]
        [Route("AddPatientDetails")]
        public IActionResult AddPatientDetails([FromBody] PatientDetailsDTO u)
        {
            try
            {
                return Ok(_IPatientDetailsBL.AddPatientDetails(u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleatPatientDetails")]
        public IActionResult DeleatPatientDetails([FromBody] string id)
        {
            try
            {
                return Ok(_IPatientDetailsBL.DeleatPatientDetails(int.Parse(id)));

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        
        [HttpPut]
        [Route("UpdatePatientDetails/{id}")]
        public IActionResult UpdatePatientDetails(string id, PatientDetailsDTO u)
        {
            try
            {
                return Ok(_IPatientDetailsBL.UpdatePatientDetails(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        
    }
}
