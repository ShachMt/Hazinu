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

    }
}
