using DalHazinu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
   public class AgeRangeDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();

        //החזרת כלל טווחים 
        public List<AgeRange> GetAllAgeRange()
        {
            try
            {

                return _context.AgeRange.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetIdAgeRangeByAge(int age)
        {
            List<AgeRange> l = GetAllAgeRange();
            return l.FirstOrDefault(x => x.From <= age && x.To >= age).Id;

        }
        public bool DeleteAgeRange(int id)
        {
            try
            {
                AgeRange u = _context.AgeRange.SingleOrDefault(x => x.Id == id);
                _context.AgeRange.Remove(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool AddAgeRange(AgeRange u)
        {

            try
            {
                _context.AgeRange.Add(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateAgeRange(int id, AgeRange u)
        {
            try
            {
                AgeRange currentAgeRange = _context.AgeRange.SingleOrDefault(x => x.Id == id);

                _context.Entry(currentAgeRange).CurrentValues.SetValues(u);
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
