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
        public string IsContact { get; set; }
        public int Id { get; set; }
        public int? TherapeuticId { get; set; }
        public bool? IsStillTerapist { get; set; }
        public int? MatureCharacterId { get; set; }
        public int? ApplyId { get; set; }
        public DateTime? DateNow { get; set; }
        public int? IdDetailsAsker { get; set; }
        public int? FillEmloyeesId { get; set; }
        public string DetailsAnotherSector { get; set; }
        public string ParentPhone { get; set; }
        public int? AgeFillApply { get; set; }
        public string DatailsJobTerapist { get; set; }

        public virtual Address Address { get; set; }
        public virtual Apply Apply { get; set; }
        public virtual Family Family { get; set; }
        public virtual Employees FillEmloyees { get; set; }
        public virtual DetailsAsker IdDetailsAskerNavigation { get; set; }
        public virtual MatureCharacter MatureCharacter { get; set; }
        public virtual Sector Sector { get; set; }
        public virtual User Therapeutic { get; set; }
        public virtual User User { get; set; }
    }
}
