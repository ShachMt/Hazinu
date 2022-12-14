using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class MatureCharacter
    {
        public MatureCharacter()
        {
            PatientDetails = new HashSet<PatientDetails>();
        }

        public int? IdApplicant { get; set; }
        public int? IdMature { get; set; }
        public string Framwork { get; set; }
        public bool? PermissionContact { get; set; }
        public int Id { get; set; }

        public virtual Apply IdApplicantNavigation { get; set; }
        public virtual User IdMatureNavigation { get; set; }
        public virtual ICollection<PatientDetails> PatientDetails { get; set; }
    }
}
