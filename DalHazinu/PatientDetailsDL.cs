using DalHazinu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
  public  class PatientDetailsDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();

        //החזרת פרטי הפונים
        public List<PatientDetails> GetAllPatientDetails()
        {
            try
            {
                return _context.PatientDetails.
                Include(x => x.Apply).
                Include(x => x.FillEmloyees).
                Include(x => x.IdDetailsAskerNavigation).
                Include(x => x.MatureCharacter).
                Include(x=>x.Address).
                Include(x=>x.Family).
                Include(x=>x.Sector).
                Include(x=>x.Therapeutic).
                Include(x=>x.User).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static String removeSpace(String str)
        {

            str = str.Replace(" ", "");
            return str;
        }
        public PatientDetails GetPatientDetailsByApplyId(int id)
        {
            try
            {
            PatientDetails u = _context.PatientDetails.Include(x => x.Address).
                Include(x => x.Apply).
                Include(x => x.FillEmloyees).ThenInclude(x=>x.IdUserNavigation).
                Include(x => x.IdDetailsAskerNavigation).ThenInclude(x => x.User).
                Include(x => x.MatureCharacter).ThenInclude(x=>x.IdMatureNavigation).
                Include(x => x.Family).
                Include(x => x.Sector).
                Include(x => x.Therapeutic).
                Include(x => x.User).FirstOrDefault(x => x.ApplyId == id);
                return u;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeletePatientDetails(int id)
        {
            try
            {
                PatientDetails u = _context.PatientDetails.SingleOrDefault(x => x.Id == id);
                _context.PatientDetails.Remove(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int AddPatientDetails(PatientDetails u)
        {

            try
            {
                _context.PatientDetails.Add(u);
                _context.SaveChanges();
                return u.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdatePatientDetails(int id, PatientDetails u)
        {
            try
            {
                PatientDetails currentPatientDetails = _context.PatientDetails.SingleOrDefault(x => x.Id == id);
                _context.Entry(currentPatientDetails).CurrentValues.SetValues(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }


        }
    }
}
