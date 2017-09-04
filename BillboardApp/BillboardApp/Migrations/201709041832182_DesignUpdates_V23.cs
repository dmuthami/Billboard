namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V23 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FaceClutter",
                c => new
                    {
                        FaceClutterID = c.Int(nullable: false, identity: true),
                        Parameter = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FaceClutterID);
            
            DropTable("dbo.Clutter");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Clutter",
                c => new
                    {
                        ClutterID = c.Int(nullable: false, identity: true),
                        Parameter = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClutterID);
            
            DropTable("dbo.FaceClutter");
        }
    }
}
