namespace Wompus_Website.Migrations.UserProfiles
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;
    using WebMatrix.WebData;

    internal sealed class ConfigurationUserContext : DbMigrationsConfiguration<Wompus_Website.Models.UsersContext>
    {
        public ConfigurationUserContext()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Wompus_Website.Models.UsersContext context)
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
            WebSecurity.InitializeDatabaseConnection(
                "DefaultConnection",
                "UserProfile",
                "UserId",
                "UserName", autoCreateTables: true);

            if (!Roles.RoleExists("admin"))
                Roles.CreateRole("admin");

            if (!WebSecurity.UserExists("rrog6"))
                WebSecurity.CreateUserAndAccount(
                    "rrog6",
                    "MikeAdams69");

            if (!Roles.GetRolesForUser("rrog6").Contains("admin"))
                Roles.AddUsersToRoles(new[] { "rrog6" }, new[] { "admin" });
            
        }
    }
}
