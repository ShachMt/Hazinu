using System;
using System.Collections.Generic;
using System.Text;

namespace DTOHazinu.Models
{
   public class MatureCharacterDTO
    {
        public int? IdApplicant { get; set; }
        public int? IdMature { get; set; }
        public string Framwork { get; set; }
        public bool? PermissionContact { get; set; }
        public int Id { get; set; }

        public virtual ApplyDTO IdApplicantNavigation { get; set; }
        public virtual UserDTO IdMatureNavigation { get; set; }


    }
}
