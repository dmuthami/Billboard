namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Structure", "StructureOwnerID", "dbo.StructureOwner");
            DropIndex("dbo.Structure", new[] { "StructureOwnerID" });
            DropColumn("dbo.Structure", "StructureOwnerID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Structure", "StructureOwnerID", c => c.Int(nullable: false));
            CreateIndex("dbo.Structure", "StructureOwnerID");
            AddForeignKey("dbo.Structure", "StructureOwnerID", "dbo.StructureOwner", "StructureOwnerID");
        }
    }
}
