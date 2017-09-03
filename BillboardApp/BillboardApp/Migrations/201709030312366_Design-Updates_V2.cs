namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FaceSize", "Size", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FaceSize", "Size", c => c.String(maxLength: 15));
        }
    }
}
