using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class DetailsAsker
    {
        public DetailsAsker()
        {
            PatientDetails = new HashSet<PatientDetails>();
        }

        public int? UserId { get; set; }
        public string Affinity { get; set; }
        public string ReferredBy { get; set; }
        public int? IdResone { get; set; }
        public int Id { get; set; }

        public virtual TheCauseReferral IdResoneNavigation { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PatientDetails> PatientDetails { get; set; }
    }
}
