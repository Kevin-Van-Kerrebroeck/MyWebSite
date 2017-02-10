using MyWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyWebSite.Classes
{
    public class ViewModelBuilder
    {


        //*******Properties

        //*******Fields

        //*******Constructors

        //*******Public Methods


        /// <summary>
        /// GetVullView, collects all data for a full view
        /// </summary>
        /// <param name="db">Expects a ApplicationDbContext</param>
        /// <returns>Returns a instance of the CvModelView Model</returns>
        public CvModelView GetFullView(ApplicationDbContext db)
        {
            if (db == null)
            {
                throw new Exception("Param \"db\" Cannot be null or empty.");
            }
            return GetAllData(db);
        }

        //*******Private Methods


        //Collect all data into one model to pass to view(s)
        /// <summary>
        /// Collects all data from database. 
        /// </summary>
        /// <returns>Returns a instance of CvModelView</returns>
        private CvModelView GetAllData(ApplicationDbContext db)
        {

            CvModelView View = new CvModelView()
            {
                Categories = db.Categories.ToList(),
                Educations = db.Educations.OrderByDescending(e => e.EndDate.Year).ToList(),
                Jobs = db.Jobs.OrderByDescending(j => j.StartDate.Year).ToList(),
                Skills = db.Skills.Include(s => s.SkillCategory).OrderByDescending(s => s.SkillName).ToList()
            };

            return View;
        }



    }
}