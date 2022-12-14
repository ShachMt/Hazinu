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
        public bool AddPatientDetails(PatientDetails u)
        {

            try
            {
                _context.PatientDetails.Add(u);
                _context.SaveChanges();
                return true;
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
