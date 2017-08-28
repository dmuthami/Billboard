namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBStructureRevision_v0 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.FaceVisibilityRating");
            AlterColumn("dbo.FaceVisibilityRating", "FaceVisibilityRatingID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.FaceVisibilityRating", "FaceVisibilityRatingID");
            CreateIndex("dbo.FaceVisibilityRating", "FaceVisibilityRatingID");
            AddForeignKey("dbo.FaceVisibilityRating", "FaceVisibilityRatingID", "dbo.Face", "FaceID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FaceVisibilityRating", "FaceVisibilityRatingID", "dbo.Face");
            DropIndex("dbo.FaceVisibilityRating", new[] { "FaceVisibilityRatingID" });
            DropPrimaryKey("dbo.FaceVisibilityRating");
            AlterColumn("dbo.FaceVisibilityRating", "FaceVisibilityRatingID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.FaceVisibilityRating", "FaceVisibilityRatingID");
        }
    }
}
