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
                Include(x => x.Family).
                Include(x => x.Sector).
                Include(x => x.Therapeutic).ThenInclude(x => x.IdUserNavigation).
                Include(x => x.User).FirstOrDefault(x => x.ApplyId == id);

                if (u != null)
                {
                    if (u.Address != null)
                    {
                        if (u.Address.Neighborhood != null)
                        {
                            u.Address.Neighborhood = removeSpace(u.Address.Neighborhood);
                        }
                        if (u.Address.City != null)
                        {
                            u.Address.City = removeSpace(u.Address.City);
                        }
                        if (u.Address.Street != null)
                        {
                            u.Address.Street = removeSpace(u.Address.Street);
                        }


                    }

                    if (u.Therapeutic != null)
                    {
                        if (u.Therapeutic.IdUserNavigation != null)
                        {

                            if (u.Therapeutic.IdUserNavigation.FirstName != null)
                            {
                                u.Therapeutic.IdUserNavigation.FirstName = removeSpace(u.Therapeutic.IdUserNavigation.FirstName);
                            }
                            if (u.Therapeutic.IdUserNavigation.LastName != null)
                            { u.Therapeutic.IdUserNavigation.LastName = removeSpace(u.Therapeutic.IdUserNavigation.LastName); }
                            if (u.Therapeutic.IdUserNavigation.Phone != null)
                            { u.Therapeutic.IdUserNavigation.Phone = removeSpace(u.Therapeutic.IdUserNavigation.Phone); }
                        }
                    }


                    if (u.User != null)
                    {
                        if (u.User.FirstName != null) { u.User.FirstName = removeSpace(u.User.FirstName); }
                        if (u.User.LastName != null) { u.User.LastName = removeSpace(u.User.LastName); }
                        if (u.User.Phone != null) { u.User.Phone = removeSpace(u.User.Phone); }
                    }

                }
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
                return false;
            }


        }
    }
}
