namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V18 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FaceImage", "FaceURL", c => c.String());
            AddColumn("dbo.FaceImage", "Content", c => c.Binary());
            DropColumn("dbo.FaceImage", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FaceImage", "Image", c => c.String());
            DropColumn("dbo.FaceImage", "Content");
            DropColumn("dbo.FaceImage", "FaceURL");
        }
    }
}
