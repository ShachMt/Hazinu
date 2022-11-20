using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class Address
    {
        public Address()
        {
            EducationalInstitution = new HashSet<EducationalInstitution>();
            PatientDetails = new HashSet<PatientDetails>();
        }

        public int Id { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public int? NumberHome { get; set; }
        public int? NumberApartment { get; set; }

        public virtual ICollection<EducationalInstitution> EducationalInstitution { get; set; }
        public virtual ICollection<PatientDetails> PatientDetails { get; set; }
    }
}
