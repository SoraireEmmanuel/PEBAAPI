﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace PEBA.bl.DTOs
{
    public class LoginDTO
    {
        [Required]
        public string Matricula { get; set; }
        [Required]
        public string PasswordCuenta { get; set; }
    }
}
