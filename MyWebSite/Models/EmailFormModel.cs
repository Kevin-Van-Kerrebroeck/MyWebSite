﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebSite.Models
{
    public class EmailFormModel
    {
        [Required, Display(Name="Your name")]
        public string FromName { get; set; }
        [Required, Display(Name = "Your email"), EmailAddress]
        public string FromEmail { get; set; }
        [Required, Display(Name = "Your message")]
        public string Message { get; set; }
    }
}