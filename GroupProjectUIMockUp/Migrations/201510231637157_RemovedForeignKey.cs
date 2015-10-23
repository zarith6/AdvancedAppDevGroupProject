namespace GroupProjectUIMockUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "UserID", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "UserID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Orders", "UserID");
            AddForeignKey("dbo.Orders", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
        }
    }
}
