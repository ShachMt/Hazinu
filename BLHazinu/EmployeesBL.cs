using AutoMapper;
using DalHazinu;
using DalHazinu.Models;
using DTOHazinu;
using DTOHazinu.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLHazinu
{
    public class EmployeesBL : IEmployeesBL
    {
        IMapper mapper;
        public EmployeesBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        EmployeesDL _EmployeesDL = new EmployeesDL();

        public EmployeesDTO GetEmployeeByEmailPassword(string email, string pass)
        {
            Employees e = _EmployeesDL.GetEmployeeByEmailPassword(email,pass);
            return mapper.Map<Employees, EmployeesDTO>(e);
        }
      public  EmployeesDTO GetEmployeeByEmail(string email)
        {
            Employees e = _EmployeesDL.GetEmployeeByEmail(email);
            return mapper.Map<Employees, EmployeesDTO>(e);
        }
        public string GetEmployeeName(string email, string pass)
        {
            return _EmployeesDL.GetEmployeeName(email, pass);

        }
        public List<EmployeesDTO> GetAllEmployees()
        {
            List<Employees> allEmployees = _EmployeesDL.GetAllEmployees();
            return mapper.Map<List<Employees>, List<EmployeesDTO>>(allEmployees);
        }
        public bool AddEmployee(EmployeesDTO e)
        {

            return _EmployeesDL.AddEmployee(mapper.Map<EmployeesDTO, Employees>(e));

        }
        public bool DeleatEmployee(int id)
        {
            return _EmployeesDL.DeleteEmployee(id);

        }
        public bool UpdateEmployee(int id, EmployeesDTO e)
        {
            return _EmployeesDL.UpdateEmployee(id, mapper.Map<EmployeesDTO, Employees>(e));
        }
        public void put()
        {
           _EmployeesDL.put();

        }

        public EmployeesDTO GetEmployeeById(int id)
        {
            Employees employees = _EmployeesDL.GetEmployeeById(id);
            return mapper.Map<Employees, EmployeesDTO>(employees);
        }
    }
}
