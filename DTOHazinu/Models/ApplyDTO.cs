﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DTOHazinu.Models
{
   public class ApplyDTO
    {
        public int Id { get; set; }
        public DateTime? DateNow { get; set; }
        public int? UserId { get; set; }
        public int? AskerId { get; set; }
        public int? ApplyCausedId { get; set; }
    }
}