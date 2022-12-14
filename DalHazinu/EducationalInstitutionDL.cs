using DalHazinu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
  public  class EducationalInstitutionDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();

        //החזרת כלל מוסדות הלימוד וכן, עדכון משתנה של טבלאות מקושרות
        public List<EducationalInstitution> GetAllEducationalInstitution()
        {
            try
            {
                List<EducationalInstitution> educationalInstitutions = _context.EducationalInstitution
                    .Include(x => x.IdCategoryNavigation).ThenInclude(x => x.AgeRangeNavigation)
                    .Include(x => x.Address)
                    .Include(x => x.IdStyleNavigation)
                    .Include(x => x.Sector).ToList();
                return educationalInstitutions;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //החזרת מוסדות לימוד לפי לפי טווח גילאים וגיל
        public List<EducationalInstitution> GetAllInstitutionsCategoriesByGender(string gender,int age)
        {
            try
            {
                List<EducationalInstitution> educationalInstitutions = GetAllEducationalInstitution().Where(x=>x.IdCategoryNavigation.Gender==gender&&
                (x.IdCategoryNavigation.AgeRangeNavigation.From <= age&& x.IdCategoryNavigation.AgeRangeNavigation.To>=age)).ToList();
                return educationalInstitutions;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // החזרת מוסדות לימוד לפי עיר וכן, לפי טווח גילאים ומין
        public List<EducationalInstitution> GetAllInstitutionsCategoriesByGenderCity(string gender, int age,string city)
        {
            List<EducationalInstitution> educationalInstitutions = GetAllInstitutionsCategoriesByGender(gender, age).Where(x => x.Address.City == city).ToList();
            return educationalInstitutions;
        }



        public bool DeleteEducationalInstitution(string nameI)
        {
            try
            {
                EducationalInstitution u = _context.EducationalInstitution.SingleOrDefault(x => x.InstitutionName == nameI);
                _context.EducationalInstitution.Remove(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool AddEducationalInstitution(EducationalInstitution u)
        {

            try
            {
                _context.EducationalInstitution.Add(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateEducationalInstitution(string nameI, EducationalInstitution u)
        {
            try
            {
                EducationalInstitution currentEducationalInstitution = _context.EducationalInstitution.SingleOrDefault(x => x.InstitutionName == nameI);

                _context.Entry(currentEducationalInstitution).CurrentValues.SetValues(u);
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
