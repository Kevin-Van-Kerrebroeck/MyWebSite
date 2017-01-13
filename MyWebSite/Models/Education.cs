using System;
using System.ComponentModel.DataAnnotations;

namespace MyWebSite.Models
{
    public class Education 
    {
        //EF requirment: id for database
        [Key]
        public int ID { get; set; }


        [Required(ErrorMessage = "Verplicht veld."), Display(Name = "Start Datum")]
        public DateTime StartDate { get; set; }


        [Required(ErrorMessage = "Verplicht veld."), Display(Name = "Eind Datum")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Verplicht veld."), Display(Name = "Naam van de School")]
        [StringLength(50, ErrorMessage = "Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string SchoolName { get; set; }

        
        [Required(ErrorMessage = "Verplicht veld."), Display(Name = "Cursus Naam")]
        [StringLength(50, ErrorMessage = "Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string TrajectName { get; set; }

        
        [Required(ErrorMessage = "Verplicht veld."), Display(Name = "Behaald Diploma")]
        [StringLength(50, ErrorMessage = "Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string ObtainedDegree { get; set; }


        //EF requirment: empty constructor to fill up objects when retrieving from database
        public Education()
        {

        }

    }
}