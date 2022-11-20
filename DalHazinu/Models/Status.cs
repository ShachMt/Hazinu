using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class Status
    {
        public Status()
        {
            TreatmentDetails = new HashSet<TreatmentDetails>();
        }

        public int Id { get; set; }
        public string Details { get; set; }

        public virtual ICollection<TreatmentDetails> TreatmentDetails { get; set; }
    }
}
