using DalHazinu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
 public class SectorDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();

        //החזרת הסטטוסים הקיימים
        public List<Sector> GetAllSector()
        {
            try
            {

                return _context.Sector.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //הוספת סטטוס
        public int AddSector(Sector s)
        {
            try
            {
                _context.Sector.Add(s);
                _context.SaveChanges();
                return s.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ////מחיקה
        public bool DeleteSector(int id)
        {
            try
            {
                Sector sector = _context.Sector.FirstOrDefault(x => x.Id == id);
                _context.Sector.Remove(sector);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        ////ועדכון קטגוריה
        public bool UpdateSector(int id, Sector sector)
        {
            try
            {
                Sector currentSector = _context.Sector.FirstOrDefault(x => x.Id == id);

                _context.Entry(sector).CurrentValues.SetValues(currentSector);
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
