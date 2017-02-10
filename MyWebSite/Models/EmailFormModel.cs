using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebSite.Models
{
    public class EmailFormModel
    {
        [Required, Display(Name="Your name")]
        [StringLength(50, ErrorMessage = "Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string FromName { get; set; }

        [Required, Display(Name = "Your email"), EmailAddress]
        [StringLength(50, ErrorMessage = "E mail bevat te veel characters, max 50 characters toegestaan.")]
        public string FromEmail { get; set; }

        [Required, Display(Name = "Your message")]
        [StringLength(500, ErrorMessage = "boodschap bevat te veel characters, max 500 characters toegestaan.")]
        public string Message { get; set; }
    }
}