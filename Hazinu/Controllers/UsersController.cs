﻿using BLHazinu;
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
        [HttpGet]
        [Route("GetUserByPhone/{phone}")]
        public UserDTO GetUserByPhone(string phone)
        {
           
             return  _IUserBL.GetUserByPhone(phone);
        }
        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser([FromBody] UserDTO u)
        {
            try
            {
                return Ok(_IUserBL.AddUser(u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleatUser /{phone}")]
        public IActionResult DeleatUser([FromBody] string phone)
        {
            try
            {
                return Ok(_IUserBL.DeleatUser(phone));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateUser/{id}")]
        public IActionResult UpdateUser(string id, UserDTO u)
        {
            try
            {
                return Ok(_IUserBL.UpdateUser(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
