namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Structure", "StructureOwnerID", "dbo.StructureOwner");
            DropPrimaryKey("dbo.StructureOwner");
            AlterColumn("dbo.StructureOwner", "StructureOwnerID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.StructureOwner", "StructureOwnerID");
            AddForeignKey("dbo.Structure", "StructureOwnerID", "dbo.StructureOwner", "StructureOwnerID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Structure", "StructureOwnerID", "dbo.StructureOwner");
            DropPrimaryKey("dbo.StructureOwner");
            AlterColumn("dbo.StructureOwner", "StructureOwnerID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.StructureOwner", "StructureOwnerID");
            AddForeignKey("dbo.Structure", "StructureOwnerID", "dbo.StructureOwner", "StructureOwnerID");
        }
    }
}
