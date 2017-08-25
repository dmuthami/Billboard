namespace Billboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBRedesignv0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.County",
                c => new
                    {
                        Code = c.Int(nullable: false),
                        DateCreated = c.DateTime(),
                        DateRetired = c.DateTime(),
                        Name = c.String(nullable: false, maxLength: 50),
                        Abbreviation = c.String(nullable: false, maxLength: 3),
                        Geom = c.Geometry(),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.Subscription",
                c => new
                    {
                        SubscriptionID = c.Int(nullable: false, identity: true),
                        Amount = c.Double(),
                        Paid = c.Double(),
                        StartDate = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.SubscriptionID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subscription");
            DropTable("dbo.County");
        }
    }
}
