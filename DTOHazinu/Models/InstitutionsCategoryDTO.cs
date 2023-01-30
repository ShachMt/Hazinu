using System;
using System.Collections.Generic;
using System.Text;

namespace DTOHazinu.Models
{
  public  class InstitutionsCategoryDTO
    {
        public int Id { get; set; }
        public string DetailsCategory { get; set; }
        public string Gender { get; set; }
        public int AgeRange { get; set; }
        public virtual AgeRangeDTO AgeRangeNavigation { get; set; }

    }
}
