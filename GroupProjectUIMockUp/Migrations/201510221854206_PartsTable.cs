namespace GroupProjectUIMockUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PartsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AutoParts",
                c => new
                    {
                        AutoPartID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.String(),
                    })
                .PrimaryKey(t => t.AutoPartID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AutoParts");
        }
    }
}
