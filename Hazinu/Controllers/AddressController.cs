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
    public class AddressController : ControllerBase
    {
            private IAddressBL _IAddressBL;
         public AddressController(IAddressBL u)
            {
            _IAddressBL = u;
            }

        [HttpGet]
        [Route("GetAllAddress")]
        public List<AddressDTO> GetAllAddress()
        {
            return _IAddressBL.GetAllAddress();
        }
        [HttpGet]
        [Route("GetAllAddressByCity")]
        public List<AddressDTO> GetAllAddressByCity([FromBody] string city)
        {
            return _IAddressBL.GetAllAddressByCityId(city);
        }

        [HttpPost]
            [Route("AddAddress")]
            public bool AddAddress([FromBody] AddressDTO u)
            {
                return _IAddressBL.AddAddress(u);
            }

            [HttpDelete]
            [Route("DeleatAddress")]
            public bool DeleatAddress([FromBody] string  id)
            {
                return _IAddressBL.DeleatAddress(int.Parse(id));
            }
            [HttpPut]
            [Route("UpdateAddress")]
            public bool UpdateAddress(string id, AddressDTO u)
            {
                return _IAddressBL.UpdateAddress(int.Parse(id), u);
            }


        }
}
