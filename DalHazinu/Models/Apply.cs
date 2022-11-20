using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class Apply
    {
        public Apply()
        {
            Files = new HashSet<Files>();
            MatureCharacter = new HashSet<MatureCharacter>();
            TreatmentDetails = new HashSet<TreatmentDetails>();
        }

        public int Id { get; set; }
        public DateTime? DateNow { get; set; }
        public int? UserId { get; set; }
        public int? AskerId { get; set; }
        public int? ApplyCausedId { get; set; }

        public virtual TheCauseReferral ApplyCaused { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Files> Files { get; set; }
        public virtual ICollection<MatureCharacter> MatureCharacter { get; set; }
        public virtual ICollection<TreatmentDetails> TreatmentDetails { get; set; }
    }
}
