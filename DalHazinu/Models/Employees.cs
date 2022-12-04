using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class Employees
    {
        public Employees()
        {
            Apply = new HashSet<Apply>();
            TreatmentDetails = new HashSet<TreatmentDetails>();
        }

        public int? IdUser { get; set; }
        public string Password { get; set; }
        public int? JobId { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual Jobs Job { get; set; }
        public virtual ICollection<Apply> Apply { get; set; }
        public virtual ICollection<TreatmentDetails> TreatmentDetails { get; set; }
    }
}
