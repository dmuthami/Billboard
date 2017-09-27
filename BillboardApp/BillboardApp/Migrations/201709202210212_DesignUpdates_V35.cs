namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V35 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Campaign", "ProductID", "dbo.Product");
            DropIndex("dbo.Campaign", new[] { "ProductID" });
            DropColumn("dbo.Campaign", "ProductID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Campaign", "ProductID", c => c.Int(nullable: false));
            CreateIndex("dbo.Campaign", "ProductID");
            AddForeignKey("dbo.Campaign", "ProductID", "dbo.Product", "ProductID");
        }
    }
}
