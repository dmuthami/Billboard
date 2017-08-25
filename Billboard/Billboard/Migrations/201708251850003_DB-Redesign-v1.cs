namespace Billboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBRedesignv1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Subscription");
            AlterColumn("dbo.Subscription", "SubscriptionID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Subscription", "SubscriptionID");
            CreateIndex("dbo.Subscription", "SubscriptionID");
            AddForeignKey("dbo.Subscription", "SubscriptionID", "dbo.Agency", "AgencyID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subscription", "SubscriptionID", "dbo.Agency");
            DropIndex("dbo.Subscription", new[] { "SubscriptionID" });
            DropPrimaryKey("dbo.Subscription");
            AlterColumn("dbo.Subscription", "SubscriptionID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Subscription", "SubscriptionID");
        }
    }
}
