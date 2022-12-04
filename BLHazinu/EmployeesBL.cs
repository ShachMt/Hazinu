﻿using AutoMapper;
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

        public List<EmployeesDTO> GetAllEmployees()
        {
            List<Employees> allEmployees = _EmployeesDL.GetAllEmployees();
            return mapper.Map<List<Employees>, List<EmployeesDTO>>(allEmployees);
        }

        public bool AddEmployee(EmployeesDTO e)
        {

            return _EmployeesDL.AddEmployee(mapper.Map<EmployeesDTO, Employees>(e));

        }
        public bool DeleatEmployee(string email)
        {
            return _EmployeesDL.DeleteEmployee(email);

        }
        public bool UpdateEmployee(string email, EmployeesDTO e)
        {
            return _EmployeesDL.UpdateEmployee(email, mapper.Map<EmployeesDTO, Employees>(e));
        }
    }
}
