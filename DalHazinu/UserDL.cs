using DalHazinu.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DalHazinu
{
    public class UserDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();
       
        //
        //
        //החזרת כלל היוזרים 
        //public List<User> GetAllUsers()
        //{
        //    try
        //    {
        //        return _context.User.ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}
        public bool DeleteUser(string phone)
        {
            try
            {
                User u = _context.User.SingleOrDefault(x => x.Phone == phone);
                _context.User.Remove(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool AddUsers(User u)
        {
            //u.TreatmentDetails = null;
            //u.StffDetails = null;
            //u.PatientDetails = null;
            //u.Employees = null;
            //u.EducationalInstitutionsApplicant = null;
            //u.DetailsAsker = null;
            //u.Apply = null;
            //u.MatureCharacter = null;

            try
            {
                _context.User.Add(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateUser(string phon, User u)
        {
            try
            {
                User currentUsers = _context.User.SingleOrDefault(x => x.Phone == phon);
                _context.Entry(currentUsers).CurrentValues.SetValues(u);
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
