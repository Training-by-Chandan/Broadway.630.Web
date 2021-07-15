namespace Broadway._630.Web.Migrations
{
    using Broadway._630.Web.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Broadway._630.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Broadway._630.Web.Models.ApplicationDbContext db)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var roleStore = new RoleStore<IdentityRole>(db);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            #region Admin

            if (!(db.Roles.Any(p => p.Name == ConstString.Roles.Admin)))
            {
                roleManager.Create(new IdentityRole() { Name = ConstString.Roles.Admin });
            }

            if (!(db.Users.Any(u => u.UserName == "admin@admin.com")))
            {
                var userStore = new UserStore<ApplicationUser>(db);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "admin@admin.com", PhoneNumber = "12345678911", Email = "admin@admin.com" };
                userManager.Create(userToInsert, "Admin@123");

                userManager.AddToRole(userToInsert.Id, ConstString.Roles.Admin);
            }

            #endregion Admin

            #region Student

            if (!(db.Roles.Any(p => p.Name == ConstString.Roles.Student)))
            {
                roleManager.Create(new IdentityRole() { Name = ConstString.Roles.Student });
            }

            if (!(db.Users.Any(u => u.UserName == "student@student.com")))
            {
                var userStore = new UserStore<ApplicationUser>(db);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "student@student.com", PhoneNumber = "12345678911", Email = "student@student.com" };
                userManager.Create(userToInsert, "Student@123");

                userManager.AddToRole(userToInsert.Id, ConstString.Roles.Student);
            }

            #endregion Student

            #region Teacher

            if (!(db.Roles.Any(p => p.Name == ConstString.Roles.Teacher)))
            {
                roleManager.Create(new IdentityRole() { Name = ConstString.Roles.Teacher });
            }

            if (!(db.Users.Any(u => u.UserName == "Teacher@teacher.com")))
            {
                var userStore = new UserStore<ApplicationUser>(db);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "Teacher@teacher.com", PhoneNumber = "12345678911", Email = "Teacher@teacher.com" };
                userManager.Create(userToInsert, "Teacher@123");

                userManager.AddToRole(userToInsert.Id, ConstString.Roles.Teacher);
            }

            #endregion Teacher
        }
    }
}