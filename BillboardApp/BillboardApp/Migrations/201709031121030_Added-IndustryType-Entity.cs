namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIndustryTypeEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IndustryType",
                c => new
                    {
                        IndustryTypeID = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.IndustryTypeID);
            
            AddColumn("dbo.Industry", "IndustryTypeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Industry", "IndustryTypeID");
            AddForeignKey("dbo.Industry", "IndustryTypeID", "dbo.IndustryType", "IndustryTypeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Industry", "IndustryTypeID", "dbo.IndustryType");
            DropIndex("dbo.Industry", new[] { "IndustryTypeID" });
            DropColumn("dbo.Industry", "IndustryTypeID");
            DropTable("dbo.IndustryType");
        }
    }
}
