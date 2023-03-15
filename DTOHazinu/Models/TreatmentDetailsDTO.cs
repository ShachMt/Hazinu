using System;
using System.Collections.Generic;
using System.Text;

namespace DTOHazinu.Models
{
  public  class TreatmentDetailsDTO
    {
        public int ApplyId { get; set; }
        public int? TherapistId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? DateNow { get; set; }
        public int? TaskId { get; set; }
        public string Documentation { get; set; }
        public int? NextStepId { get; set; }
        public DateTime? DateTask { get; set; }
        public int Id { get; set; }
        public int? NextEmployeesId { get; set; }
        public string NextDocumentation { get; set; }

        public virtual EmployeesDTO NextEmployees { get; set; }
        public virtual ApplyDTO Apply { get; set; }
        public virtual TaskDTO NextStep { get; set; }
        public virtual StatusDTO Status { get; set; }
        public virtual TaskDTO Task { get; set; }
        public virtual EmployeesDTO Therapist { get; set; }

    }
}
