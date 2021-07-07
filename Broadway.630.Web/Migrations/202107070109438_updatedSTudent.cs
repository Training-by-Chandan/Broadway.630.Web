namespace Broadway._630.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class updatedSTudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Username", c => c.String(maxLength: 128));
            CreateIndex("dbo.Students", "Username");
            AddForeignKey("dbo.Students", "Username", "dbo.AspNetUsers", "Id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Students", "Username", "dbo.AspNetUsers");
            DropIndex("dbo.Students", new[] { "Username" });
            DropColumn("dbo.Students", "Username");
        }
    }
}