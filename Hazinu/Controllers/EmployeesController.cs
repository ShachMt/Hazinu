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
    public class EmployeesController : ControllerBase
    {
        private IEmployeesBL _IEmployeesBL;
        public EmployeesController(IEmployeesBL e)
        {
            _IEmployeesBL = e;
        }

        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployees([FromBody] EmployeesDTO e)
        {
            try
            {
                return Ok(_IEmployeesBL.AddEmployee(e));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpDelete]
        [Route("DeleatEmployee/{id}")]
        public IActionResult DeleatEmployee(string id)
        {
            try
            {
                return Ok(_IEmployeesBL.DeleatEmployee(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateEmployee/{id}")]
        public IActionResult UpdateEmployee(string id, EmployeesDTO e)
        {
            try
            {
                return Ok(_IEmployeesBL.UpdateEmployee(int.Parse(id), e));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpGet]
        [Route("GetEmployeeByPasswordEmail/{email}/{password}")]
        public IActionResult GetEmployeeByEmailPassword(string email, string password)
        {
            try
            {
                return Ok(_IEmployeesBL.GetEmployeeByEmailPassword(email, password));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        [HttpGet]
        [Route("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(string id)
        {
            try
            {
                return Ok(_IEmployeesBL.GetEmployeeById(int.Parse(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        [HttpGet]
        [Route("GetEmployeeByEmail/{email}")]
        public IActionResult GetEmployeeByEmail(string email)
        {
            try
            {
                return Ok(_IEmployeesBL.GetEmployeeByEmail(email));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        [HttpGet]
        [Route("GetEmployeeName/{email}/{password}")]

        public IActionResult GetEmployeeName(string email, string password)
        {
            try
            {
                return Ok(_IEmployeesBL.GetEmployeeName(email, password));
            }

            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetAllEmployees")]
        public List<EmployeesDTO> GetAllEmployees()
        {
            return _IEmployeesBL.GetAllEmployees().ToList();
        }
        [HttpPost]
        [Route("UpdateEmployeeCode")]
        public IActionResult put()
        {
            try
            {
                _IEmployeesBL.put();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
           ;
        }


    }
}
