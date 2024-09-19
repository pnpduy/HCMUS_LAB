﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjectWeek02.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}