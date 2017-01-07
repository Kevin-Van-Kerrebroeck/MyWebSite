using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebSite.Models
{
    public class CvModelView
    {
        public List<Skill> Skills { get; set; }
        public List<Category> Categories { get; set; }
        public List<Education> Educations { get; set; }
        public List<Job> Jobs { get; set; }

        //Add constructor to instantiate empty lists?
        /// <summary>
        /// Creates a new instance of the object with empty lists.
        /// </summary>
        public CvModelView()
        {

        }
    }
}