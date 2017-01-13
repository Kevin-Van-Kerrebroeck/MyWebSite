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

        [Display(Name = "Start Datum")]
        [Required(ErrorMessage = "Verplicht veld.")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Eind Datum")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Naam van Bedrijf")]
        [Required(ErrorMessage = "Verplicht veld.")]
        [StringLength(50, ErrorMessage = "Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string CompanyName { get; set; }

        [Display(Name = "Functie")]
        [Required(ErrorMessage = "Verplicht veld.")]
        [StringLength(50, ErrorMessage = "Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string JobFunction { get; set; }

        [Display(Name = "Type Contract")]
        [Required(ErrorMessage = "Verplicht veld.")]
        [StringLength(50, ErrorMessage = "Naam bevat te veel characters, max 50 characters toegestaan.")]
        public string ContractType { get; set; }

        [Display(Name = "Functie Beschrijving")]
        [Required(ErrorMessage = "Verplicht veld.")]
        [StringLength(200, ErrorMessage = "Naam bevat te veel characters, max 200 characters toegestaan.")]
        public string JobDescription { get; set; }

        public Job()
        {

        }
    }
}