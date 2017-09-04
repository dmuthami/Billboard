namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V22 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FaceRunUp",
                c => new
                    {
                        FaceRunUpID = c.Int(nullable: false, identity: true),
                        Parameter = c.String(),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FaceRunUpID);
            
            DropTable("dbo.SiteRunUp");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SiteRunUp",
                c => new
                    {
                        SiteRunUpID = c.Int(nullable: false, identity: true),
                        DistanceOption = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SiteRunUpID);
            
            DropTable("dbo.FaceRunUp");
        }
    }
}
