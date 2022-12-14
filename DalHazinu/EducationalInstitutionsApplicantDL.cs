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
                    .Include(x => x.Institution).ToList();
                List<EducationalInstitutionsApplicant> educationalInstitutions = educationalInstitutions1.Where(x => x.UserId == id).ToList();
                return educationalInstitutions;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //החזרת שמות לימודים לפי סטטוס- עבר או הווה
        public List<EducationalInstitution> GetAllNameEducationalInstitution(int id,string status)
        {
            try
            {
                List<EducationalInstitutionsApplicant> educationalInstitutions = GetAllEducationalInstitution(id).Where(x=>x.Status==status).ToList();
                EducationalInstitutionDL ed=new EducationalInstitutionDL();

                List<EducationalInstitution> educationalInstitution = ed.GetAllEducationalInstitution();
                List<EducationalInstitution> e= new List<EducationalInstitution>();
                EducationalInstitution eN;
                foreach (var item in educationalInstitutions)
                {
                    eN = educationalInstitution.SingleOrDefault(x => x.Id == item.InstitutionId);
                    e.Add(eN);
                }
                return e;

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

        public bool AddEducational(EducationalInstitutionsApplicant u)
        {

            try
            {
                _context.EducationalInstitutionsApplicant.Add(u);
                _context.SaveChanges();
                return true;
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
