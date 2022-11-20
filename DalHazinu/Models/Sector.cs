using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class Sector
    {
        public Sector()
        {
            EducationalInstitution = new HashSet<EducationalInstitution>();
            PatientDetails = new HashSet<PatientDetails>();
        }

        public int Id { get; set; }
        public string DetailsSector { get; set; }

        public virtual ICollection<EducationalInstitution> EducationalInstitution { get; set; }
        public virtual ICollection<PatientDetails> PatientDetails { get; set; }
    }
}
