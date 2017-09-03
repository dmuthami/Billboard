namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V0 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Traffic", "Parameter", c => c.Int(nullable: false));
            DropColumn("dbo.Traffic", "Paramameter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Traffic", "Paramameter", c => c.Int(nullable: false));
            DropColumn("dbo.Traffic", "Parameter");
        }
    }
}
