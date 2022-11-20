﻿using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class DetailsAsker
    {
        public int? UserId { get; set; }
        public string Affinity { get; set; }
        public string ReferredBy { get; set; }
        public int? IdResone { get; set; }

        public virtual TheCauseReferral IdResoneNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
