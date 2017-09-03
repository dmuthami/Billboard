namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V11 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.StructureOwner");
            AddColumn("dbo.StructureOwner", "Myid", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.StructureOwner", "Myid");
            DropColumn("dbo.StructureOwner", "StructureOwnerID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StructureOwner", "StructureOwnerID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.StructureOwner");
            DropColumn("dbo.StructureOwner", "Myid");
            AddPrimaryKey("dbo.StructureOwner", "StructureOwnerID");
        }
    }
}
