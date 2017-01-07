namespace MyWebSite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<MyWebSite.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MyWebSite.Models.ApplicationDbContext";
        }

        protected override void Seed(MyWebSite.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            #region Categories
            context.Categories.AddOrUpdate(
                c => c.Id,
                new Models.Category { Id = 1, CategoryName = "Languages" },
                new Models.Category { Id = 2, CategoryName = "Programming skills" },
                new Models.Category { Id = 3, CategoryName = "Software skills" }
                );
            #endregion

            #region Educations
            context.Educations.AddOrUpdate(
                e => e.ID,
                new Models.Education
                {
                    ID = 1,
                    StartDate = new DateTime(2012, 09, 01),
                    EndDate = new DateTime(2016, 06, 30),
                    SchoolName = "CVO Panta-Rhei",
                    TrajectName = "Graduaat Informatica - optie Programmeren",
                    ObtainedDegree = "Gegradueerde Informatica"
                },
                new Models.Education
                {
                    ID = 2,
                    StartDate = new DateTime(2012, 09, 01),
                    EndDate = new DateTime(2016, 06, 30),
                    SchoolName = "Pcvo Het Perspectief",
                    TrajectName = "Cursus Java Programmeren",
                    ObtainedDegree = "Deel Certificaten 1 & 2"
                },
                new Models.Education
                {
                    ID = 3,
                    StartDate = new DateTime(2012, 09, 01),
                    EndDate = new DateTime(2016, 06, 30),
                    SchoolName = "CVO Kisp",
                    TrajectName = "Profefesional website with ASP.NET MVC",
                    ObtainedDegree = "Nog te behalen"
                }
                );
            #endregion

            #region Jobs
            context.Jobs.AddOrUpdate(
                j => j.ID,
                new Models.Job
                {
                    ID = 1,
                    StartDate = new DateTime(2011,11,10),
                    EndDate = DateTime.Now,
                    CompanyName = "Imperial Meat Products",
                    ContractType = "Voltijds Onbepaalde Duur",
                    JobFunction = "Operator",
                    JobDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vulputate auctor ipsum sit amet placerat. Praesent condimentum ultricies dolor metus"
                }
            );
            #endregion

            #region Skills
            context.Skills.AddOrUpdate(
                s => s.Id,
                new Models.Skill
                {
                    SkillName = "ASP.Net",
                    RatingNumber = 8,
                    SkillCategory = context.Categories.Single(c => c.Id == 2)
                },
                new Models.Skill
                {
                    Id = 1,
                    SkillName = "VB.Net",
                    RatingNumber = 8,
                    SkillCategory = context.Categories.Single(c => c.Id == 2)
                },
                new Models.Skill
                {
                    Id = 2,
                    SkillName = "Nederlands",
                    RatingNumber = 8,
                    SkillCategory = context.Categories.Single(c => c.Id == 1)
                },
                new Models.Skill
                {
                    Id = 3,
                    SkillName = "Engels",
                    RatingNumber = 8,
                    SkillCategory = context.Categories.Single(c => c.Id == 1)
                },
                new Models.Skill
                {
                    Id = 4,
                    SkillName = "Visual Studio",
                    RatingNumber = 7,
                    SkillCategory = context.Categories.Single(c => c.Id == 3)
                }
                );
            #endregion
        }
    }
}
