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
        public string IsContact { get; set; }
        public int Id { get; set; }
        public int? TherapeuticId { get; set; }
        public bool? IsStillTerapist { get; set; }
        public int? MatureCharacterId { get; set; }
        public int? ApplyId { get; set; }
        public DateTime? DateNow { get; set; }

        public virtual ApplyDTO Apply { get; set; }

        public virtual AddressDTO Address { get; set; }
        public virtual FamilyDTO Family { get; set; }
        public virtual MatureCharacterDTO MatureCharacter { get; set; }
        public virtual SectorDTO Sector { get; set; }
        public virtual EmployeesDTO Therapeutic { get; set; }
        public virtual UserDTO User { get; set; }


    }
}
