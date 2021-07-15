namespace Broadway._630.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userIdUpdated : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Students", name: "Username", newName: "UserId");
            RenameIndex(table: "dbo.Students", name: "IX_Username", newName: "IX_UserId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Students", name: "IX_UserId", newName: "IX_Username");
            RenameColumn(table: "dbo.Students", name: "UserId", newName: "Username");
        }
    }
}
