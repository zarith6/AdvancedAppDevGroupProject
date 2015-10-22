namespace GroupProjectUIMockUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "OrderType");
        }
    }
}
