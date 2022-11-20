using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class Jobs
    {
        public Jobs()
        {
            Employees = new HashSet<Employees>();
            StffDetails = new HashSet<StffDetails>();
        }

        public int Id { get; set; }
        public string Details { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<StffDetails> StffDetails { get; set; }
    }
}
