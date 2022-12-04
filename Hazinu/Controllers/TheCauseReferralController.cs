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
    public class TheCauseReferralController : ControllerBase
    {
        private ITheCauseReferralBL _ITheCauseReferralBL;
        public TheCauseReferralController(ITheCauseReferralBL u)
        {
            _ITheCauseReferralBL = u;
        }

        [HttpGet]
        [Route("GetAllTheCauseReferral")]
        public List<TheCauseReferralDTO> GetAllTheCauseReferral()
        {
            return _ITheCauseReferralBL.GetTheCauseReferral();
        }

        [HttpPost]
        [Route("AddTheCauseReferral")]
        public bool AddTheCauseReferral([FromBody] TheCauseReferralDTO u)
        {
            return _ITheCauseReferralBL.AddTheCauseReferral(u);
        }

        [HttpDelete]
        [Route("DeleatTheCauseReferral")]
        public bool DeleatTheCauseReferral([FromBody] string id)
        {

            return _ITheCauseReferralBL.DeleteTheCauseReferral(int.Parse(id));
        }
        [HttpPut]
        [Route("UpdateTheCauseReferral/{id}")]
        public bool UpdateTheCauseReferral(string id, TheCauseReferralDTO u)
        {
            return _ITheCauseReferralBL.UpdateTheCauseReferral(int.Parse(id), u);
        }
    }
}
