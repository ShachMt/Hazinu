using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class User
    {
        public User()
        {
            Apply = new HashSet<Apply>();
            DetailsAsker = new HashSet<DetailsAsker>();
            EducationalInstitutionsApplicant = new HashSet<EducationalInstitutionsApplicant>();
            Employees = new HashSet<Employees>();
            MatureCharacter = new HashSet<MatureCharacter>();
            PatientDetailsTherapeutic = new HashSet<PatientDetails>();
            PatientDetailsUser = new HashSet<PatientDetails>();
            StffDetails = new HashSet<StffDetails>();
        }

        public int Id { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Apply> Apply { get; set; }
        public virtual ICollection<DetailsAsker> DetailsAsker { get; set; }
        public virtual ICollection<EducationalInstitutionsApplicant> EducationalInstitutionsApplicant { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<MatureCharacter> MatureCharacter { get; set; }
        public virtual ICollection<PatientDetails> PatientDetailsTherapeutic { get; set; }
        public virtual ICollection<PatientDetails> PatientDetailsUser { get; set; }
        public virtual ICollection<StffDetails> StffDetails { get; set; }
    }
}
