namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V21 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.VegetationCover", "Parameter", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.VegetationCover", "Parameter", c => c.String());
        }
    }
}
