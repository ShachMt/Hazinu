using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class EducationalInstitution
    {
        public EducationalInstitution()
        {
            EducationalInstitutionsApplicant = new HashSet<EducationalInstitutionsApplicant>();
            StffDetails = new HashSet<StffDetails>();
        }

        public int Id { get; set; }
        public int? IdCategory { get; set; }
        public int? AddressId { get; set; }
        public string InstitutionName { get; set; }
        public string EnotherName { get; set; }
        public int? SectorId { get; set; }
        public string Level { get; set; }
        public string EducationKind { get; set; }
        public bool? IsExterny { get; set; }
        public int? IdStyle { get; set; }
        public int? NumStudent { get; set; }

        public virtual Address Address { get; set; }
        public virtual InstitutionsCategory IdCategoryNavigation { get; set; }
        public virtual StylesInstitution IdStyleNavigation { get; set; }
        public virtual Sector Sector { get; set; }
        public virtual ICollection<EducationalInstitutionsApplicant> EducationalInstitutionsApplicant { get; set; }
        public virtual ICollection<StffDetails> StffDetails { get; set; }
    }
}
