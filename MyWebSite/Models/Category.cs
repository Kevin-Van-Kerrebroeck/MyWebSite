using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebSite.Models
{
    public class Category
    {
        //EF requirment: ID for database
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Verplicht veld.")]
        [StringLength(50, ErrorMessage = "Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string CategoryName { get; set; }


        //EF requirment: empty constructor for building objects when retrieving from database
        public Category()
        {

        }
    }
}