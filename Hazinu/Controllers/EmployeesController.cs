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
        public EmployeesDTO GetEmployeeByEmailPassword([FromBody] EmployeesDTO obj)
        {
            return _IEmployeesBL.GetEmployeeByEmailPassword(obj.Email,obj.Password);
        }

        [HttpGet]
        [Route("GetAllEmployees")]
        public List<EmployeesDTO> GetAllEmployees()
        {
            return _IEmployeesBL.GetAllEmployees().ToList();
        }

    }
}
