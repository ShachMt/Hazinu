using System;
using System.Collections.Generic;
using System.Text;

namespace DTOHazinu.Models
{
   public class FamilyDTO
    {
        public int Id { get; set; }
        public string ParentStatus { get; set; }
        public string FamilyDetails { get; set; }
        public int? ChildrenNumber { get; set; }
    }
}
