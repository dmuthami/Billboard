namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V36 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID", "dbo.Industry");
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID" });
            DropColumn("dbo.Campaign", "Advertiser_AdvertiserID");
            DropColumn("dbo.Campaign", "Industry_IndustryID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Campaign", "Industry_IndustryID", c => c.Int());
            AddColumn("dbo.Campaign", "Advertiser_AdvertiserID", c => c.Int());
            CreateIndex("dbo.Campaign", "Industry_IndustryID");
            CreateIndex("dbo.Campaign", "Advertiser_AdvertiserID");
            AddForeignKey("dbo.Campaign", "Industry_IndustryID", "dbo.Industry", "IndustryID");
            AddForeignKey("dbo.Campaign", "Advertiser_AdvertiserID", "dbo.Advertiser", "AdvertiserID");
        }
    }
}
