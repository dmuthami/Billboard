namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FaceSize", "Size", c => c.String(maxLength: 15));
            DropColumn("dbo.FaceSize", "Height");
            DropColumn("dbo.FaceSize", "Width");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FaceSize", "Width", c => c.Double(nullable: false));
            AddColumn("dbo.FaceSize", "Height", c => c.Double(nullable: false));
            DropColumn("dbo.FaceSize", "Size");
        }
    }
}
