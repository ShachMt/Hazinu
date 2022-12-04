using DalHazinu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
   public class StatusDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();

        //החזרת הסטטוסים הקיימים
        public List<Status> GetAllStatus()
        {
            try
            {

                return _context.Status.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //הוספת סטטוס
        public bool AddStatus(Status s)
        {
            try
            {
                _context.Status.Add(s);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ////מחיקת סטטוס
        public bool DeleteStatus(int id)
        {
            try
            {
                Status status = _context.Status.FirstOrDefault(x => x.Id == id);
                _context.Status.Remove(status);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        ////ועדכון קטגוריה
        public bool UpdateStatus(int id, Status status)
        {
            try
            {
                Status currentStatus = _context.Status.FirstOrDefault(x => x.Id == id);

                _context.Entry(status).CurrentValues.SetValues(status);
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
