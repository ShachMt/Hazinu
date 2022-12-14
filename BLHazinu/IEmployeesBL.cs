using DalHazinu.Models;
using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IEmployeesBL
    {
        bool AddEmployee(EmployeesDTO e);
        bool DeleatEmployee(string email);
        List<EmployeesDTO> GetAllEmployees();
        EmployeesDTO GetEmployeeByEmailPassword(string email, string pass);
        string GetEmployeeName(string email, string pass);
        bool UpdateEmployee(string email, EmployeesDTO e);
        void put(EmployeesDTO employees);

    }
}