using DalHazinu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
    public class StylesInstitutionDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();
        public List<StylesInstitution> GetAllStylesInstitution()
        {
            try
            {
                return _context.StylesInstitution.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteStylesInstitution(int id)
        {
            try
            {
                StylesInstitution styles = _context.StylesInstitution.SingleOrDefault(x => x.Id == id);
                _context.StylesInstitution.Remove(styles);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int AddStylesInstitution(StylesInstitution a)
        {

            try
            {
                _context.StylesInstitution.Add(a);
                _context.SaveChanges();
                return a.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateStylesInstitution(int id, StylesInstitution a)
        {
            try
            {
                StylesInstitution currentStylesInstitution = _context.StylesInstitution.SingleOrDefault(x => x.Id == id);

                _context.Entry(currentStylesInstitution).CurrentValues.SetValues(a);
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
