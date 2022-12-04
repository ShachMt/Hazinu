using DalHazinu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
   public class JobsDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();

        //החזרת כלל סוגי עבודות
        public List<Jobs> GetAllJobs()
        {
            try
            {
               
                return _context.Jobs.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteJobs(int id)
        {
            try
            {
                Jobs u = _context.Jobs.SingleOrDefault(x => x.Id == id);
                _context.Jobs.Remove(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool AddJobs(Jobs u)
        {

            try
            {
                _context.Jobs.Add(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateJobs(int id, Jobs u)
        {
            try
            {
                Jobs currentUsers = _context.Jobs.SingleOrDefault(x => x.Id == id);

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
