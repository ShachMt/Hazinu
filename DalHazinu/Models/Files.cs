using System;
using System.Collections.Generic;

namespace DalHazinu.Models
{
    public partial class Files
    {
        public int? IdApply { get; set; }
        public string FilesName { get; set; }
        public string Url { get; set; }
        public int Id { get; set; }

        public virtual Apply IdApplyNavigation { get; set; }
    }
}
