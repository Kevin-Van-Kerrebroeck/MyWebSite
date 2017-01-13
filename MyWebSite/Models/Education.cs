using System;
using System.ComponentModel.DataAnnotations;

namespace MyWebSite.Models
{
    public class Education 
    {
        //EF requirment: id for database
        [Key]
        public int ID { get; set; }

        [Display(Name = "Start Datum")]
        [Required(ErrorMessage = "Verplicht veld.")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Eind Datum")]
        [Required(ErrorMessage = "Verplicht veld.")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Naam van de School")]
        [Required(ErrorMessage = "Verplicht veld.")]
        [StringLength(50, ErrorMessage = "Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string SchoolName { get; set; }

        [Display(Name = "Cursus Naam")]
        [Required(ErrorMessage = "Verplicht veld.")]
        [StringLength(50, ErrorMessage = "Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string TrajectName { get; set; }

        [Display(Name = "Behaald Diploma")]
        [Required(ErrorMessage = "Verplicht veld.")]
        [StringLength(50, ErrorMessage = "Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string ObtainedDegree { get; set; }


        //EF requirment: empty constructor to fill up objects when retrieving from database
        public Education()
        {

        }

    }
}