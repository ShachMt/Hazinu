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


    }
}
