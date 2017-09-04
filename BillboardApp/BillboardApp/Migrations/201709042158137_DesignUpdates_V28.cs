namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V28 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Street", "StreetNameByCollector", c => c.String());
            AddColumn("dbo.Street", "StreetNameByGIS", c => c.String());
            AddColumn("dbo.Street", "RouteID", c => c.Int(nullable: false));
            CreateIndex("dbo.Street", "RouteID");
            AddForeignKey("dbo.Street", "RouteID", "dbo.Route", "RouteID");
            DropColumn("dbo.Street", "Name");
            DropColumn("dbo.Street", "Geom");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Street", "Geom", c => c.Geometry());
            AddColumn("dbo.Street", "Name", c => c.String());
            DropForeignKey("dbo.Street", "RouteID", "dbo.Route");
            DropIndex("dbo.Street", new[] { "RouteID" });
            DropColumn("dbo.Street", "RouteID");
            DropColumn("dbo.Street", "StreetNameByGIS");
            DropColumn("dbo.Street", "StreetNameByCollector");
        }
    }
}
