using DalHazinu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
   public class DetailsAskerDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();

        //החזרת כלל הפונים וכן, עדכון היוזר לפי האיי די
        public List<DetailsAsker> GetAllDetailsAsker()
        {
            try
            {
                List<DetailsAsker> b= _context.DetailsAsker.Include(x=> x.User).Include(x=>x.IdResoneNavigation).ToList();
                return b;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //החזרת כלל הפונים וכן לפי סיבת פניה מסויימת
        public List<DetailsAsker> GetAllDetailsAskerByResone(int resone)
        {
            List<DetailsAsker> b = GetAllDetailsAsker().Where(x => x.IdResoneNavigation.Id == resone).ToList();
            return b;
        }

        public bool DeleteDetailsAsker(int id)
        {
            try
            {
                DetailsAsker u = _context.DetailsAsker.SingleOrDefault(x => x.UserId == id);
                _context.DetailsAsker.Remove(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool AddDetailsAsker(DetailsAsker u)
        {

            try
            {
                _context.DetailsAsker.Add(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateDetailsAsker(int id, DetailsAsker u)
        {
            try
            {
                DetailsAsker currentDetailsAsker = _context.DetailsAsker.SingleOrDefault(x => x.UserId == id);

                _context.Entry(currentDetailsAsker).CurrentValues.SetValues(u);
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
