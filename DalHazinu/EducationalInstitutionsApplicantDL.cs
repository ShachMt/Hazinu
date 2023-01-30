using DalHazinu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
 public  class EducationalInstitutionsApplicantDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();

        //החזרת רשימת מוסדות לפי היוזר
        public List<EducationalInstitutionsApplicant> GetAllEducationalInstitution(int id)
        {
            try
            {
                List<EducationalInstitutionsApplicant> educationalInstitutions1 = _context.EducationalInstitutionsApplicant
                     .Include(x => x.User)
                    .Include(x => x.Institution).Where(x=>x.UserId==id).ToList();
                return educationalInstitutions1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //החזרת  לימודים לפי סטטוס- עבר או הווה
        public List<EducationalInstitutionsApplicant> GetAllNameEducationalInstitution(int id,string status)
        {
            try
            {
                List<EducationalInstitutionsApplicant> educationalInstitutions = GetAllEducationalInstitution(id).Where(x=>x.Status==status).ToList();
                return educationalInstitutions;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //מחיקת מוסד לימוד 
        public bool DeletEducational(int idEdu)
        {
            try
            {
                EducationalInstitutionsApplicant u = _context.EducationalInstitutionsApplicant.SingleOrDefault(x => x.UserId == idEdu);
                _context.EducationalInstitutionsApplicant.Remove(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        // הוספת מוסד לימוד לפונה

        public int AddEducational(EducationalInstitutionsApplicant u)
        {

            try
            {
                _context.EducationalInstitutionsApplicant.Add(u);
                _context.SaveChanges();
                return u.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //עדכון מוסד לימוד

        public bool UpdateEducational(int id, EducationalInstitutionsApplicant u)
        {
            try
            {
                EducationalInstitutionsApplicant currentEducational = _context.EducationalInstitutionsApplicant.SingleOrDefault(x => x.Id == id);

                _context.Entry(currentEducational).CurrentValues.SetValues(u);
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
