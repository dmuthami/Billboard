namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V39 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Advert", "CampaignID", "dbo.Campaign");
            DropIndex("dbo.Advert", new[] { "CampaignID" });
            DropColumn("dbo.Advert", "CampaignID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Advert", "CampaignID", c => c.Int(nullable: false));
            CreateIndex("dbo.Advert", "CampaignID");
            AddForeignKey("dbo.Advert", "CampaignID", "dbo.Campaign", "CampaignID");
        }
    }
}
