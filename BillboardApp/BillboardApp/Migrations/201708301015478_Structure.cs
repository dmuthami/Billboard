namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Structure : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Face", "StructureID", "dbo.Structure");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Structure", "StructureOwner_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.StructureOwner", "Structure_StructureID", "dbo.Structure");
            DropForeignKey("dbo.Structure", "StructureTypeID", "dbo.StructureType");
            DropIndex("dbo.Face", new[] { "StructureID" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID" });
            DropIndex("dbo.Structure", new[] { "StructureTypeID" });
            DropIndex("dbo.Structure", new[] { "StructureOwner_StructureOwnerID" });
            DropIndex("dbo.StructureOwner", new[] { "Structure_StructureID" });
            DropColumn("dbo.Face", "StructureID");
            DropColumn("dbo.Face", "StructureOwner_StructureOwnerID");
            DropColumn("dbo.Structure", "StructureTypeID");
            DropColumn("dbo.Structure", "StructureOwnerID");
            DropColumn("dbo.Structure", "StructureOwner_StructureOwnerID");
            DropColumn("dbo.StructureOwner", "Structure_StructureID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StructureOwner", "Structure_StructureID", c => c.Int());
            AddColumn("dbo.Structure", "StructureOwner_StructureOwnerID", c => c.Int());
            AddColumn("dbo.Structure", "StructureOwnerID", c => c.Int(nullable: false));
            AddColumn("dbo.Structure", "StructureTypeID", c => c.Int(nullable: false));
            AddColumn("dbo.Face", "StructureOwner_StructureOwnerID", c => c.Int());
            AddColumn("dbo.Face", "StructureID", c => c.Int(nullable: false));
            CreateIndex("dbo.StructureOwner", "Structure_StructureID");
            CreateIndex("dbo.Structure", "StructureOwner_StructureOwnerID");
            CreateIndex("dbo.Structure", "StructureTypeID");
            CreateIndex("dbo.Face", "StructureOwner_StructureOwnerID");
            CreateIndex("dbo.Face", "StructureID");
            AddForeignKey("dbo.Structure", "StructureTypeID", "dbo.StructureType", "StructureTypeID");
            AddForeignKey("dbo.StructureOwner", "Structure_StructureID", "dbo.Structure", "StructureID");
            AddForeignKey("dbo.Structure", "StructureOwner_StructureOwnerID", "dbo.StructureOwner", "StructureOwnerID");
            AddForeignKey("dbo.Face", "StructureOwner_StructureOwnerID", "dbo.StructureOwner", "StructureOwnerID");
            AddForeignKey("dbo.Face", "StructureID", "dbo.Structure", "StructureID");
        }
    }
}
