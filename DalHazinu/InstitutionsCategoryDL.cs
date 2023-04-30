using DalHazinu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
    public class InstitutionsCategoryDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();

        //סיווג קטגוריות מוסדות לימוד לפי מין
        public List<InstitutionsCategory> GetAllInstitutionsCategoriesByGender(string gender,int age)
        {
            try
            {
                List<InstitutionsCategory> l= _context.InstitutionsCategory.Include(x => x.AgeRangeNavigation).
                Where(x => x.Gender == gender && x.AgeRangeNavigation.From <= age && x.AgeRangeNavigation.To >= age).
                OrderBy(x => x.AgeRange)
                .ToList();
                return l;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        //החזרת רשימת קטגוריות החל וכולל איידי טווח הגילאיים שהתקבל 
        public List<InstitutionsCategory> GetAllInstitutionsCategoriesByAgeGange(int id)
        {
            try
            {

                return _context.InstitutionsCategory.Include(x => x.AgeRangeNavigation).Where(x=>x.AgeRangeNavigation.Id>=id).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //החזרת כל הקטגוריות

        public List<InstitutionsCategory> GetAllInstitutionsCategories()
        {
            try
            {

                return _context.InstitutionsCategory.Include(x=>x.AgeRangeNavigation).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //הוספת קטגוריית מוסד לימוד
        public int AddInstitutionsCategory(InstitutionsCategory u)
        {

            try
            {
                _context.InstitutionsCategory.Add(u);
                _context.SaveChanges();
                return u.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //מחיקת קטגוריה
        public bool DeleteInstitutionsCategory(int id)
        {
            try
            {
                InstitutionsCategory u = _context.InstitutionsCategory.SingleOrDefault(x => x.Id == id);
                _context.InstitutionsCategory.Remove(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //ועדכון קטגוריה
        public bool UpdateInstitutionsCategory(int id, InstitutionsCategory u)
        {
            try
            {
                InstitutionsCategory currentInstitutionsCategory = _context.InstitutionsCategory.SingleOrDefault(x => x.Id == id);

                _context.Entry(currentInstitutionsCategory).CurrentValues.SetValues(u);
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
