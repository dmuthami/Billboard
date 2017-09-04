namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V26 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FaceTraffic", "Parameter", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FaceTraffic", "Parameter", c => c.Int(nullable: false));
        }
    }
}
