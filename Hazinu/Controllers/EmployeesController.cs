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
    public class EmployeesController : ControllerBase
    {
        private IEmployeesBL _IEmployeesBL;
        public EmployeesController(IEmployeesBL e)
        {
            _IEmployeesBL = e;
        }

        [HttpPost]
        [Route("AddEmployee")]
        public bool AddEmployees([FromBody] EmployeesDTO e)
        {
            return _IEmployeesBL.AddEmployee(e);
        }

        [HttpDelete]
        [Route("DeleatEmployee")]
        public bool DeleatEmployee([FromBody] string email)
        {
            return _IEmployeesBL.DeleatEmployee(email);
        }

        [HttpPut]
        [Route("UpdateEmployee")]
        public bool UpdateFlight(string email, EmployeesDTO e)
        {
            return _IEmployeesBL.UpdateEmployee(email, e);
        }

        [HttpGet]
        [Route("GetEmployeeByPasswordEmail")]
        //[FromBody] EmployeesDTO obj
        public EmployeesDTO GetEmployeeByEmailPassword(string email,string password)
        {
            return _IEmployeesBL.GetEmployeeByEmailPassword(email,password);
        }
        [HttpGet]
        [Route("GetEmployeeName")]

        public string GetEmployeeName(string email, string pass)
        {
            return _IEmployeesBL.GetEmployeeName(email, pass);
        }

        [HttpGet]
        [Route("GetAllEmployees")]
        public List<EmployeesDTO> GetAllEmployees()
        {
            return _IEmployeesBL.GetAllEmployees().ToList();
        }
        [HttpPut]
        [Route("UpdateEmployeeCode")]
        public bool put(EmployeesDTO employees)
        {
            _IEmployeesBL.put(employees);
            return true;
        }


    }
}
