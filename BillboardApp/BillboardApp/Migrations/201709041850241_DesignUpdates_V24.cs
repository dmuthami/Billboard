namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V24 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FaceClutter", "Parameter", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FaceClutter", "Parameter", c => c.Int(nullable: false));
        }
    }
}
