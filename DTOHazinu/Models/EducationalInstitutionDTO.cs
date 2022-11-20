using System;
using System.Collections.Generic;
using System.Text;

namespace DTOHazinu.Models
{
   public class EducationalInstitutionDTO
    {
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
    }
}
