namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V38 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Campaign", "AdvertiserID", c => c.Int(nullable: false));
            AddColumn("dbo.Campaign", "IndustryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Campaign", "AdvertiserID");
            CreateIndex("dbo.Campaign", "IndustryID");
            AddForeignKey("dbo.Campaign", "AdvertiserID", "dbo.Advertiser", "AdvertiserID");
            AddForeignKey("dbo.Campaign", "IndustryID", "dbo.Industry", "IndustryID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Campaign", "IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "AdvertiserID", "dbo.Advertiser");
            DropIndex("dbo.Campaign", new[] { "IndustryID" });
            DropIndex("dbo.Campaign", new[] { "AdvertiserID" });
            DropColumn("dbo.Campaign", "IndustryID");
            DropColumn("dbo.Campaign", "AdvertiserID");
        }
    }
}
