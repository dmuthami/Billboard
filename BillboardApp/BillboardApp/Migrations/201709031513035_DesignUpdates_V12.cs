namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V12 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.StructureOwner");
            DropColumn("dbo.StructureOwner", "Myid");
            AddColumn("dbo.Structure", "StructureOwnerID", c => c.Int(nullable: false));
            AddColumn("dbo.StructureOwner", "StructureOwnerID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.StructureOwner", "StructureOwnerID");
            CreateIndex("dbo.Structure", "StructureOwnerID");
            AddForeignKey("dbo.Structure", "StructureOwnerID", "dbo.StructureOwner", "StructureOwnerID");
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.StructureOwner", "Myid", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Structure", "StructureOwnerID", "dbo.StructureOwner");
            DropIndex("dbo.Structure", new[] { "StructureOwnerID" });
            DropPrimaryKey("dbo.StructureOwner");
            DropColumn("dbo.StructureOwner", "StructureOwnerID");
            DropColumn("dbo.Structure", "StructureOwnerID");
            AddPrimaryKey("dbo.StructureOwner", "Myid");
        }
    }
}
