using DalHazinu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
   public class EmployeesDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();
        //RETURN NALL EMPLOYEES
        public List<Employees> GetAllEmployees()
        {
            try
            {
                return _context.Employees.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Employees GetEmployeeByEmailPassword(string email,string pass)
        {
            try
            {
                Employees e = _context.Employees.SingleOrDefault(x => x.Email==email&&x.Password == pass);
               
                return e;
            }
            catch (Exception ex)
            {
                //try
                //{
                //    Employees e = _context.Employees.SingleOrDefault(x => x.Email == email);
                //    Response.Write("<script>alert('Data inserted successfully')</script>");
                //}
                //catch (Exception)
                //{

                //    throw;
                //}
                return null;
            }

        }
    }
}
