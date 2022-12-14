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
    public class TreatmentDetailsController : ControllerBase
    {
        private ITreatmentDetailsBL _ITreatmentDetailsBL;
        public TreatmentDetailsController(ITreatmentDetailsBL e)
        {
            _ITreatmentDetailsBL = e;
        }

        [HttpGet]
        [Route("GetAllTreatmentDetails")]
        public List<TreatmentDetailsDTO> GetAllTreatmentDetails(int applyId)
        {
            return _ITreatmentDetailsBL.GetAllTreatmentDetails(applyId);
        }


        [HttpPost]
        [Route("AddTreatmentDetails")]
        public bool AddTreatmentDetails([FromBody] TreatmentDetailsDTO u)
        {
            return _ITreatmentDetailsBL.AddTreatmentDetails(u);
        }

        [HttpDelete]
        [Route("DeleatTreatmentDetails")]
        public bool DeleatJobs([FromBody] string id)
        {
            return _ITreatmentDetailsBL.DeleatTreatmentDetails(int.Parse(id));
        }
        [HttpPut]
        [Route("UpdateTreatmentDetails")]
        public bool UpdateTreatmentDetails(string id, TreatmentDetailsDTO u)
        {
            return _ITreatmentDetailsBL.UpdateTreatmentDetails(int.Parse(id), u);
        }


    }
}
