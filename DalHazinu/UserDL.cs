using DalHazinu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


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

        public List<User> GetUsers()
        {
            try
            {

                return _context.User.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public User GetUserByPhone(string phone)
        {
            try
            {
                User u = _context.User.FirstOrDefault(x => x.Phone == phone);
                return u;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


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
        public int AddUsers(User u)
        {

            try
            {
                _context.User.Add(u);
                _context.SaveChanges();
                return u.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateUser(int id, User u)
        {
            try
            {
                User currentUsers = _context.User.FirstOrDefault(x => x.Id == id);
                
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
