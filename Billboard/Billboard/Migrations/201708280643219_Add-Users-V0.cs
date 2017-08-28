namespace Billboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsersV0 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID1", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID1", "dbo.Industry");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID4", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage1_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.FaceImage", "Face_FaceID3", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID4", "dbo.Face");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID1", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID1", "dbo.StructureType");
            DropForeignKey("dbo.FaceImage", "Face_FaceID2", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face1_FaceID", "dbo.Face");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID2", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID3", "dbo.FaceImage");
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID1" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID1" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID2" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID3" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID4" });
            DropIndex("dbo.Face", new[] { "FaceImage1_FaceImageID" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID1" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID1" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID2" });
            DropIndex("dbo.FaceImage", new[] { "Face1_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID3" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID4" });
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        KRA_Pin = c.String(),
                        RoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Role", t => t.RoleID)
                .Index(t => t.RoleID);
            
            AddColumn("dbo.Campaign", "Advertiser_AdvertiserID2", c => c.Int());
            AddColumn("dbo.Campaign", "Advertiser1_AdvertiserID", c => c.Int());
            AddColumn("dbo.Campaign", "Industry_IndustryID2", c => c.Int());
            AddColumn("dbo.Campaign", "Industry_IndustryID3", c => c.Int());
            AddColumn("dbo.Campaign", "Industry_IndustryID4", c => c.Int());
            AddColumn("dbo.Campaign", "Industry1_IndustryID", c => c.Int());
            AddColumn("dbo.Campaign", "Advertiser_AdvertiserID3", c => c.Int());
            AddColumn("dbo.Campaign", "Advertiser_AdvertiserID4", c => c.Int());
            AddColumn("dbo.Face", "FaceImage_FaceImageID5", c => c.Int());
            AddColumn("dbo.Face", "FaceImage_FaceImageID6", c => c.Int());
            AddColumn("dbo.Face", "FaceImage_FaceImageID7", c => c.Int());
            AddColumn("dbo.Face", "FaceImage_FaceImageID8", c => c.Int());
            AddColumn("dbo.Face", "FaceImage_FaceImageID9", c => c.Int());
            AddColumn("dbo.Face", "FaceImage_FaceImageID10", c => c.Int());
            AddColumn("dbo.Face", "FaceImage_FaceImageID11", c => c.Int());
            AddColumn("dbo.Face", "FaceImage1_FaceImageID1", c => c.Int());
            AddColumn("dbo.Face", "FaceImage11_FaceImageID", c => c.Int());
            AddColumn("dbo.Face", "FaceImage2_FaceImageID", c => c.Int());
            AddColumn("dbo.Face", "FaceImage21_FaceImageID", c => c.Int());
            AddColumn("dbo.Face", "FaceImage3_FaceImageID", c => c.Int());
            AddColumn("dbo.Face", "StructureOwner_StructureOwnerID2", c => c.Int());
            AddColumn("dbo.Face", "StructureOwner_StructureOwnerID3", c => c.Int());
            AddColumn("dbo.Face", "StructureType_StructureTypeID2", c => c.Int());
            AddColumn("dbo.Face", "StructureType_StructureTypeID3", c => c.Int());
            AddColumn("dbo.Face", "StructureOwner_StructureOwnerID4", c => c.Int());
            AddColumn("dbo.Face", "StructureOwner1_StructureOwnerID", c => c.Int());
            AddColumn("dbo.Face", "StructureType_StructureTypeID4", c => c.Int());
            AddColumn("dbo.Face", "StructureType1_StructureTypeID", c => c.Int());
            AddColumn("dbo.FaceImage", "Face_FaceID5", c => c.Int());
            AddColumn("dbo.FaceImage", "Face1_FaceID1", c => c.Int());
            AddColumn("dbo.FaceImage", "Face11_FaceID", c => c.Int());
            AddColumn("dbo.FaceImage", "Face2_FaceID", c => c.Int());
            AddColumn("dbo.FaceImage", "Face21_FaceID", c => c.Int());
            AddColumn("dbo.FaceImage", "Face3_FaceID", c => c.Int());
            AddColumn("dbo.FaceImage", "Face_FaceID6", c => c.Int());
            AddColumn("dbo.FaceImage", "Face_FaceID7", c => c.Int());
            AddColumn("dbo.FaceImage", "Face_FaceID8", c => c.Int());
            AddColumn("dbo.FaceImage", "Face_FaceID9", c => c.Int());
            AddColumn("dbo.FaceImage", "Face_FaceID10", c => c.Int());
            AddColumn("dbo.FaceImage", "Face_FaceID11", c => c.Int());
            CreateIndex("dbo.Campaign", "Advertiser_AdvertiserID2");
            CreateIndex("dbo.Campaign", "Advertiser1_AdvertiserID");
            CreateIndex("dbo.Campaign", "Industry_IndustryID2");
            CreateIndex("dbo.Campaign", "Industry_IndustryID3");
            CreateIndex("dbo.Campaign", "Industry_IndustryID4");
            CreateIndex("dbo.Campaign", "Industry1_IndustryID");
            CreateIndex("dbo.Campaign", "Advertiser_AdvertiserID3");
            CreateIndex("dbo.Campaign", "Advertiser_AdvertiserID4");
            CreateIndex("dbo.Face", "FaceImage_FaceImageID5");
            CreateIndex("dbo.Face", "FaceImage_FaceImageID6");
            CreateIndex("dbo.Face", "FaceImage_FaceImageID7");
            CreateIndex("dbo.Face", "FaceImage_FaceImageID8");
            CreateIndex("dbo.Face", "FaceImage_FaceImageID9");
            CreateIndex("dbo.Face", "FaceImage_FaceImageID10");
            CreateIndex("dbo.Face", "FaceImage_FaceImageID11");
            CreateIndex("dbo.Face", "FaceImage1_FaceImageID1");
            CreateIndex("dbo.Face", "FaceImage11_FaceImageID");
            CreateIndex("dbo.Face", "FaceImage2_FaceImageID");
            CreateIndex("dbo.Face", "FaceImage21_FaceImageID");
            CreateIndex("dbo.Face", "FaceImage3_FaceImageID");
            CreateIndex("dbo.Face", "StructureOwner_StructureOwnerID2");
            CreateIndex("dbo.Face", "StructureOwner_StructureOwnerID3");
            CreateIndex("dbo.Face", "StructureType_StructureTypeID2");
            CreateIndex("dbo.Face", "StructureType_StructureTypeID3");
            CreateIndex("dbo.Face", "StructureOwner_StructureOwnerID4");
            CreateIndex("dbo.Face", "StructureOwner1_StructureOwnerID");
            CreateIndex("dbo.Face", "StructureType_StructureTypeID4");
            CreateIndex("dbo.Face", "StructureType1_StructureTypeID");
            CreateIndex("dbo.FaceImage", "Face_FaceID5");
            CreateIndex("dbo.FaceImage", "Face1_FaceID1");
            CreateIndex("dbo.FaceImage", "Face11_FaceID");
            CreateIndex("dbo.FaceImage", "Face2_FaceID");
            CreateIndex("dbo.FaceImage", "Face21_FaceID");
            CreateIndex("dbo.FaceImage", "Face3_FaceID");
            CreateIndex("dbo.FaceImage", "Face_FaceID6");
            CreateIndex("dbo.FaceImage", "Face_FaceID7");
            CreateIndex("dbo.FaceImage", "Face_FaceID8");
            CreateIndex("dbo.FaceImage", "Face_FaceID9");
            CreateIndex("dbo.FaceImage", "Face_FaceID10");
            CreateIndex("dbo.FaceImage", "Face_FaceID11");
            AddForeignKey("dbo.Campaign", "Advertiser1_AdvertiserID", "dbo.Advertiser", "AdvertiserID");
            AddForeignKey("dbo.Campaign", "Industry_IndustryID3", "dbo.Industry", "IndustryID");
            AddForeignKey("dbo.Campaign", "Industry1_IndustryID", "dbo.Industry", "IndustryID");
            AddForeignKey("dbo.FaceImage", "Face11_FaceID", "dbo.Face", "FaceID");
            AddForeignKey("dbo.FaceImage", "Face2_FaceID", "dbo.Face", "FaceID");
            AddForeignKey("dbo.FaceImage", "Face21_FaceID", "dbo.Face", "FaceID");
            AddForeignKey("dbo.FaceImage", "Face3_FaceID", "dbo.Face", "FaceID");
            AddForeignKey("dbo.Face", "FaceImage_FaceImageID7", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.Face", "FaceImage_FaceImageID8", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.Face", "FaceImage_FaceImageID9", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.Face", "FaceImage_FaceImageID10", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.Face", "FaceImage11_FaceImageID", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.Face", "FaceImage2_FaceImageID", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.Face", "FaceImage21_FaceImageID", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.Face", "FaceImage3_FaceImageID", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.FaceImage", "Face_FaceID8", "dbo.Face", "FaceID");
            AddForeignKey("dbo.FaceImage", "Face_FaceID9", "dbo.Face", "FaceID");
            AddForeignKey("dbo.FaceImage", "Face_FaceID10", "dbo.Face", "FaceID");
            AddForeignKey("dbo.FaceImage", "Face_FaceID11", "dbo.Face", "FaceID");
            AddForeignKey("dbo.Face", "StructureOwner_StructureOwnerID3", "dbo.StructureOwner", "StructureOwnerID");
            AddForeignKey("dbo.Face", "StructureType_StructureTypeID3", "dbo.StructureType", "StructureTypeID");
            AddForeignKey("dbo.Face", "StructureOwner1_StructureOwnerID", "dbo.StructureOwner", "StructureOwnerID");
            AddForeignKey("dbo.Face", "StructureType1_StructureTypeID", "dbo.StructureType", "StructureTypeID");
            AddForeignKey("dbo.Campaign", "Advertiser_AdvertiserID4", "dbo.Advertiser", "AdvertiserID");
            AddForeignKey("dbo.Campaign", "Advertiser_AdvertiserID3", "dbo.Advertiser", "AdvertiserID");
            AddForeignKey("dbo.Campaign", "Advertiser_AdvertiserID2", "dbo.Advertiser", "AdvertiserID");
            AddForeignKey("dbo.Campaign", "Industry_IndustryID4", "dbo.Industry", "IndustryID");
            AddForeignKey("dbo.Campaign", "Industry_IndustryID2", "dbo.Industry", "IndustryID");
            AddForeignKey("dbo.Face", "FaceImage_FaceImageID11", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.Face", "FaceImage1_FaceImageID1", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.FaceImage", "Face_FaceID6", "dbo.Face", "FaceID");
            AddForeignKey("dbo.FaceImage", "Face_FaceID7", "dbo.Face", "FaceID");
            AddForeignKey("dbo.Face", "StructureOwner_StructureOwnerID4", "dbo.StructureOwner", "StructureOwnerID");
            AddForeignKey("dbo.Face", "StructureType_StructureTypeID4", "dbo.StructureType", "StructureTypeID");
            AddForeignKey("dbo.FaceImage", "Face_FaceID5", "dbo.Face", "FaceID");
            AddForeignKey("dbo.FaceImage", "Face1_FaceID1", "dbo.Face", "FaceID");
            AddForeignKey("dbo.Face", "FaceImage_FaceImageID5", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.Face", "FaceImage_FaceImageID6", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.Face", "StructureOwner_StructureOwnerID2", "dbo.StructureOwner", "StructureOwnerID");
            AddForeignKey("dbo.Face", "StructureType_StructureTypeID2", "dbo.StructureType", "StructureTypeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID2", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID2", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID6", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID5", "dbo.FaceImage");
            DropForeignKey("dbo.FaceImage", "Face1_FaceID1", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID5", "dbo.Face");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID4", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID4", "dbo.StructureOwner");
            DropForeignKey("dbo.FaceImage", "Face_FaceID7", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID6", "dbo.Face");
            DropForeignKey("dbo.Face", "FaceImage1_FaceImageID1", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID11", "dbo.FaceImage");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID2", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID4", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID2", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID3", "dbo.Advertiser");
            DropForeignKey("dbo.User", "RoleID", "dbo.Role");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID4", "dbo.Advertiser");
            DropForeignKey("dbo.Face", "StructureType1_StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureOwner1_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID3", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID3", "dbo.StructureOwner");
            DropForeignKey("dbo.FaceImage", "Face_FaceID11", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID10", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID9", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID8", "dbo.Face");
            DropForeignKey("dbo.Face", "FaceImage3_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage21_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage2_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage11_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID10", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID9", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID8", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID7", "dbo.FaceImage");
            DropForeignKey("dbo.FaceImage", "Face3_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face21_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face2_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face11_FaceID", "dbo.Face");
            DropForeignKey("dbo.Campaign", "Industry1_IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID3", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Advertiser1_AdvertiserID", "dbo.Advertiser");
            DropIndex("dbo.User", new[] { "RoleID" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID11" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID10" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID9" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID8" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID7" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID6" });
            DropIndex("dbo.FaceImage", new[] { "Face3_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face21_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face2_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face11_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face1_FaceID1" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID5" });
            DropIndex("dbo.Face", new[] { "StructureType1_StructureTypeID" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID4" });
            DropIndex("dbo.Face", new[] { "StructureOwner1_StructureOwnerID" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID4" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID3" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID2" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID3" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID2" });
            DropIndex("dbo.Face", new[] { "FaceImage3_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage21_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage2_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage11_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage1_FaceImageID1" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID11" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID10" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID9" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID8" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID7" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID6" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID5" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID4" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID3" });
            DropIndex("dbo.Campaign", new[] { "Industry1_IndustryID" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID4" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID3" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID2" });
            DropIndex("dbo.Campaign", new[] { "Advertiser1_AdvertiserID" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID2" });
            DropColumn("dbo.FaceImage", "Face_FaceID11");
            DropColumn("dbo.FaceImage", "Face_FaceID10");
            DropColumn("dbo.FaceImage", "Face_FaceID9");
            DropColumn("dbo.FaceImage", "Face_FaceID8");
            DropColumn("dbo.FaceImage", "Face_FaceID7");
            DropColumn("dbo.FaceImage", "Face_FaceID6");
            DropColumn("dbo.FaceImage", "Face3_FaceID");
            DropColumn("dbo.FaceImage", "Face21_FaceID");
            DropColumn("dbo.FaceImage", "Face2_FaceID");
            DropColumn("dbo.FaceImage", "Face11_FaceID");
            DropColumn("dbo.FaceImage", "Face1_FaceID1");
            DropColumn("dbo.FaceImage", "Face_FaceID5");
            DropColumn("dbo.Face", "StructureType1_StructureTypeID");
            DropColumn("dbo.Face", "StructureType_StructureTypeID4");
            DropColumn("dbo.Face", "StructureOwner1_StructureOwnerID");
            DropColumn("dbo.Face", "StructureOwner_StructureOwnerID4");
            DropColumn("dbo.Face", "StructureType_StructureTypeID3");
            DropColumn("dbo.Face", "StructureType_StructureTypeID2");
            DropColumn("dbo.Face", "StructureOwner_StructureOwnerID3");
            DropColumn("dbo.Face", "StructureOwner_StructureOwnerID2");
            DropColumn("dbo.Face", "FaceImage3_FaceImageID");
            DropColumn("dbo.Face", "FaceImage21_FaceImageID");
            DropColumn("dbo.Face", "FaceImage2_FaceImageID");
            DropColumn("dbo.Face", "FaceImage11_FaceImageID");
            DropColumn("dbo.Face", "FaceImage1_FaceImageID1");
            DropColumn("dbo.Face", "FaceImage_FaceImageID11");
            DropColumn("dbo.Face", "FaceImage_FaceImageID10");
            DropColumn("dbo.Face", "FaceImage_FaceImageID9");
            DropColumn("dbo.Face", "FaceImage_FaceImageID8");
            DropColumn("dbo.Face", "FaceImage_FaceImageID7");
            DropColumn("dbo.Face", "FaceImage_FaceImageID6");
            DropColumn("dbo.Face", "FaceImage_FaceImageID5");
            DropColumn("dbo.Campaign", "Advertiser_AdvertiserID4");
            DropColumn("dbo.Campaign", "Advertiser_AdvertiserID3");
            DropColumn("dbo.Campaign", "Industry1_IndustryID");
            DropColumn("dbo.Campaign", "Industry_IndustryID4");
            DropColumn("dbo.Campaign", "Industry_IndustryID3");
            DropColumn("dbo.Campaign", "Industry_IndustryID2");
            DropColumn("dbo.Campaign", "Advertiser1_AdvertiserID");
            DropColumn("dbo.Campaign", "Advertiser_AdvertiserID2");
            DropTable("dbo.User");
            DropTable("dbo.Role");
            CreateIndex("dbo.FaceImage", "Face_FaceID4");
            CreateIndex("dbo.FaceImage", "Face_FaceID3");
            CreateIndex("dbo.FaceImage", "Face1_FaceID");
            CreateIndex("dbo.FaceImage", "Face_FaceID2");
            CreateIndex("dbo.Face", "StructureType_StructureTypeID1");
            CreateIndex("dbo.Face", "StructureOwner_StructureOwnerID1");
            CreateIndex("dbo.Face", "FaceImage1_FaceImageID");
            CreateIndex("dbo.Face", "FaceImage_FaceImageID4");
            CreateIndex("dbo.Face", "FaceImage_FaceImageID3");
            CreateIndex("dbo.Face", "FaceImage_FaceImageID2");
            CreateIndex("dbo.Campaign", "Industry_IndustryID1");
            CreateIndex("dbo.Campaign", "Advertiser_AdvertiserID1");
            AddForeignKey("dbo.Face", "FaceImage_FaceImageID3", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.Face", "FaceImage_FaceImageID2", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.FaceImage", "Face1_FaceID", "dbo.Face", "FaceID");
            AddForeignKey("dbo.FaceImage", "Face_FaceID2", "dbo.Face", "FaceID");
            AddForeignKey("dbo.Face", "StructureType_StructureTypeID1", "dbo.StructureType", "StructureTypeID");
            AddForeignKey("dbo.Face", "StructureOwner_StructureOwnerID1", "dbo.StructureOwner", "StructureOwnerID");
            AddForeignKey("dbo.FaceImage", "Face_FaceID4", "dbo.Face", "FaceID");
            AddForeignKey("dbo.FaceImage", "Face_FaceID3", "dbo.Face", "FaceID");
            AddForeignKey("dbo.Face", "FaceImage1_FaceImageID", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.Face", "FaceImage_FaceImageID4", "dbo.FaceImage", "FaceImageID");
            AddForeignKey("dbo.Campaign", "Industry_IndustryID1", "dbo.Industry", "IndustryID");
            AddForeignKey("dbo.Campaign", "Advertiser_AdvertiserID1", "dbo.Advertiser", "AdvertiserID");
        }
    }
}
