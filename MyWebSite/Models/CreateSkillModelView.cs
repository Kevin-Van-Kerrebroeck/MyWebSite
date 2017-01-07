using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebSite.Models
{
    public class CreateSkillModelView
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public int RatingNumber { get; set; }
        public SelectList Categories { get; set; }
        public int SkillCategoryId { get; set; }
    }
}