using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class Family
    {
        public Family()
        {
            PatientDetails = new HashSet<PatientDetails>();
        }

        public int Id { get; set; }
        public string ParentStatus { get; set; }
        public string FamilyDetails { get; set; }
        public int? ChildrenNumber { get; set; }

        public virtual ICollection<PatientDetails> PatientDetails { get; set; }
    }
}
