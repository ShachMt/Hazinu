using DalHazinu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
  public  class FilesDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();

        //החזרת כלל סוגי הצרופות
        public List<Files> GetAllFiles()
        {
            try
            {
                return _context.Files.Include(x=>x.IdApplyNavigation).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteFiles(int id)
        {
            try
            {
                Files u = _context.Files.SingleOrDefault(x => x.Id == id);
                _context.Files.Remove(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int AddFiles(Files u)
        {

            try
            {
                _context.Files.Add(u);
                _context.SaveChanges();
                return u.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateFiles(int id, Files u)
        {
            try
            {
                Files currentFiles = _context.Files.SingleOrDefault(x => x.Id == id);

                _context.Entry(currentFiles).CurrentValues.SetValues(u);
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
