using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DTOHazinu.Models
{
   public class EmployeesDTO
    {
        public int? IdUser { get; set; }
        public string Password { get; set; }
        public int? JobId { get; set; }
        public string Email { get; set; }
        [Key]
        public int Id { get; set; }
        public string VerificationCode { get; set; }
        [ForeignKey("IdUser")]
        public virtual UserDTO IdUserNavigation { get; set; }
        [ForeignKey("JobId")]
        public virtual JobsDTO Job { get; set; }

    }
}
