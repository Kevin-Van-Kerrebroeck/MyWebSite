using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebSite.Models
{
    public class Job
    {

        //EF requirment: ID for database
        [Key]
        public int ID { get; set; }

        
        [Required(ErrorMessage = "Verplicht veld."), Display(Name = "Start Datum")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Eind Datum")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Verplicht veld."), Display(Name = "Naam van Bedrijf")]
        [StringLength(50, ErrorMessage = "Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Verplicht veld."), Display(Name = "Functie")]
        [StringLength(50, ErrorMessage = "Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string JobFunction { get; set; }

        
        [Required(ErrorMessage = "Verplicht veld."), Display(Name = "Type Contract")]
        [StringLength(50, ErrorMessage = "Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string ContractType { get; set; }

        [Required(ErrorMessage = "Verplicht veld."), Display(Name = "Functie Beschrijving")]
        [StringLength(200, ErrorMessage = "Naam bevat te veel characters, max 200 characters toegestaan.")]
        public string JobDescription { get; set; }

        public Job()
        {

        }
    }
}