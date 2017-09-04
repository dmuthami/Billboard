namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V25 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FaceTraffic",
                c => new
                    {
                        FaceTrafficID = c.Int(nullable: false, identity: true),
                        Parameter = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FaceTrafficID);
            
            DropTable("dbo.Traffic");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Traffic",
                c => new
                    {
                        TrafficID = c.Int(nullable: false, identity: true),
                        Parameter = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrafficID);
            
            DropTable("dbo.FaceTraffic");
        }
    }
}
