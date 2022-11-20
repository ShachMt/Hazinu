﻿using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class TreatmentDetails
    {
        public int? ApplyId { get; set; }
        public int? TherapistId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? DateNow { get; set; }
        public int? TaskId { get; set; }
        public string Documentation { get; set; }
        public int? NextStepId { get; set; }
        public DateTime? DateTask { get; set; }

        public virtual Apply Apply { get; set; }
        public virtual Status Status { get; set; }
        public virtual Task StatusNavigation { get; set; }
        public virtual User Therapist { get; set; }
    }
}