using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class Task
    {
        public Task()
        {
            TreatmentDetailsNextStep = new HashSet<TreatmentDetails>();
            TreatmentDetailsTask = new HashSet<TreatmentDetails>();
        }

        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Descreption { get; set; }

        public virtual ICollection<TreatmentDetails> TreatmentDetailsNextStep { get; set; }
        public virtual ICollection<TreatmentDetails> TreatmentDetailsTask { get; set; }
    }
}
