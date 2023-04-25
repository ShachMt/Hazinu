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
        [Route("GetAllTreatmentDetails/{applyId}")]
        public List<TreatmentDetailsDTO> GetAllTreatmentDetails(string applyId)
        {
            return _ITreatmentDetailsBL.GetAllTreatmentDetails(int.Parse(applyId));
        }
        [HttpGet]
        [Route("GetTreatmentDetailsByApplyState/{applyId}")]
        public TreatmentDetailsDTO GetTreatmentDetailsByApplyState(string applyId)
        {
            return _ITreatmentDetailsBL.GetTreatmentDetailsByApplyState(int.Parse(applyId));
        }

        [HttpPost]
        [Route("AddTreatmentDetails")]
        public IActionResult AddTreatmentDetails([FromBody] TreatmentDetailsDTO t)
        {
            try
            {
                t.DateNow = t.DateNow.Value.AddHours(3);
                t.DateNow = t.DateNow.Value.AddMilliseconds(477);

                t.DateTask= t.DateTask.Value.AddHours(3);
                t.DateTask = t.DateTask.Value.AddMilliseconds(477);
                t.DateTask = t.DateTask.Value.AddSeconds(5);
                return Ok(_ITreatmentDetailsBL.AddTreatmentDetails(t));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleatTreatmentDetails/{id}")]
        public IActionResult DeleatTreatmentDetails( string id)
        {
            try
            {
                return Ok(_ITreatmentDetailsBL.DeleatTreatmentDetails(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateTreatmentDetails/{id}")]
        public IActionResult UpdateTreatmentDetails(string id, TreatmentDetailsDTO u)
        {
            try
            {
                return Ok(_ITreatmentDetailsBL.UpdateTreatmentDetails(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


    }
}
