using System;
using System.Collections.Generic;
using System.Text;

namespace DTOHazinu.Models
{
   public class EducationalInstitutionsApplicantDTO
    {
        public int? UserId { get; set; }
        public int? InstitutionId { get; set; }
        public string Status { get; set; }
        public string Details { get; set; }
        public int Id { get; set; }

    }
}
