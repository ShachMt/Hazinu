using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class Employees
    {
        public Employees()
        {
            Apply = new HashSet<Apply>();
            PatientDetails = new HashSet<PatientDetails>();
            TreatmentDetailsNextEmployees = new HashSet<TreatmentDetails>();
            TreatmentDetailsTherapist = new HashSet<TreatmentDetails>();
        }

        public int? IdUser { get; set; }
        public string Password { get; set; }
        public int? JobId { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public string VerificationCode { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual Jobs Job { get; set; }
        public virtual ICollection<Apply> Apply { get; set; }
        public virtual ICollection<PatientDetails> PatientDetails { get; set; }
        public virtual ICollection<TreatmentDetails> TreatmentDetailsNextEmployees { get; set; }
        public virtual ICollection<TreatmentDetails> TreatmentDetailsTherapist { get; set; }
    }
}
