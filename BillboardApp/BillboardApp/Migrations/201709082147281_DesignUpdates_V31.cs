namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V31 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Structure", "FaceCount", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Structure", "FaceCount", c => c.Int(nullable: false));
        }
    }
}
