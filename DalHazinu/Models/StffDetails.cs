using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class StffDetails
    {
        public int? UserId { get; set; }
        public int? EducationId { get; set; }
        public int? JobId { get; set; }
        public string Phone { get; set; }
        public string AnotherPhone { get; set; }
        public int Id { get; set; }

        public virtual EducationalInstitution Education { get; set; }
        public virtual Jobs Job { get; set; }
        public virtual User User { get; set; }
    }
}
