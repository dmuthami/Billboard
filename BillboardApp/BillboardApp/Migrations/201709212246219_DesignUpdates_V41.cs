namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V41 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Subscription", "SubscriptionID", "dbo.Agency");
            AddForeignKey("dbo.Subscription", "SubscriptionID", "dbo.Agency", "AgencyID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subscription", "SubscriptionID", "dbo.Agency");
            AddForeignKey("dbo.Subscription", "SubscriptionID", "dbo.Agency", "AgencyID");
        }
    }
}
