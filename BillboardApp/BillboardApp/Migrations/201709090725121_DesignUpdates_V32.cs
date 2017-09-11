namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V32 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Structure", "Ward", c => c.String(maxLength: 80));
            AddColumn("dbo.Structure", "Constituency", c => c.String(maxLength: 80));
            AddColumn("dbo.Structure", "County", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Structure", "County");
            DropColumn("dbo.Structure", "Constituency");
            DropColumn("dbo.Structure", "Ward");
        }
    }
}
