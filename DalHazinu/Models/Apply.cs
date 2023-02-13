using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class Apply
    {
        public Apply()
        {
            Files = new HashSet<Files>();
            MatureCharacter = new HashSet<MatureCharacter>();
            PatientDetails = new HashSet<PatientDetails>();
            TreatmentDetails = new HashSet<TreatmentDetails>();
        }

        public int Id { get; set; }
        public DateTime? DateNow { get; set; }
        public int? EmployeesId { get; set; }
        public int? AskerId { get; set; }
        public int? ApplyCausedId { get; set; }
        public string LevelUrgency { get; set; }

        public virtual TheCauseReferral ApplyCaused { get; set; }
        public virtual User Asker { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual ICollection<Files> Files { get; set; }
        public virtual ICollection<MatureCharacter> MatureCharacter { get; set; }
        public virtual ICollection<PatientDetails> PatientDetails { get; set; }
        public virtual ICollection<TreatmentDetails> TreatmentDetails { get; set; }
    }
}
