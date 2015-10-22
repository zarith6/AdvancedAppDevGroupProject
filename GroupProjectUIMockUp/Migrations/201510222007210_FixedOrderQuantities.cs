namespace GroupProjectUIMockUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedOrderQuantities : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "OrderQuantities", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "OrderQuantities", c => c.String());
        }
    }
}
