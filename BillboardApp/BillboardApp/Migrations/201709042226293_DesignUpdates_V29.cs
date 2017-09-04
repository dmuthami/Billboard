namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V29 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StreetGIS",
                c => new
                    {
                        StreetGISID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Geom = c.Geometry(),
                    })
                .PrimaryKey(t => t.StreetGISID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StreetGIS");
        }
    }
}
