using System;
using System.Collections.Generic;
using System.Text;

namespace DTOHazinu.Models
{
   public class EmployeesDTO
    {
        public int? IdUser { get; set; }
        public string Password { get; set; }
        public int? JobId { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public string VerificationCode { get; set; }

    }
}
