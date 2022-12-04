using DalHazinu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
   public class ApplyDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();

        //החזרת כלל הפניות
        public List<Apply> GetAllApplies()
        {
            try
            {
                Apply a = _context.Apply.SingleOrDefault(x => x.Id == 1);
                Console.WriteLine(" " + a.ToString());
                return _context.Apply.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //החזרת פניות לפי טלפון הפונה-בשביל המזכיר 
        public List<Apply> GetAllAppliesByPhonePone(string phon)
        {
            try
            {
                User userAsker = _context.User.SingleOrDefault(x => x.Phone == phon);
                List<Apply> allApplies = _context.Apply.Where(x => x.AskerId == userAsker.Id).ToList(); 
                return allApplies;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //החזרת פניות לפי שם משתמש/ הפעיל
        public List<Apply> GetAllAppliesUserEmployee(string email,string pass)
        {
            try
            {
                Employees userEmployees = _context.Employees.SingleOrDefault(x => x.Email == email);
                User userFromEmployees = _context.User.SingleOrDefault(x => x.Id == userEmployees.IdUser);

                List<Apply> allApplies = _context.Apply.Where(x => x.UserId == userFromEmployees.Id).ToList();
                return allApplies;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //פונקציית שליפת פנייה אחת עם כל הנתונים
        //פונקציית שליפה של כל הפניות עם כל הנתונים
        //פונקצייה שמקבלת שימה של פניות ומחיזרה נתונים מלאים-GetAlldetailsAppliesByList
        //public List<Apply> GetAlldetailsAppliesByList(List<Apply> appleis)
        //{
            
        //}
        //החזרת פניות לפי סטטוס 
        public List<Apply> GetAllAppliesByStatus(int status)
        {


            try
            {
                Apply a = _context.Apply.SingleOrDefault(x => x.Id == 1);
                Console.WriteLine(" " + a.ToString());
                List<Apply> l=new List<Apply>() ;

                List<TreatmentDetails> lt= _context.TreatmentDetails.ToList();
                TreatmentDetails t;
                lt = lt.FindAll(x => x.StatusId == status);
                foreach(var item in lt)
                {
                    Apply c = _context.Apply.Single(x=>x.Id==item.ApplyId);
                    if (c != null)
                        l.Add(c);
                }
                //return GetAlldetailsAppliesByList(l);
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


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
