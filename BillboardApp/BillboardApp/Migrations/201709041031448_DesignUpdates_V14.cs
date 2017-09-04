namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V14 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.FaceOccupancy");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.FaceOccupancy",
                c => new
                    {
                        FaceOccupancyID = c.Int(nullable: false, identity: true),
                        Occupancy = c.String(),
                    })
                .PrimaryKey(t => t.FaceOccupancyID);
            
        }
    }
}
