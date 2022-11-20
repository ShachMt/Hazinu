using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class InstitutionsCategory
    {
        public InstitutionsCategory()
        {
            EducationalInstitution = new HashSet<EducationalInstitution>();
        }

        public int Id { get; set; }
        public string DetailsCategory { get; set; }
        public string Gender { get; set; }
        public string AgeRange { get; set; }

        public virtual ICollection<EducationalInstitution> EducationalInstitution { get; set; }
    }
}
