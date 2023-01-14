using DalHazinu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
  public  class FamilyDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();
        public List<Family> GetAllFamilies()
        {
            try
            {

                return _context.Family.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public bool DeleteFamily(int id)
        {
            try
            {
                Family family = _context.Family.SingleOrDefault(x => x.Id == id);
                _context.Family.Remove(family);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int AddAFamily(Family f)
        {

            try
            {
                _context.Family.Add(f);
                _context.SaveChanges();
                return f.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateFamily(int id, Family f)
        {
            try
            {
                Family currentFamily = _context.Family.SingleOrDefault(x => x.Id == id);

                _context.Entry(currentFamily).CurrentValues.SetValues(f);
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
