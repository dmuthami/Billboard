namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V33 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Subscription", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Subscription", "Name", c => c.String());
        }
    }
}
