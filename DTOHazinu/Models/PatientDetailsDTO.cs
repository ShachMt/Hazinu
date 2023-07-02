using System;
using System.Collections.Generic;
using System.Text;

namespace DTOHazinu.Models
{
   public class PatientDetailsDTO
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
        public int Id { get; set; }
        public int? TerapistId { get; set; }
        public int? MatureCharacterId { get; set; }
        public int? ApplyId { get; set; }
        public DateTime? DateNow { get; set; }
        public int? IdDetailsAsker { get; set; }
        public int? FillEmloyeesId { get; set; }
        public string DetailsAnotherSector { get; set; }
        public string ParentPhone { get; set; }
        public int? AgeFillApply { get; set; }
        public string EnotherParentPhone { get; set; }
        public string Social { get; set; }
        public string Emotional { get; set; }
        public string Diagnoses { get; set; }
        public string Studies { get; set; }
        public bool? PermissionContactM { get; set; }
        public bool? PermissionContactT { get; set; }
        public string Framework { get; set; }
        public bool? IsStillTerapist { get; set; }
        public bool? PermissionContactTm { get; set; }

        public virtual AddressDTO Address { get; set; }
        public virtual ApplyDTO Apply { get; set; }
        public virtual FamilyDTO Family { get; set; }
        public virtual EmployeesDTO FillEmloyees { get; set; }
        public virtual MatureCharacterDTO MatureCharacter { get; set; }
        public virtual SectorDTO Sector { get; set; }
        public virtual TerapistDTO Terapist { get; set; }
        public virtual UserDTO User { get; set; }
        public virtual DetailsAskerDTO IdDetailsAskerNavigation { get; set; }

    }
}
