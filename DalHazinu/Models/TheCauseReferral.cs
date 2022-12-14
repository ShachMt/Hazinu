using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class TheCauseReferral
    {
        public TheCauseReferral()
        {
            Apply = new HashSet<Apply>();
            DetailsAsker = new HashSet<DetailsAsker>();
        }

        public int Id { get; set; }
        public string Descreption { get; set; }
        public string Details { get; set; }

        public virtual ICollection<Apply> Apply { get; set; }
        public virtual ICollection<DetailsAsker> DetailsAsker { get; set; }
    }
}
