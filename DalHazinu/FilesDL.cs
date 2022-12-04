using DalHazinu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
  public  class FilesDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();

        //החזרת כלל סוגי עבודות
        public List<Files> GetAllFiles()
        {
            try
            {
                return _context.Files.ToList();
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
        public bool AddFiles(Files u)
        {

            try
            {
                _context.Files.Add(u);
                _context.SaveChanges();
                return true;
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
