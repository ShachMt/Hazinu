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
    public class UsersController : ControllerBase
    {
        private IUserBL _IUserBL;
        public UsersController(IUserBL u)
        {
            _IUserBL = u;
        }
        [HttpGet]
        [Route("GetUsers")]
        public List<UserDTO> GetUsers()
        {
            return _IUserBL.GetUsers();
        }

        [HttpPost]
        [Route("AddUser")]
        public bool AddUser([FromBody] UserDTO u)
        {
            return _IUserBL.AddUser(u);
        }

        [HttpDelete]
        [Route("DeleatUser /{phone}")]
        public bool DeleatUser([FromBody] string phone)
        {
            return _IUserBL.DeleatUser(phone);
        }
        [HttpPut]
        [Route("UpdateUser/{phone}")]
        public bool UpdateUser(string phone, UserDTO u)
        {
            return _IUserBL.UpdateUser(phone, u);
        }

    }
}
