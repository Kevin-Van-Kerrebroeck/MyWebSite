using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyWebSite.Models;
using MyWebSite.Controllers;

namespace MyWebSite.Controllers
{
    [Authorize]
    public class SkillsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Categories
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Admin");
        }

        // GET: Skills/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Skill skill = db.Skills.Find(id);
        //    if (skill == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(skill);
        //}

        //GET: Skills/Create
        public ActionResult Create()
        {
            //Nieuw object
            CreateSkillModelView SkillsView = new CreateSkillModelView();

            //Selectlist voor dropdownmenu maken
            var vCategories = from s in db.Categories select s;
            SkillsView.Categories = new SelectList(vCategories, "Id", "CategoryName");

            //Default waarde van dropdown instellen
            SkillsView.SkillCategoryId = db.Categories.First().Id;

            return View(SkillsView);
        }

        // POST: Skills/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SkillName,RatingNumber,SkillCategoryId")] CreateSkillModelView skill)
        {
            if (ModelState.IsValid)
            {
                Skill vSkill = new Skill()
                {
                    SkillName = skill.SkillName,
                    RatingNumber = skill.RatingNumber,
                    SkillCategory = db.Categories.Find(skill.SkillCategoryId)
                };


                db.Skills.Add(vSkill);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(skill);
        }

        //GET: Skills/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skill skill = db.Skills.Include(s => s.SkillCategory).SingleOrDefault(s => s.Id == id);
            if (skill == null)
            {
                return HttpNotFound();
            }

            CreateSkillModelView vSkill = new CreateSkillModelView();
            vSkill.Id = skill.Id;
            vSkill.SkillName = skill.SkillName;
            vSkill.RatingNumber = skill.RatingNumber;
            vSkill.SkillCategoryId = skill.SkillCategory.Id;
            vSkill.Categories = new SelectList(from s in db.Categories select s, "Id", "CategoryName");


            //{
            //    Id = skill.Id,
            //    SkillName = skill.SkillName,
            //    RatingNumber = skill.RatingNumber,
            //    SkillCategoryId = skill.SkillCategory.Id,
            //    Categories = new SelectList(from s in db.Categories select s, "Id", "CategoryName")
            //};
            return View(vSkill);
        }

        // POST: Skills/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SkillName,RatingNumber,SkillCategoryId")] CreateSkillModelView skill)
        {
            if (ModelState.IsValid)
            {

                Skill vSkill = db.Skills.Include(s => s.SkillCategory).FirstOrDefault(s => s.Id == skill.Id);
                Category vCategory = db.Categories.Find(skill.SkillCategoryId);

                vSkill.SkillCategory = vCategory;
                vSkill.SkillName = skill.SkillName;
                vSkill.RatingNumber = skill.RatingNumber;
          
                db.Entry(vSkill).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(skill);
        }

        //// GET: Skills/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Skill skill = db.Skills.Find(id);
        //    if (skill == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(skill);
        //}

        //// POST: Skills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Skill skill = db.Skills.Find(id);
            db.Skills.Remove(skill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
