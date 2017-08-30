namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StructuretoFaceRelationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Face", "StructureID", c => c.Int(nullable: false));
            CreateIndex("dbo.Face", "StructureID");
            AddForeignKey("dbo.Face", "StructureID", "dbo.Structure", "StructureID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Face", "StructureID", "dbo.Structure");
            DropIndex("dbo.Face", new[] { "StructureID" });
            DropColumn("dbo.Face", "StructureID");
        }
    }
}
