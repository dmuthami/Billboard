namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V17 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FaceOccupancy",
                c => new
                    {
                        FaceOccupancyID = c.Int(nullable: false, identity: true),
                        OccupancyType = c.String(),
                    })
                .PrimaryKey(t => t.FaceOccupancyID);
            
            AddColumn("dbo.Face", "FaceOccupancyID", c => c.Int(nullable: false));
            CreateIndex("dbo.Face", "FaceOccupancyID");
            AddForeignKey("dbo.Face", "FaceOccupancyID", "dbo.FaceOccupancy", "FaceOccupancyID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Face", "FaceOccupancyID", "dbo.FaceOccupancy");
            DropIndex("dbo.Face", new[] { "FaceOccupancyID" });
            DropColumn("dbo.Face", "FaceOccupancyID");
            DropTable("dbo.FaceOccupancy");
        }
    }
}
