namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V13 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Face", "FaceOccupancyID", "dbo.FaceOccupancy");
            DropIndex("dbo.Face", new[] { "FaceOccupancyID" });
            DropColumn("dbo.Face", "FaceOccupancyID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Face", "FaceOccupancyID", c => c.Int(nullable: false));
            CreateIndex("dbo.Face", "FaceOccupancyID");
            AddForeignKey("dbo.Face", "FaceOccupancyID", "dbo.FaceOccupancy", "FaceOccupancyID");
        }
    }
}
