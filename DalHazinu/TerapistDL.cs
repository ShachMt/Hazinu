using DalHazinu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
  public  class TerapistDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();
        public List<Terapist> GetAllTerapist()
        {
            try
            {
                return _context.Terapist.Include(x=>x.IdUserNavigation).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public bool DeleteTerapist(int id)
        {
            try
            {
                Terapist terapist = _context.Terapist.SingleOrDefault(x => x.Id == id);
                _context.Terapist.Remove(terapist);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int AddTerapist(Terapist t)
        {

            try
            {
                _context.Terapist.Add(t);
                _context.SaveChanges();
                return t.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateTerapist(int id, Terapist t)
        {
            try
            {
                Terapist currentTerapist = _context.Terapist.SingleOrDefault(x => x.Id == id);

                _context.Entry(currentTerapist).CurrentValues.SetValues(t);
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
