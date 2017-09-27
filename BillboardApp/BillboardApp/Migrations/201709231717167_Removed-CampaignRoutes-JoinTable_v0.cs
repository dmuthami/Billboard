namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedCampaignRoutesJoinTable_v0 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CampaignRoute", "CampaignID", "dbo.Campaign");
            DropForeignKey("dbo.CampaignRoute", "RouteID", "dbo.Route");
            DropIndex("dbo.CampaignRoute", new[] { "CampaignID" });
            DropIndex("dbo.CampaignRoute", new[] { "RouteID" });
            CreateTable(
                "dbo.RouteCampaign",
                c => new
                    {
                        Route_RouteID = c.Int(nullable: false),
                        Campaign_CampaignID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Route_RouteID, t.Campaign_CampaignID })
                .ForeignKey("dbo.Route", t => t.Route_RouteID, cascadeDelete: true)
                .ForeignKey("dbo.Campaign", t => t.Campaign_CampaignID, cascadeDelete: true)
                .Index(t => t.Route_RouteID)
                .Index(t => t.Campaign_CampaignID);
            
            DropTable("dbo.CampaignRoute");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CampaignRoute",
                c => new
                    {
                        CampaignRouteID = c.Int(nullable: false, identity: true),
                        CampaignID = c.Int(nullable: false),
                        RouteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CampaignRouteID);
            
            DropForeignKey("dbo.RouteCampaign", "Campaign_CampaignID", "dbo.Campaign");
            DropForeignKey("dbo.RouteCampaign", "Route_RouteID", "dbo.Route");
            DropIndex("dbo.RouteCampaign", new[] { "Campaign_CampaignID" });
            DropIndex("dbo.RouteCampaign", new[] { "Route_RouteID" });
            DropTable("dbo.RouteCampaign");
            CreateIndex("dbo.CampaignRoute", "RouteID");
            CreateIndex("dbo.CampaignRoute", "CampaignID");
            AddForeignKey("dbo.CampaignRoute", "RouteID", "dbo.Route", "RouteID", cascadeDelete: true);
            AddForeignKey("dbo.CampaignRoute", "CampaignID", "dbo.Campaign", "CampaignID", cascadeDelete: true);
        }
    }
}
