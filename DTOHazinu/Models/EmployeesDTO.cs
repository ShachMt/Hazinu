﻿using System;
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
        public int Id { get; set; }
        public string VerificationCode { get; set; }
        public bool? LockOutEnabled { get; set; }
        public bool? IsActive { get; set; }

        public virtual UserDTO IdUserNavigation { get; set; }
        public virtual JobsDTO Job { get; set; }

    }
}
