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

        //החזרת כלל הפניות כולל הפרטים של הממלא המטופל וסיבת הפניה
        public List<Apply> GetAllApplies()
        {
            try
            {
                List<Apply> applies = _context.Apply.Include(x=>x.Employees).ThenInclude(x=>x.IdUserNavigation).
                Include(x=>x.Employees).ThenInclude(x => x.Job).  
                Include(x=>x.Asker).Include(x => x.ApplyCaused).ToList();

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
                List<Apply> applies = GetAllApplies().Where(x=>x.Asker.Phone==phon).ToList();
                return applies;
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
        //הוספת פניה
        public bool AddApply(Apply u)
        {

            try
            {
                _context.Apply.Add(u);
                _context.SaveChanges();
                return true;
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
        //החזרת פניות לפי סטטוס 

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
