using EntityFramework.Metadata.Extensions;
using MyWebSite.Classes;
using MyWebSite.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MyWebSite.Controllers
{
    [Authorize]
    public class AdminController : MyGenericController<CvModelView>
    {


        private ApplicationDbContext db = new ApplicationDbContext();


        // GET: Admin
        public override ActionResult Index()
        {
            ViewModelBuilder builder = new ViewModelBuilder();
            return View(builder.GetFullView(db));
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