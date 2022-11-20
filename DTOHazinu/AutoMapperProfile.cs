using DalHazinu.Models;
using DTOHazinu.Models;
using System;

namespace DTOHazinu
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();

            CreateMap<EmployeesDTO, Employees>();
            CreateMap<Employees, EmployeesDTO>();

        }
    }
}
