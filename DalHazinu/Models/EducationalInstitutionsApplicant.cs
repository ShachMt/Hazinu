using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class EducationalInstitutionsApplicant
    {
        public int? UserId { get; set; }
        public int? InstitutionId { get; set; }
        public string Status { get; set; }
        public string Details { get; set; }

        public virtual EducationalInstitution Institution { get; set; }
        public virtual User User { get; set; }
    }
}
