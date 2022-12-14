using DalHazinu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
  public class MatureCharacterDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();
        //החזרת כלל סוגי עבודות
        public List<MatureCharacter> GetAllMatureCharacter()
        {
            try
            {
                return _context.MatureCharacter.Include(x => x.IdApplicantNavigation).ThenInclude(x => x.Employees).ThenInclude(x => x.Job).ThenInclude(x => x.Employees).ThenInclude(x => x.IdUserNavigation).ToList();            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteMatureCharacter(int id)
        {
            try
            {
                MatureCharacter u = _context.MatureCharacter.SingleOrDefault(x => x.Id == id);
                _context.MatureCharacter.Remove(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool AddMatureCharacter(MatureCharacter u)
        {

            try
            {
                _context.MatureCharacter.Add(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateMatureCharacter(int id, MatureCharacter u)
        {
            try
            {
                MatureCharacter currentMatureCharacter = _context.MatureCharacter.SingleOrDefault(x => x.Id == id);

                _context.Entry(currentMatureCharacter).CurrentValues.SetValues(u);
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

