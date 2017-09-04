namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V20 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FaceLighting", "Parameter", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FaceLighting", "Parameter", c => c.Int(nullable: false));
        }
    }
}
