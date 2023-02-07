using DalHazinu.Models;
using DTOHazinu.Models;
using System.Collections.Generic;

namespace BLHazinu
{
    public interface IEmployeesBL
    {
        bool AddEmployee(EmployeesDTO e);
        bool DeleatEmployee(string email);
        EmployeesDTO GetEmployeeById(int id);
        List<EmployeesDTO> GetAllEmployees();
        EmployeesDTO GetEmployeeByEmailPassword(string email, string pass);
        string GetEmployeeName(string email, string pass);
        bool UpdateEmployee(string email, EmployeesDTO e);
        EmployeesDTO GetEmployeeByEmail(string email);
        void put(EmployeesDTO employees);

    }
}