using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebSite.Models
{
    public class Skill
    {
        //EF requirment: ID for database
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Verplicht veld.")]
        [StringLength(50,ErrorMessage ="Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string SkillName { get; set; }

        [Required(ErrorMessage = "Verplicht veld.")]
        [Range(1,6,ErrorMessage ="Kies een getal tussen 1 en 6.")]
        public int RatingNumber { get; set; }

        [Required(ErrorMessage = "Verplicht veld.")]
        public Category SkillCategory { get; set; }


        //EF requirment: empty constructor for building objects when retrieving from database
        public Skill()
        {

        }
    }
}