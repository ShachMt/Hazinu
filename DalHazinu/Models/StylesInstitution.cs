using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class StylesInstitution
    {
        public StylesInstitution()
        {
            EducationalInstitution = new HashSet<EducationalInstitution>();
        }

        public int Id { get; set; }
        public string StyleDescripion { get; set; }
        public string Details { get; set; }

        public virtual ICollection<EducationalInstitution> EducationalInstitution { get; set; }
    }
}
