using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class AgeRange
    {
        public AgeRange()
        {
            InstitutionsCategory = new HashSet<InstitutionsCategory>();
        }

        public int Id { get; set; }
        public int? From { get; set; }
        public int? To { get; set; }

        public virtual ICollection<InstitutionsCategory> InstitutionsCategory { get; set; }
    }
}
