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
        public bool AddPatientDetails([FromBody] PatientDetailsDTO u)
        {
            return _IPatientDetailsBL.AddPatientDetails(u);
        }

        [HttpDelete]
        [Route("DeleatPatientDetails")]
        public bool DeleatPatientDetails([FromBody] string id)
        {
            return _IPatientDetailsBL.DeleatPatientDetails(int.Parse(id));
        }
        [HttpPut]
        [Route("UpdatePatientDetails")]
        public bool UpdatePatientDetails(string id, PatientDetailsDTO u)
        {
            return _IPatientDetailsBL.UpdatePatientDetails(int.Parse(id), u);
        }
    }
}
