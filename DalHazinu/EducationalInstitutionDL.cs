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
        public List<EducationalInstitution> GetAllInstitutionsCategories(int idCategory)
        {
            try
            {
                List<EducationalInstitution> educationalInstitutions = GetAllEducationalInstitution().
                    Where(x=>x.IdCategory==idCategory).ToList();
                return educationalInstitutions;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // החזרת מוסדות לימוד לפי עיר וכן, לפי טווח גילאים ומין
        public List<EducationalInstitution> GetAllInstitutionsCategoriesByGenderCity(int idCategory,string city)
        {
            List<EducationalInstitution> educationalInstitutions = GetAllInstitutionsCategories(idCategory).Where(x => x.Address.City == city).ToList();
            return educationalInstitutions;
        }



        public bool DeleteEducationalInstitution(int id)
        {
            try
            {
                EducationalInstitution u = _context.EducationalInstitution.SingleOrDefault(x => x.Id == id);
                _context.EducationalInstitution.Remove(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int AddEducationalInstitution(EducationalInstitution u)
        {

            try
            {
                _context.EducationalInstitution.Add(u);
                _context.SaveChanges();
                return u.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateEducationalInstitution(int id, EducationalInstitution u)
        {
            try
            {
                EducationalInstitution currentEducationalInstitution = _context.EducationalInstitution.SingleOrDefault(x => x.Id == id);

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
