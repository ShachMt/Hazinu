using DalHazinu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DalHazinu
{
   public class TreatmentDetailsDL
    {
        HazinuProjectContext _context = new HazinuProjectContext();
        //החזרת שלבי הטיפול לפי מספר פניה
        public List<TreatmentDetails> GetAllTreatmentDetailsByApply(int apply)
        {
            try
            {
                List<TreatmentDetails> treatmentDetails = _context.TreatmentDetails.Where(x => x.ApplyId == apply)
                .Include(x => x.NextStep).Include(x=>x.NextEmployees).ThenInclude(x=>x.IdUserNavigation).
                Include(x => x.Status).Include(x => x.Task).
                Include(x => x.Therapist).ThenInclude(x=>x.IdUserNavigation).OrderBy(x=> x.DateNow).ToList();
                return treatmentDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       ////////////////////////////////////////////////////////////////////////////
      
       //מחזיר את הטיפול האחרון שבוצע בפניה
        public TreatmentDetails GetTreatmentDetailsByApplyState(int ApplyId)
        {
            try
            {
                TreatmentDetails t = GetAllTreatmentDetailsByApply(ApplyId).Where(x => x.ApplyId == ApplyId && x.State == true).FirstOrDefault();
                return t;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



      
        ///////////////////////////////////////////////////////
        //הוספת פירוט לפניה כאשר לוחץ על עדכון נכנס למערכת
        public bool AddTreatmentDetails(TreatmentDetails u)
        {
            try
            {
              
                TreatmentDetails lastTD= GetTreatmentDetailsByApplyState(u.ApplyId);
                if (lastTD != null)
                {
                    lastTD.State = false;
                    UpdateTreatmentDetails(lastTD, lastTD.ApplyId);
                }
                u.State = true;
                
                _context.TreatmentDetails.Add(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //מחיקת שלב טיפול
        public bool DeleteTreatmentDetails(int id)
        {
            try
            {
                TreatmentDetails u = _context.TreatmentDetails.SingleOrDefault(x => x.Id == id);
                _context.TreatmentDetails.Remove(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //עדכון שלב טיפול
        public bool UpdateTreatmentDetails( TreatmentDetails u,int id)
        {
            try
            {
                TreatmentDetails currentTreatmentDetails = _context.TreatmentDetails.SingleOrDefault(x => x.ApplyId == id);
                _context.Entry(currentTreatmentDetails).CurrentValues.SetValues(u);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
        //עדכון מטפל עכשוי-כאשר מעבירים את הפניה למטפל אחר  
        //החזרת פניות לפי התאריך של היום וגם לפי פניה שלא נכנס אליו אפילו פעם 1 -  סטטוס ממתין לביצוע
    }
}
