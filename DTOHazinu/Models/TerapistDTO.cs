using System;
using System.Collections.Generic;
using System.Text;

namespace DTOHazinu.Models
{
   public class TerapistDTO
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string City { get; set; }
        public string Job { get; set; }
        public string Remarks { get; set; }
        public virtual UserDTO IdUserNavigation { get; set; }
    }
}
