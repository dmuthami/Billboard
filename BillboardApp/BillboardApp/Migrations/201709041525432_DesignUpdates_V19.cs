namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V19 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FaceLighting",
                c => new
                    {
                        FaceLightingID = c.Int(nullable: false, identity: true),
                        Parameter = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FaceLightingID);
            
            AddColumn("dbo.FaceVisibilityRating", "FaceLightingScore", c => c.Double());
            AddColumn("dbo.FaceVisibilityRating", "FaceRunUpScore", c => c.Double());
            AddColumn("dbo.FaceVisibilityRating", "FaceTrafficScore", c => c.Double());
            AddColumn("dbo.FaceVisibilityRating", "FaceClutterScore", c => c.Double());
            AddColumn("dbo.VegetationCover", "Parameter", c => c.String());
            DropColumn("dbo.FaceVisibilityRating", "SightLightingScore");
            DropColumn("dbo.FaceVisibilityRating", "BacklightScore");
            DropColumn("dbo.FaceVisibilityRating", "UnlightScore");
            DropColumn("dbo.FaceVisibilityRating", "TrafficScore");
            DropColumn("dbo.FaceVisibilityRating", "ClutterScore");
            DropColumn("dbo.VegetationCover", "Type");
            DropTable("dbo.SiteLighting");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SiteLighting",
                c => new
                    {
                        SiteLightingID = c.Int(nullable: false, identity: true),
                        Parameter = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SiteLightingID);
            
            AddColumn("dbo.VegetationCover", "Type", c => c.String(nullable: false));
            AddColumn("dbo.FaceVisibilityRating", "ClutterScore", c => c.Double());
            AddColumn("dbo.FaceVisibilityRating", "TrafficScore", c => c.Double());
            AddColumn("dbo.FaceVisibilityRating", "UnlightScore", c => c.Double());
            AddColumn("dbo.FaceVisibilityRating", "BacklightScore", c => c.Double());
            AddColumn("dbo.FaceVisibilityRating", "SightLightingScore", c => c.Double());
            DropColumn("dbo.VegetationCover", "Parameter");
            DropColumn("dbo.FaceVisibilityRating", "FaceClutterScore");
            DropColumn("dbo.FaceVisibilityRating", "FaceTrafficScore");
            DropColumn("dbo.FaceVisibilityRating", "FaceRunUpScore");
            DropColumn("dbo.FaceVisibilityRating", "FaceLightingScore");
            DropTable("dbo.FaceLighting");
        }
    }
}
