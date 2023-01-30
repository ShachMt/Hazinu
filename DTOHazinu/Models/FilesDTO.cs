using System;
using System.Collections.Generic;
using System.Text;

namespace DTOHazinu.Models
{
   public class FilesDTO
    {
        public int? IdApply { get; set; }
        public string FilesName { get; set; }
        public string Url { get; set; }
        public int Id { get; set; }
        public virtual ApplyDTO IdApplyNavigation { get; set; }


    }
}
