namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V27 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "AdvertiserID", c => c.Int(nullable: false));
            CreateIndex("dbo.Product", "AdvertiserID");
            AddForeignKey("dbo.Product", "AdvertiserID", "dbo.Advertiser", "AdvertiserID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "AdvertiserID", "dbo.Advertiser");
            DropIndex("dbo.Product", new[] { "AdvertiserID" });
            DropColumn("dbo.Product", "AdvertiserID");
        }
    }
}
