namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V30 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Structure", "Comment", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Structure", "Comment", c => c.String(nullable: false));
        }
    }
}
