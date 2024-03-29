﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DTOHazinu.Models
{
   public class ApplyDTO
    {
        public int Id { get; set; }
        public DateTime? DateNow { get; set; }
        public int? EmployeesId { get; set; }
        public int? AskerId { get; set; }
        public int? ApplyCausedId { get; set; }
        public string LevelUrgency { get; set; }
        public string DetailsCausedRefferal { get; set; }
        public string DetailsAnotherCause { get; set; }
        public bool? IsActive { get; set; }

        public virtual TheCauseReferralDTO ApplyCaused { get; set; }
        public virtual UserDTO Asker { get; set; }
        public virtual EmployeesDTO Employees { get; set; }
    }
}
