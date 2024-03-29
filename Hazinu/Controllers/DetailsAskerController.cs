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
    public class DetailsAskerController : ControllerBase
    {
        private IDetailsAskerBL _IDetailsAskerBL;
        public DetailsAskerController(IDetailsAskerBL d)
        {
            _IDetailsAskerBL = d;
        }
        [HttpGet]
        [Route("GetIdDetailsAsker/{idUserAsker}")]
        public int GetIdDetailsAsker(string idUserAsker)
        {
            return _IDetailsAskerBL.GetIdDetailsAsker(int.Parse(idUserAsker));
        }
        [HttpGet]
        [Route("GetAllDetailsAsker")]
        public List<DetailsAskerDTO> GetAllDetailsAsker()
        {
            return _IDetailsAskerBL.GetAllDetailsAsker();
        }

        [HttpGet]
        [Route("GetAllDetailsAskerByResone/{id}")]
        public IActionResult GetAllDetailsAskerByResone(string id)
        {
            try
            {
                return Ok(_IDetailsAskerBL.GetAllDetailsAskerByResone(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetDetailsAskerByUserAskerId/{userId}")]
        public IActionResult GetDetailsAskerByUserAskerId(string userId)
        {
            try
            {
                return Ok(_IDetailsAskerBL.GetDetailsAskerByUserAskerId(int.Parse(userId)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetDetailsAskerByApplyId/{id}")]
        public IActionResult GetDetailsAskerByApplyId(string id)
        {
            try
            {
                return Ok(_IDetailsAskerBL.GetDetailsAskerByApplyId(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("AddDetailsAsker")]


        public IActionResult AddDetailsAsker([FromBody] DetailsAskerDTO u)
        {
            try
            {
                return Ok(_IDetailsAskerBL.AddDetailsAsker(u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleatDetailsAsker/{id}")]

        public IActionResult DeleatDetailsAsker(string id)
        {
            try
            {
                return Ok(_IDetailsAskerBL.DeleatDetailsAsker(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
       
        [HttpPut]
        [Route("UpdateDetailsAsker/{id}")]

        public IActionResult UpdateDetailsAsker(string id, [FromBody] DetailsAskerDTO u)
        {
            try
            {
                return Ok(_IDetailsAskerBL.UpdateDetailsAsker(int.Parse(id), u));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
