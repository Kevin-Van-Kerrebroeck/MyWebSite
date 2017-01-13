using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebSite.Models
{
    public class CreateSkillModelView
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Verplicht veld."), Display(Name = "Skill")]
        [StringLength(50, ErrorMessage = "Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string SkillName { get; set; }

        [Required(ErrorMessage = "Verplicht veld."), Display(Name = "Score nummer")]
        [Range(1, 6, ErrorMessage = "Kies een getal tussen 1 en 6.")]
        public int RatingNumber { get; set; }

        public SelectList Categories { get; set; }

        [Required(ErrorMessage = "Verplicht veld."), Display(Name = "Skill Categorie")]
        public int SkillCategoryId { get; set; }
    }
}