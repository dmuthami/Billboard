namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StructuretoStructureOwnerRelationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Structure", "StructureOwnerID", c => c.Int(nullable: false));
            CreateIndex("dbo.Structure", "StructureOwnerID");
            AddForeignKey("dbo.Structure", "StructureOwnerID", "dbo.StructureOwner", "StructureOwnerID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Structure", "StructureOwnerID", "dbo.StructureOwner");
            DropIndex("dbo.Structure", new[] { "StructureOwnerID" });
            DropColumn("dbo.Structure", "StructureOwnerID");
        }
    }
}
