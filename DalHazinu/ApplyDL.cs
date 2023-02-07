using DalHazinu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
   public class ApplyDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();
        static String removeSpace(String str)
        {

            str = str.Replace(" ", "");
            return str;
        }

        //החזרת כלל הפניות כולל הפרטים של הממלא המטופל וסיבת הפניה
        public List<Apply> GetAllApplies()
        {
            try
            {
                List<Apply> applies =
                    _context.Apply.Include(x => x.Employees).ThenInclude(x => x.IdUserNavigation).
                Include(x => x.Employees).ThenInclude(x => x.Job).
                Include(x => x.Asker).Include(x => x.ApplyCaused).ToList();
                foreach (var item in applies)
                {
                    if (item.Employees != null)
                    {
                        if (item.Employees.IdUserNavigation != null)
                        {
                            if (item.Employees.IdUserNavigation.FirstName != null) { 
                                item.Employees.IdUserNavigation.FirstName= removeSpace(item.Employees.IdUserNavigation.FirstName); }
                            if (item.Employees.IdUserNavigation.LastName != null)
                            { item.Employees.IdUserNavigation.LastName= removeSpace(item.Employees.IdUserNavigation.LastName); }
                            if (item.Employees.IdUserNavigation.Phone != null)
                            { item.Employees.IdUserNavigation.Phone=removeSpace(item.Employees.IdUserNavigation.Phone); }
                        }
                    }
                    if (item.ApplyCaused != null)
                    {
                        if (item.ApplyCaused.Details != null) { item.ApplyCaused.Details=removeSpace(item.ApplyCaused.Details); }
                        if (item.ApplyCaused.Descreption != null) { item.ApplyCaused.Descreption= removeSpace(item.ApplyCaused.Descreption); }
                    }
                    if (item.Asker != null)
                    {
                        if (item.Asker.FirstName != null) { item.Asker.FirstName= removeSpace(item.Asker.FirstName); }
                        if (item.Asker.LastName != null) { item.Asker.LastName= removeSpace(item.Asker.LastName); }
                        if (item.Asker.Phone != null) { item.Asker.Phone=removeSpace(item.Asker.Phone); }
                    }
                }
                return applies;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //החזרת פניות לפי טלפון הפונה-בשביל המזכיר 
        public List<Apply> GetAllAppliesByPhone(string phon)
        {
            try
            {
                List<Apply> applies = GetAllApplies();
                List<Apply> appliesL=new List<Apply>();
                foreach (var item in applies)
                {
                    if (item.Asker.Phone.Equals(phon))
                        appliesL.Add(item);
                }
                return appliesL;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       

        //החזרת פניות לפי אימייל הפעיל
        public List<Apply> GetAllAppliesUserEmployee(string email)
        {
            try
            {
                List<Apply> applies = GetAllApplies().Where(x => x.Employees.Email == email).ToList();
                return applies;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //מחיקת פניה
        public bool DeleteApply(int id)
        {
            try
            {
                Apply u = _context.Apply.SingleOrDefault(x => x.Id == id);
                _context.Apply.Remove(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //ומחזיר מספר פניה הוספת פניה
        public int AddApply(Apply u)
        {

            try
            {
                _context.Apply.Add(u);
                _context.SaveChanges();

                return u.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //עדכון פניה
        public bool UpdateApply(int id, Apply u)
        {
            try
            {
                Apply currentApply = _context.Apply.SingleOrDefault(x => x.Id == id);

                _context.Entry(currentApply).CurrentValues.SetValues(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }






        //פונקציית שליפת פנייה אחת עם כל הנתונים
        //פונקציית שליפה של כל הפניות עם כל הנתונים
        //פונקצייה שמקבלת שימה של פניות ומחיזרה נתונים מלאים-GetAlldetailsAppliesByList
        //public List<Apply> GetAlldetailsAppliesByList(List<Apply> appleis)
        //{

        //}
        //החזרת פניות לפי סטטוס ואימייל פעיל
        public List<Apply> GetAllApplyByStatusEmailTerapist(int status, string email)
        {
            try
            {
                //מחזיר את כל הרשימה של הפניות הקיימות
                List<Apply> lstApplies = GetAllAppliesUserEmployee(email);
                //רשימה חדשה אשר תשמור בתוכה את הפניות שעומדות על הסטטוס המתקבל
                List<Apply> lstAppliesNew = new List<Apply>();
                TreatmentDetailsDL treatmentDetailsDL = new TreatmentDetailsDL();
                //מעבר על כל הפניות הקיימות והכנסה לרשימה החדשה במידה שתענה על הדרישה
                foreach (var item in lstApplies)
                {
                    if (treatmentDetailsDL.GetTreatmentDetailsByApplyState(item.Id)?.StatusId == status)
                        lstAppliesNew.Add(item);
                }
                return lstAppliesNew;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //החזרת פניות לפי ססטוס- בשביל מנהל הפניות לסיווג ובשביל האינטייק 
        public List<Apply> GetAllApplyByStatus(int status)
        {
            try
            {
                //מחזיר את כל הרשימה של הפניות הקיימות
                List<Apply> lstApplies = GetAllApplies();
                //רשימה חדשה אשר תשמור בתוכה את הפניות שעומדות על הסטטוס המתקבל
                List<Apply> lstAppliesNew = new List<Apply>();
                TreatmentDetailsDL treatmentDetailsDL = new TreatmentDetailsDL();
                //מעבר על כל הפניות הקיימות והכנסה לרשימה החדשה במידה שתענה על הדרישה
                foreach (var item in lstApplies)
                {
                    if (treatmentDetailsDL.GetTreatmentDetailsByApplyState(item.Id)?.StatusId == status)
                        lstAppliesNew.Add(item);
                }
                return lstAppliesNew;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public List<Apply> GetAllAppliesByStatus(int status)
        //{
        //    try
        //    {
        //        //יצירת רשימה חדשה של פניות
        //        //List<Apply> l=new List<Apply>() ;
        //        //יצירת רשימת פרטי פניות
        //        //List<TreatmentDetails> lt= _context.TreatmentDetails.ToList();
        //        ////יצירת משתנה פרטי פניה בודדת
        //        //TreatmentDetails t;
        //        ////הכנסת כל הפניות לרשימה מסוג פרטי פניה לפי הסטטוס המתקבל
        //        //lt = lt.FindAll(x => x.StatusId == status);
        //        //foreach(var item in lt)
        //        //{
        //        //    _context.User.Include("TreatmentDetails").ToList();

        //        //    Apply c = _context.Apply.Single(x=>x.Id==item.ApplyId);
        //        //    if (c != null)
        //        //        l.Add(c);
        //        //}
        //        //return GetAlldetailsAppliesByList(l);
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


        //public List<Apply> GetAllAppliesByStatusEndPass(int status, string email, string pass)
        //{
        //    try
        //    {
        //        List<Apply> AllAppliesUserEmployee = this.GetAllAppliesUserEmployee(email, pass);
        //        TreatmentDetails t= _context.TreatmentDetails.SingleOrDefault(x => x.ApplyId == );

        //        Employees userEmployees = _context.Employees.SingleOrDefault(x => x.Email == email);
        //        User userFromEmployees = _context.User.SingleOrDefault(x => x.Id == userEmployees.IdUser);

        //        List<Apply> allApplies = _context.Apply.Where(x => x.UserId == userFromEmployees.Id).ToList();
        //        return _context.Apply.ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


        //עדכון סטטוס פניה


        //עדכון מטפל עכשוי 

    }
}
