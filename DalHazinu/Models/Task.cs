using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class Task
    {
        public Task()
        {
            TreatmentDetails = new HashSet<TreatmentDetails>();
        }

        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Descreption { get; set; }

        public virtual ICollection<TreatmentDetails> TreatmentDetails { get; set; }
    }
}
