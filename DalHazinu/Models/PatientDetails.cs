using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class PatientDetails
    {
        public int? UserId { get; set; }
        public string Gender { get; set; }
        public string YearBorn { get; set; }
        public string Mounth { get; set; }
        public int? SectorId { get; set; }
        public int? FamilyId { get; set; }
        public int? FamilyPlace { get; set; }
        public int? AddressId { get; set; }
        public bool? IsInstition { get; set; }
        public bool? IsMatureCharacter { get; set; }
        public bool? IsTherapeutic { get; set; }
        public bool? IsContact { get; set; }

        public virtual Address Address { get; set; }
        public virtual Family Family { get; set; }
        public virtual Sector Sector { get; set; }
        public virtual User User { get; set; }
    }
}
