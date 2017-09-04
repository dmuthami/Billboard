namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V15 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Face", "FaceAvailabilityID", "dbo.FaceAvailability");
            DropIndex("dbo.Face", new[] { "FaceAvailabilityID" });
            CreateTable(
                "dbo.FaceOccupancy",
                c => new
                    {
                        FaceOccupancyID = c.Int(nullable: false, identity: true),
                        OccupancyType = c.String(),
                    })
                .PrimaryKey(t => t.FaceOccupancyID);
            
            DropColumn("dbo.Face", "FaceAvailabilityID");
            DropTable("dbo.FaceAvailability");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.FaceAvailability",
                c => new
                    {
                        FaceAvailabilityID = c.Int(nullable: false, identity: true),
                        AvailabilityType = c.String(),
                    })
                .PrimaryKey(t => t.FaceAvailabilityID);
            
            AddColumn("dbo.Face", "FaceAvailabilityID", c => c.Int(nullable: false));
            DropTable("dbo.FaceOccupancy");
            CreateIndex("dbo.Face", "FaceAvailabilityID");
            AddForeignKey("dbo.Face", "FaceAvailabilityID", "dbo.FaceAvailability", "FaceAvailabilityID");
        }
    }
}
