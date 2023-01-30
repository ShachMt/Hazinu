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
        [Route("GetAllCities")]
        public  List<string> GetAllCities()
        {
            return _IAddressBL.GetAllCities();
        }
        [HttpGet]
        [Route("GetAllAddressByCity")]
        public List<AddressDTO> GetAllAddressByCity([FromBody] string city)
        {
            return _IAddressBL.GetAllAddressByCityId(city);
        }
        [HttpGet]
        [Route("GetIdAddressByCity")]
        public int GetIdAddressByCity(string nameCity)
        {
            return _IAddressBL.GetIdAddressByCity(nameCity);
        }

        [HttpPost]
            [Route("AddAddress")]
        public IActionResult AddAddress([FromBody] AddressDTO u)
        {
            try
            {
                return Ok(_IAddressBL.AddAddress(u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

            [HttpDelete]
            [Route("DeleatAddress")]
        public IActionResult DeleatAddress([FromBody] string id)
        {
            try
            {
                return Ok(_IAddressBL.DeleatAddress(int.Parse(id)));

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    
            [HttpPut]
            [Route("UpdateAddress/{id}")]
        public IActionResult UpdateAddress(string id, AddressDTO u)
        {
            try
            {
                return Ok(_IAddressBL.UpdateAddress(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        }
}
