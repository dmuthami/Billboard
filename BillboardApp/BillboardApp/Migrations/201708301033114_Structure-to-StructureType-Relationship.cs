namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StructuretoStructureTypeRelationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Structure", "StructureTypeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Structure", "StructureTypeID");
            AddForeignKey("dbo.Structure", "StructureTypeID", "dbo.StructureType", "StructureTypeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Structure", "StructureTypeID", "dbo.StructureType");
            DropIndex("dbo.Structure", new[] { "StructureTypeID" });
            DropColumn("dbo.Structure", "StructureTypeID");
        }
    }
}
