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
       
        public Employees GetEmployeeByEmailPassword(string email,string pass)
        {
            try
            {
                Employees e = _context.Employees.FirstOrDefault(x => x.Email==email&&x.Password == pass);
                if (e != null)
                    return e;
                else {
                    Employees em = _context.Employees.FirstOrDefault(x => x.Email == email);
                    //יצירת פעיל חדש עם אימייל בלבד בלי יתר הנתונים
                    //כדי שבאנגולר נוכל לאתר אותו ולהחזיר למשתמש שכחתי סיסמה
                    if (em != null)
                    {
                        Employees employees = new Employees();
                        employees.Email = email;
                        return employees;
                    }
                    else
                        return em;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
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
        public bool DeleteEmployee(string email)
        {
            try
            {
                Employees e = _context.Employees.SingleOrDefault(x => x.Email == email);
                _context.Employees.Remove(e);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool AddEmployee(Employees e)
        {

            try
            {
                _context.Employees.Add(e);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateEmployee(string email, Employees e)
        {
            try
            {
                Employees currentEmployee = _context.Employees.SingleOrDefault(x => x.Email == email);
                _context.Entry(currentEmployee).CurrentValues.SetValues(e);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
    }

}
