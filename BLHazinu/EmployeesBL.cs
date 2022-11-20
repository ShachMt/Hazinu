using AutoMapper;
using DalHazinu;
using DTOHazinu;
using DTOHazinu.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLHazinu
{
   public class EmployeesBL
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
        
        //public List<EmployeesDTO> GetAllEmployees()
        //{

        //}
    }
}
