using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class Terapist
    {
        public Terapist()
        {
            PatientDetails = new HashSet<PatientDetails>();
        }

        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string City { get; set; }
        public string Job { get; set; }
        public string Remarks { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<PatientDetails> PatientDetails { get; set; }
    }
}
