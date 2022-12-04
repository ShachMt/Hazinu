using DalHazinu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
    public class TheCauseReferralDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();
        public List<TheCauseReferral> GetTheCauseReferral()
        {
            try
            {

                return _context.TheCauseReferral.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteTheCauseReferral(int id)
        {
            try
            {
                TheCauseReferral theCauseReferral = _context.TheCauseReferral.SingleOrDefault(x => x.Id == id);
                _context.TheCauseReferral.Remove(theCauseReferral);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool AddTheCauseReferral(TheCauseReferral c)
        {

            try
            {
                _context.TheCauseReferral.Add(c);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateTheCauseReferral(int id, TheCauseReferral c)
        {
            try
            {
                TheCauseReferral currentTheCauseReferral = _context.TheCauseReferral.SingleOrDefault(x => x.Id == id);

                _context.Entry(currentTheCauseReferral).CurrentValues.SetValues(c);
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
