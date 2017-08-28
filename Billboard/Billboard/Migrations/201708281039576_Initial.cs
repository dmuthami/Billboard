namespace Billboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FaceAvailability",
                c => new
                    {
                        FaceAvailabilityID = c.Int(nullable: false, identity: true),
                        AvailabilityType = c.String(),
                    })
                .PrimaryKey(t => t.FaceAvailabilityID);
            
            CreateTable(
                "dbo.Face",
                c => new
                    {
                        FaceID = c.Int(nullable: false, identity: true),
                        FaceOccupancyID = c.Int(nullable: false),
                        FaceSizeID = c.Int(nullable: false),
                        FaceImageID = c.Int(nullable: false),
                        FaceConditionID = c.Int(nullable: false),
                        FaceBoundID = c.Int(nullable: false),
                        FacePositionID = c.Int(nullable: false),
                        FaceVisibilityRatingID = c.Int(nullable: false),
                        FaceAvailabilityID = c.Int(nullable: false),
                        StructureID = c.Int(nullable: false),
                        FaceImage_FaceImageID = c.Int(),
                        FaceImage_FaceImageID1 = c.Int(),
                        StructureOwner_StructureOwnerID = c.Int(),
                        StructureType_StructureTypeID = c.Int(),
                        FaceImage_FaceImageID2 = c.Int(),
                        FaceImage_FaceImageID3 = c.Int(),
                        FaceImage_FaceImageID4 = c.Int(),
                        FaceImage1_FaceImageID = c.Int(),
                        StructureOwner_StructureOwnerID1 = c.Int(),
                        StructureType_StructureTypeID1 = c.Int(),
                        FaceImage_FaceImageID5 = c.Int(),
                        FaceImage_FaceImageID6 = c.Int(),
                        FaceImage_FaceImageID7 = c.Int(),
                        FaceImage_FaceImageID8 = c.Int(),
                        FaceImage_FaceImageID9 = c.Int(),
                        FaceImage_FaceImageID10 = c.Int(),
                        FaceImage_FaceImageID11 = c.Int(),
                        FaceImage1_FaceImageID1 = c.Int(),
                        FaceImage11_FaceImageID = c.Int(),
                        FaceImage2_FaceImageID = c.Int(),
                        FaceImage21_FaceImageID = c.Int(),
                        FaceImage3_FaceImageID = c.Int(),
                        StructureOwner_StructureOwnerID2 = c.Int(),
                        StructureOwner_StructureOwnerID3 = c.Int(),
                        StructureType_StructureTypeID2 = c.Int(),
                        StructureType_StructureTypeID3 = c.Int(),
                        StructureOwner_StructureOwnerID4 = c.Int(),
                        StructureOwner1_StructureOwnerID = c.Int(),
                        StructureType_StructureTypeID4 = c.Int(),
                        StructureType1_StructureTypeID = c.Int(),
                        FaceImage_FaceImageID12 = c.Int(),
                        FaceImage_FaceImageID13 = c.Int(),
                        FaceImage_FaceImageID14 = c.Int(),
                        FaceImage_FaceImageID15 = c.Int(),
                        FaceImage_FaceImageID16 = c.Int(),
                        FaceImage_FaceImageID17 = c.Int(),
                        FaceImage_FaceImageID18 = c.Int(),
                        FaceImage_FaceImageID19 = c.Int(),
                        FaceImage_FaceImageID20 = c.Int(),
                        FaceImage_FaceImageID21 = c.Int(),
                        FaceImage_FaceImageID22 = c.Int(),
                        FaceImage_FaceImageID23 = c.Int(),
                        FaceImage_FaceImageID24 = c.Int(),
                        FaceImage_FaceImageID25 = c.Int(),
                        FaceImage_FaceImageID26 = c.Int(),
                        FaceImage_FaceImageID27 = c.Int(),
                        FaceImage_FaceImageID28 = c.Int(),
                        FaceImage_FaceImageID29 = c.Int(),
                        FaceImage_FaceImageID30 = c.Int(),
                        FaceImage1_FaceImageID2 = c.Int(),
                        FaceImage10_FaceImageID = c.Int(),
                        FaceImage11_FaceImageID1 = c.Int(),
                        FaceImage111_FaceImageID = c.Int(),
                        FaceImage12_FaceImageID = c.Int(),
                        FaceImage2_FaceImageID1 = c.Int(),
                        FaceImage21_FaceImageID1 = c.Int(),
                        FaceImage22_FaceImageID = c.Int(),
                        FaceImage3_FaceImageID1 = c.Int(),
                        FaceImage31_FaceImageID = c.Int(),
                        FaceImage4_FaceImageID = c.Int(),
                        FaceImage41_FaceImageID = c.Int(),
                        FaceImage5_FaceImageID = c.Int(),
                        FaceImage6_FaceImageID = c.Int(),
                        FaceImage7_FaceImageID = c.Int(),
                        FaceImage8_FaceImageID = c.Int(),
                        FaceImage9_FaceImageID = c.Int(),
                        StructureOwner_StructureOwnerID5 = c.Int(),
                        StructureOwner_StructureOwnerID6 = c.Int(),
                        StructureOwner_StructureOwnerID7 = c.Int(),
                        StructureOwner_StructureOwnerID8 = c.Int(),
                        StructureOwner_StructureOwnerID9 = c.Int(),
                        StructureOwner_StructureOwnerID10 = c.Int(),
                        StructureType_StructureTypeID5 = c.Int(),
                        StructureType_StructureTypeID6 = c.Int(),
                        StructureType_StructureTypeID7 = c.Int(),
                        StructureType_StructureTypeID8 = c.Int(),
                        StructureType_StructureTypeID9 = c.Int(),
                        StructureType_StructureTypeID10 = c.Int(),
                        StructureOwner_StructureOwnerID11 = c.Int(),
                        StructureOwner1_StructureOwnerID1 = c.Int(),
                        StructureOwner11_StructureOwnerID = c.Int(),
                        StructureOwner2_StructureOwnerID = c.Int(),
                        StructureOwner21_StructureOwnerID = c.Int(),
                        StructureOwner3_StructureOwnerID = c.Int(),
                        StructureType_StructureTypeID11 = c.Int(),
                        StructureType1_StructureTypeID1 = c.Int(),
                        StructureType11_StructureTypeID = c.Int(),
                        StructureType2_StructureTypeID = c.Int(),
                        StructureType21_StructureTypeID = c.Int(),
                        StructureType3_StructureTypeID = c.Int(),
                        FaceImage_FaceImageID31 = c.Int(),
                        FaceImage_FaceImageID32 = c.Int(),
                        FaceImage_FaceImageID33 = c.Int(),
                        FaceImage_FaceImageID34 = c.Int(),
                        FaceImage_FaceImageID35 = c.Int(),
                        FaceImage_FaceImageID36 = c.Int(),
                        FaceImage_FaceImageID37 = c.Int(),
                        FaceImage_FaceImageID38 = c.Int(),
                        FaceImage_FaceImageID39 = c.Int(),
                        FaceImage_FaceImageID40 = c.Int(),
                        FaceImage_FaceImageID41 = c.Int(),
                        FaceImage_FaceImageID42 = c.Int(),
                        FaceImage_FaceImageID43 = c.Int(),
                        FaceImage_FaceImageID44 = c.Int(),
                        FaceImage_FaceImageID45 = c.Int(),
                        FaceImage_FaceImageID46 = c.Int(),
                        FaceImage_FaceImageID47 = c.Int(),
                        FaceImage_FaceImageID48 = c.Int(),
                        FaceImage_FaceImageID49 = c.Int(),
                        FaceImage_FaceImageID50 = c.Int(),
                        FaceImage_FaceImageID51 = c.Int(),
                        FaceImage_FaceImageID52 = c.Int(),
                        FaceImage_FaceImageID53 = c.Int(),
                        FaceImage_FaceImageID54 = c.Int(),
                        FaceImage_FaceImageID55 = c.Int(),
                        FaceImage_FaceImageID56 = c.Int(),
                        FaceImage_FaceImageID57 = c.Int(),
                        FaceImage_FaceImageID58 = c.Int(),
                        FaceImage_FaceImageID59 = c.Int(),
                        FaceImage_FaceImageID60 = c.Int(),
                        FaceImage_FaceImageID61 = c.Int(),
                        FaceImage_FaceImageID62 = c.Int(),
                        FaceImage_FaceImageID63 = c.Int(),
                        FaceImage_FaceImageID64 = c.Int(),
                        FaceImage_FaceImageID65 = c.Int(),
                        FaceImage_FaceImageID66 = c.Int(),
                        FaceImage_FaceImageID67 = c.Int(),
                        FaceImage_FaceImageID68 = c.Int(),
                        FaceImage_FaceImageID69 = c.Int(),
                        FaceImage_FaceImageID70 = c.Int(),
                        FaceImage_FaceImageID71 = c.Int(),
                        FaceImage_FaceImageID72 = c.Int(),
                        FaceImage_FaceImageID73 = c.Int(),
                        FaceImage_FaceImageID74 = c.Int(),
                        FaceImage_FaceImageID75 = c.Int(),
                        FaceImage_FaceImageID76 = c.Int(),
                        FaceImage_FaceImageID77 = c.Int(),
                        FaceImage_FaceImageID78 = c.Int(),
                        FaceImage_FaceImageID79 = c.Int(),
                        FaceImage_FaceImageID80 = c.Int(),
                        FaceImage_FaceImageID81 = c.Int(),
                        FaceImage_FaceImageID82 = c.Int(),
                        FaceImage_FaceImageID83 = c.Int(),
                        FaceImage_FaceImageID84 = c.Int(),
                        FaceImage_FaceImageID85 = c.Int(),
                        FaceImage1_FaceImageID3 = c.Int(),
                        FaceImage10_FaceImageID1 = c.Int(),
                        FaceImage101_FaceImageID = c.Int(),
                        FaceImage11_FaceImageID2 = c.Int(),
                        FaceImage111_FaceImageID1 = c.Int(),
                        FaceImage112_FaceImageID = c.Int(),
                        FaceImage12_FaceImageID1 = c.Int(),
                        FaceImage121_FaceImageID = c.Int(),
                        FaceImage13_FaceImageID = c.Int(),
                        FaceImage131_FaceImageID = c.Int(),
                        FaceImage14_FaceImageID = c.Int(),
                        FaceImage141_FaceImageID = c.Int(),
                        FaceImage15_FaceImageID = c.Int(),
                        FaceImage16_FaceImageID = c.Int(),
                        FaceImage17_FaceImageID = c.Int(),
                        FaceImage18_FaceImageID = c.Int(),
                        FaceImage19_FaceImageID = c.Int(),
                        FaceImage2_FaceImageID2 = c.Int(),
                        FaceImage20_FaceImageID = c.Int(),
                        FaceImage21_FaceImageID2 = c.Int(),
                        FaceImage211_FaceImageID = c.Int(),
                        FaceImage22_FaceImageID1 = c.Int(),
                        FaceImage221_FaceImageID = c.Int(),
                        FaceImage23_FaceImageID = c.Int(),
                        FaceImage231_FaceImageID = c.Int(),
                        FaceImage24_FaceImageID = c.Int(),
                        FaceImage25_FaceImageID = c.Int(),
                        FaceImage26_FaceImageID = c.Int(),
                        FaceImage27_FaceImageID = c.Int(),
                        FaceImage28_FaceImageID = c.Int(),
                        FaceImage29_FaceImageID = c.Int(),
                        FaceImage3_FaceImageID2 = c.Int(),
                        FaceImage30_FaceImageID = c.Int(),
                        FaceImage31_FaceImageID1 = c.Int(),
                        FaceImage311_FaceImageID = c.Int(),
                        FaceImage32_FaceImageID = c.Int(),
                        FaceImage321_FaceImageID = c.Int(),
                        FaceImage33_FaceImageID = c.Int(),
                        FaceImage34_FaceImageID = c.Int(),
                        FaceImage35_FaceImageID = c.Int(),
                        FaceImage4_FaceImageID1 = c.Int(),
                        FaceImage41_FaceImageID1 = c.Int(),
                        FaceImage42_FaceImageID = c.Int(),
                        FaceImage5_FaceImageID1 = c.Int(),
                        FaceImage51_FaceImageID = c.Int(),
                        FaceImage6_FaceImageID1 = c.Int(),
                        FaceImage61_FaceImageID = c.Int(),
                        FaceImage7_FaceImageID1 = c.Int(),
                        FaceImage71_FaceImageID = c.Int(),
                        FaceImage8_FaceImageID1 = c.Int(),
                        FaceImage81_FaceImageID = c.Int(),
                        FaceImage9_FaceImageID1 = c.Int(),
                        FaceImage91_FaceImageID = c.Int(),
                        StructureOwner_StructureOwnerID12 = c.Int(),
                        StructureOwner_StructureOwnerID13 = c.Int(),
                        StructureOwner_StructureOwnerID14 = c.Int(),
                        StructureOwner_StructureOwnerID15 = c.Int(),
                        StructureOwner_StructureOwnerID16 = c.Int(),
                        StructureOwner_StructureOwnerID17 = c.Int(),
                        StructureOwner_StructureOwnerID18 = c.Int(),
                        StructureOwner_StructureOwnerID19 = c.Int(),
                        StructureOwner_StructureOwnerID20 = c.Int(),
                        StructureOwner_StructureOwnerID21 = c.Int(),
                        StructureOwner_StructureOwnerID22 = c.Int(),
                        StructureOwner_StructureOwnerID23 = c.Int(),
                        StructureOwner_StructureOwnerID24 = c.Int(),
                        StructureOwner_StructureOwnerID25 = c.Int(),
                        StructureOwner_StructureOwnerID26 = c.Int(),
                        StructureOwner_StructureOwnerID27 = c.Int(),
                        StructureOwner_StructureOwnerID28 = c.Int(),
                        StructureOwner_StructureOwnerID29 = c.Int(),
                        StructureType_StructureTypeID12 = c.Int(),
                        StructureType_StructureTypeID13 = c.Int(),
                        StructureType_StructureTypeID14 = c.Int(),
                        StructureType_StructureTypeID15 = c.Int(),
                        StructureType_StructureTypeID16 = c.Int(),
                        StructureType_StructureTypeID17 = c.Int(),
                        StructureType_StructureTypeID18 = c.Int(),
                        StructureType_StructureTypeID19 = c.Int(),
                        StructureType_StructureTypeID20 = c.Int(),
                        StructureType_StructureTypeID21 = c.Int(),
                        StructureType_StructureTypeID22 = c.Int(),
                        StructureType_StructureTypeID23 = c.Int(),
                        StructureType_StructureTypeID24 = c.Int(),
                        StructureType_StructureTypeID25 = c.Int(),
                        StructureType_StructureTypeID26 = c.Int(),
                        StructureType_StructureTypeID27 = c.Int(),
                        StructureType_StructureTypeID28 = c.Int(),
                        StructureType_StructureTypeID29 = c.Int(),
                        StructureOwner_StructureOwnerID30 = c.Int(),
                        StructureOwner1_StructureOwnerID2 = c.Int(),
                        StructureOwner10_StructureOwnerID = c.Int(),
                        StructureOwner11_StructureOwnerID1 = c.Int(),
                        StructureOwner111_StructureOwnerID = c.Int(),
                        StructureOwner12_StructureOwnerID = c.Int(),
                        StructureOwner2_StructureOwnerID1 = c.Int(),
                        StructureOwner21_StructureOwnerID1 = c.Int(),
                        StructureOwner22_StructureOwnerID = c.Int(),
                        StructureOwner3_StructureOwnerID1 = c.Int(),
                        StructureOwner31_StructureOwnerID = c.Int(),
                        StructureOwner4_StructureOwnerID = c.Int(),
                        StructureOwner41_StructureOwnerID = c.Int(),
                        StructureOwner5_StructureOwnerID = c.Int(),
                        StructureOwner6_StructureOwnerID = c.Int(),
                        StructureOwner7_StructureOwnerID = c.Int(),
                        StructureOwner8_StructureOwnerID = c.Int(),
                        StructureOwner9_StructureOwnerID = c.Int(),
                        StructureType_StructureTypeID30 = c.Int(),
                        StructureType1_StructureTypeID2 = c.Int(),
                        StructureType10_StructureTypeID = c.Int(),
                        StructureType11_StructureTypeID1 = c.Int(),
                        StructureType111_StructureTypeID = c.Int(),
                        StructureType12_StructureTypeID = c.Int(),
                        StructureType2_StructureTypeID1 = c.Int(),
                        StructureType21_StructureTypeID1 = c.Int(),
                        StructureType22_StructureTypeID = c.Int(),
                        StructureType3_StructureTypeID1 = c.Int(),
                        StructureType31_StructureTypeID = c.Int(),
                        StructureType4_StructureTypeID = c.Int(),
                        StructureType41_StructureTypeID = c.Int(),
                        StructureType5_StructureTypeID = c.Int(),
                        StructureType6_StructureTypeID = c.Int(),
                        StructureType7_StructureTypeID = c.Int(),
                        StructureType8_StructureTypeID = c.Int(),
                        StructureType9_StructureTypeID = c.Int(),
                    })
                .PrimaryKey(t => t.FaceID)
                .ForeignKey("dbo.FaceAvailability", t => t.FaceAvailabilityID)
                .ForeignKey("dbo.FaceBound", t => t.FaceBoundID)
                .ForeignKey("dbo.FaceCondition", t => t.FaceConditionID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID31)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID32)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID33)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID34)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID35)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID36)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID37)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID38)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID39)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID40)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID41)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID42)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID43)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID44)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID45)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID46)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID47)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID48)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID49)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID50)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID51)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID52)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID53)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID54)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID55)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID56)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID57)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID58)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID59)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID60)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID61)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID62)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID63)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID64)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID65)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID66)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID67)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID68)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID69)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID70)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID71)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID72)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID73)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID74)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID75)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID76)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID77)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID78)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID79)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID80)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID81)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID82)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID83)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID84)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID85)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage1_FaceImageID3)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage10_FaceImageID1)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage101_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage11_FaceImageID2)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage111_FaceImageID1)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage112_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage12_FaceImageID1)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage121_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage13_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage131_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage14_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage141_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage15_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage16_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage17_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage18_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage19_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage2_FaceImageID2)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage20_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage21_FaceImageID2)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage211_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage22_FaceImageID1)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage221_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage23_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage231_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage24_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage25_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage26_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage27_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage28_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage29_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage3_FaceImageID2)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage30_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage31_FaceImageID1)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage311_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage32_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage321_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage33_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage34_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage35_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage4_FaceImageID1)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage41_FaceImageID1)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage42_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage5_FaceImageID1)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage51_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage6_FaceImageID1)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage61_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage7_FaceImageID1)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage71_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage8_FaceImageID1)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage81_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage9_FaceImageID1)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage91_FaceImageID)
                .ForeignKey("dbo.FaceOccupancy", t => t.FaceOccupancyID)
                .ForeignKey("dbo.FacePosition", t => t.FacePositionID)
                .ForeignKey("dbo.FaceSize", t => t.FaceSizeID)
                .ForeignKey("dbo.FaceVisibilityRating", t => t.FaceVisibilityRatingID)
                .ForeignKey("dbo.Structure", t => t.StructureID)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID12)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID13)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID14)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID15)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID16)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID17)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID18)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID19)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID20)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID21)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID22)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID23)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID24)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID25)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID26)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID27)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID28)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID29)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID12)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID13)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID14)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID15)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID16)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID17)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID18)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID19)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID20)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID21)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID22)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID23)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID24)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID25)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID26)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID27)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID28)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID29)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID30)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner1_StructureOwnerID2)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner10_StructureOwnerID)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner11_StructureOwnerID1)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner111_StructureOwnerID)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner12_StructureOwnerID)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner2_StructureOwnerID1)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner21_StructureOwnerID1)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner22_StructureOwnerID)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner3_StructureOwnerID1)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner31_StructureOwnerID)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner4_StructureOwnerID)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner41_StructureOwnerID)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner5_StructureOwnerID)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner6_StructureOwnerID)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner7_StructureOwnerID)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner8_StructureOwnerID)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner9_StructureOwnerID)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID30)
                .ForeignKey("dbo.StructureType", t => t.StructureType1_StructureTypeID2)
                .ForeignKey("dbo.StructureType", t => t.StructureType10_StructureTypeID)
                .ForeignKey("dbo.StructureType", t => t.StructureType11_StructureTypeID1)
                .ForeignKey("dbo.StructureType", t => t.StructureType111_StructureTypeID)
                .ForeignKey("dbo.StructureType", t => t.StructureType12_StructureTypeID)
                .ForeignKey("dbo.StructureType", t => t.StructureType2_StructureTypeID1)
                .ForeignKey("dbo.StructureType", t => t.StructureType21_StructureTypeID1)
                .ForeignKey("dbo.StructureType", t => t.StructureType22_StructureTypeID)
                .ForeignKey("dbo.StructureType", t => t.StructureType3_StructureTypeID1)
                .ForeignKey("dbo.StructureType", t => t.StructureType31_StructureTypeID)
                .ForeignKey("dbo.StructureType", t => t.StructureType4_StructureTypeID)
                .ForeignKey("dbo.StructureType", t => t.StructureType41_StructureTypeID)
                .ForeignKey("dbo.StructureType", t => t.StructureType5_StructureTypeID)
                .ForeignKey("dbo.StructureType", t => t.StructureType6_StructureTypeID)
                .ForeignKey("dbo.StructureType", t => t.StructureType7_StructureTypeID)
                .ForeignKey("dbo.StructureType", t => t.StructureType8_StructureTypeID)
                .ForeignKey("dbo.StructureType", t => t.StructureType9_StructureTypeID)
                .Index(t => t.FaceOccupancyID)
                .Index(t => t.FaceSizeID)
                .Index(t => t.FaceConditionID)
                .Index(t => t.FaceBoundID)
                .Index(t => t.FacePositionID)
                .Index(t => t.FaceVisibilityRatingID)
                .Index(t => t.FaceAvailabilityID)
                .Index(t => t.StructureID)
                .Index(t => t.FaceImage_FaceImageID31)
                .Index(t => t.FaceImage_FaceImageID32)
                .Index(t => t.FaceImage_FaceImageID33)
                .Index(t => t.FaceImage_FaceImageID34)
                .Index(t => t.FaceImage_FaceImageID35)
                .Index(t => t.FaceImage_FaceImageID36)
                .Index(t => t.FaceImage_FaceImageID37)
                .Index(t => t.FaceImage_FaceImageID38)
                .Index(t => t.FaceImage_FaceImageID39)
                .Index(t => t.FaceImage_FaceImageID40)
                .Index(t => t.FaceImage_FaceImageID41)
                .Index(t => t.FaceImage_FaceImageID42)
                .Index(t => t.FaceImage_FaceImageID43)
                .Index(t => t.FaceImage_FaceImageID44)
                .Index(t => t.FaceImage_FaceImageID45)
                .Index(t => t.FaceImage_FaceImageID46)
                .Index(t => t.FaceImage_FaceImageID47)
                .Index(t => t.FaceImage_FaceImageID48)
                .Index(t => t.FaceImage_FaceImageID49)
                .Index(t => t.FaceImage_FaceImageID50)
                .Index(t => t.FaceImage_FaceImageID51)
                .Index(t => t.FaceImage_FaceImageID52)
                .Index(t => t.FaceImage_FaceImageID53)
                .Index(t => t.FaceImage_FaceImageID54)
                .Index(t => t.FaceImage_FaceImageID55)
                .Index(t => t.FaceImage_FaceImageID56)
                .Index(t => t.FaceImage_FaceImageID57)
                .Index(t => t.FaceImage_FaceImageID58)
                .Index(t => t.FaceImage_FaceImageID59)
                .Index(t => t.FaceImage_FaceImageID60)
                .Index(t => t.FaceImage_FaceImageID61)
                .Index(t => t.FaceImage_FaceImageID62)
                .Index(t => t.FaceImage_FaceImageID63)
                .Index(t => t.FaceImage_FaceImageID64)
                .Index(t => t.FaceImage_FaceImageID65)
                .Index(t => t.FaceImage_FaceImageID66)
                .Index(t => t.FaceImage_FaceImageID67)
                .Index(t => t.FaceImage_FaceImageID68)
                .Index(t => t.FaceImage_FaceImageID69)
                .Index(t => t.FaceImage_FaceImageID70)
                .Index(t => t.FaceImage_FaceImageID71)
                .Index(t => t.FaceImage_FaceImageID72)
                .Index(t => t.FaceImage_FaceImageID73)
                .Index(t => t.FaceImage_FaceImageID74)
                .Index(t => t.FaceImage_FaceImageID75)
                .Index(t => t.FaceImage_FaceImageID76)
                .Index(t => t.FaceImage_FaceImageID77)
                .Index(t => t.FaceImage_FaceImageID78)
                .Index(t => t.FaceImage_FaceImageID79)
                .Index(t => t.FaceImage_FaceImageID80)
                .Index(t => t.FaceImage_FaceImageID81)
                .Index(t => t.FaceImage_FaceImageID82)
                .Index(t => t.FaceImage_FaceImageID83)
                .Index(t => t.FaceImage_FaceImageID84)
                .Index(t => t.FaceImage_FaceImageID85)
                .Index(t => t.FaceImage1_FaceImageID3)
                .Index(t => t.FaceImage10_FaceImageID1)
                .Index(t => t.FaceImage101_FaceImageID)
                .Index(t => t.FaceImage11_FaceImageID2)
                .Index(t => t.FaceImage111_FaceImageID1)
                .Index(t => t.FaceImage112_FaceImageID)
                .Index(t => t.FaceImage12_FaceImageID1)
                .Index(t => t.FaceImage121_FaceImageID)
                .Index(t => t.FaceImage13_FaceImageID)
                .Index(t => t.FaceImage131_FaceImageID)
                .Index(t => t.FaceImage14_FaceImageID)
                .Index(t => t.FaceImage141_FaceImageID)
                .Index(t => t.FaceImage15_FaceImageID)
                .Index(t => t.FaceImage16_FaceImageID)
                .Index(t => t.FaceImage17_FaceImageID)
                .Index(t => t.FaceImage18_FaceImageID)
                .Index(t => t.FaceImage19_FaceImageID)
                .Index(t => t.FaceImage2_FaceImageID2)
                .Index(t => t.FaceImage20_FaceImageID)
                .Index(t => t.FaceImage21_FaceImageID2)
                .Index(t => t.FaceImage211_FaceImageID)
                .Index(t => t.FaceImage22_FaceImageID1)
                .Index(t => t.FaceImage221_FaceImageID)
                .Index(t => t.FaceImage23_FaceImageID)
                .Index(t => t.FaceImage231_FaceImageID)
                .Index(t => t.FaceImage24_FaceImageID)
                .Index(t => t.FaceImage25_FaceImageID)
                .Index(t => t.FaceImage26_FaceImageID)
                .Index(t => t.FaceImage27_FaceImageID)
                .Index(t => t.FaceImage28_FaceImageID)
                .Index(t => t.FaceImage29_FaceImageID)
                .Index(t => t.FaceImage3_FaceImageID2)
                .Index(t => t.FaceImage30_FaceImageID)
                .Index(t => t.FaceImage31_FaceImageID1)
                .Index(t => t.FaceImage311_FaceImageID)
                .Index(t => t.FaceImage32_FaceImageID)
                .Index(t => t.FaceImage321_FaceImageID)
                .Index(t => t.FaceImage33_FaceImageID)
                .Index(t => t.FaceImage34_FaceImageID)
                .Index(t => t.FaceImage35_FaceImageID)
                .Index(t => t.FaceImage4_FaceImageID1)
                .Index(t => t.FaceImage41_FaceImageID1)
                .Index(t => t.FaceImage42_FaceImageID)
                .Index(t => t.FaceImage5_FaceImageID1)
                .Index(t => t.FaceImage51_FaceImageID)
                .Index(t => t.FaceImage6_FaceImageID1)
                .Index(t => t.FaceImage61_FaceImageID)
                .Index(t => t.FaceImage7_FaceImageID1)
                .Index(t => t.FaceImage71_FaceImageID)
                .Index(t => t.FaceImage8_FaceImageID1)
                .Index(t => t.FaceImage81_FaceImageID)
                .Index(t => t.FaceImage9_FaceImageID1)
                .Index(t => t.FaceImage91_FaceImageID)
                .Index(t => t.StructureOwner_StructureOwnerID12)
                .Index(t => t.StructureOwner_StructureOwnerID13)
                .Index(t => t.StructureOwner_StructureOwnerID14)
                .Index(t => t.StructureOwner_StructureOwnerID15)
                .Index(t => t.StructureOwner_StructureOwnerID16)
                .Index(t => t.StructureOwner_StructureOwnerID17)
                .Index(t => t.StructureOwner_StructureOwnerID18)
                .Index(t => t.StructureOwner_StructureOwnerID19)
                .Index(t => t.StructureOwner_StructureOwnerID20)
                .Index(t => t.StructureOwner_StructureOwnerID21)
                .Index(t => t.StructureOwner_StructureOwnerID22)
                .Index(t => t.StructureOwner_StructureOwnerID23)
                .Index(t => t.StructureOwner_StructureOwnerID24)
                .Index(t => t.StructureOwner_StructureOwnerID25)
                .Index(t => t.StructureOwner_StructureOwnerID26)
                .Index(t => t.StructureOwner_StructureOwnerID27)
                .Index(t => t.StructureOwner_StructureOwnerID28)
                .Index(t => t.StructureOwner_StructureOwnerID29)
                .Index(t => t.StructureType_StructureTypeID12)
                .Index(t => t.StructureType_StructureTypeID13)
                .Index(t => t.StructureType_StructureTypeID14)
                .Index(t => t.StructureType_StructureTypeID15)
                .Index(t => t.StructureType_StructureTypeID16)
                .Index(t => t.StructureType_StructureTypeID17)
                .Index(t => t.StructureType_StructureTypeID18)
                .Index(t => t.StructureType_StructureTypeID19)
                .Index(t => t.StructureType_StructureTypeID20)
                .Index(t => t.StructureType_StructureTypeID21)
                .Index(t => t.StructureType_StructureTypeID22)
                .Index(t => t.StructureType_StructureTypeID23)
                .Index(t => t.StructureType_StructureTypeID24)
                .Index(t => t.StructureType_StructureTypeID25)
                .Index(t => t.StructureType_StructureTypeID26)
                .Index(t => t.StructureType_StructureTypeID27)
                .Index(t => t.StructureType_StructureTypeID28)
                .Index(t => t.StructureType_StructureTypeID29)
                .Index(t => t.StructureOwner_StructureOwnerID30)
                .Index(t => t.StructureOwner1_StructureOwnerID2)
                .Index(t => t.StructureOwner10_StructureOwnerID)
                .Index(t => t.StructureOwner11_StructureOwnerID1)
                .Index(t => t.StructureOwner111_StructureOwnerID)
                .Index(t => t.StructureOwner12_StructureOwnerID)
                .Index(t => t.StructureOwner2_StructureOwnerID1)
                .Index(t => t.StructureOwner21_StructureOwnerID1)
                .Index(t => t.StructureOwner22_StructureOwnerID)
                .Index(t => t.StructureOwner3_StructureOwnerID1)
                .Index(t => t.StructureOwner31_StructureOwnerID)
                .Index(t => t.StructureOwner4_StructureOwnerID)
                .Index(t => t.StructureOwner41_StructureOwnerID)
                .Index(t => t.StructureOwner5_StructureOwnerID)
                .Index(t => t.StructureOwner6_StructureOwnerID)
                .Index(t => t.StructureOwner7_StructureOwnerID)
                .Index(t => t.StructureOwner8_StructureOwnerID)
                .Index(t => t.StructureOwner9_StructureOwnerID)
                .Index(t => t.StructureType_StructureTypeID30)
                .Index(t => t.StructureType1_StructureTypeID2)
                .Index(t => t.StructureType10_StructureTypeID)
                .Index(t => t.StructureType11_StructureTypeID1)
                .Index(t => t.StructureType111_StructureTypeID)
                .Index(t => t.StructureType12_StructureTypeID)
                .Index(t => t.StructureType2_StructureTypeID1)
                .Index(t => t.StructureType21_StructureTypeID1)
                .Index(t => t.StructureType22_StructureTypeID)
                .Index(t => t.StructureType3_StructureTypeID1)
                .Index(t => t.StructureType31_StructureTypeID)
                .Index(t => t.StructureType4_StructureTypeID)
                .Index(t => t.StructureType41_StructureTypeID)
                .Index(t => t.StructureType5_StructureTypeID)
                .Index(t => t.StructureType6_StructureTypeID)
                .Index(t => t.StructureType7_StructureTypeID)
                .Index(t => t.StructureType8_StructureTypeID)
                .Index(t => t.StructureType9_StructureTypeID);
            
            CreateTable(
                "dbo.Advert",
                c => new
                    {
                        AdvertID = c.Int(nullable: false, identity: true),
                        FaceID = c.Int(nullable: false),
                        AdvertiserID = c.Int(nullable: false),
                        CampaignID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AdvertID)
                .ForeignKey("dbo.Advertiser", t => t.AdvertiserID)
                .ForeignKey("dbo.Campaign", t => t.CampaignID)
                .ForeignKey("dbo.Face", t => t.FaceID)
                .Index(t => t.FaceID)
                .Index(t => t.AdvertiserID)
                .Index(t => t.CampaignID);
            
            CreateTable(
                "dbo.Advertiser",
                c => new
                    {
                        AdvertiserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Contact = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Detail = c.String(),
                    })
                .PrimaryKey(t => t.AdvertiserID);
            
            CreateTable(
                "dbo.Campaign",
                c => new
                    {
                        CampaignID = c.Int(nullable: false, identity: true),
                        CampaignName = c.String(),
                        ProductID = c.Int(nullable: false),
                        AgencyID = c.Int(nullable: false),
                        Advertiser_AdvertiserID = c.Int(),
                        Industry_IndustryID = c.Int(),
                        Advertiser_AdvertiserID1 = c.Int(),
                        Industry_IndustryID1 = c.Int(),
                        Advertiser_AdvertiserID2 = c.Int(),
                        Advertiser1_AdvertiserID = c.Int(),
                        Industry_IndustryID2 = c.Int(),
                        Industry_IndustryID3 = c.Int(),
                        Industry_IndustryID4 = c.Int(),
                        Industry1_IndustryID = c.Int(),
                        Advertiser_AdvertiserID3 = c.Int(),
                        Advertiser_AdvertiserID4 = c.Int(),
                        Advertiser_AdvertiserID5 = c.Int(),
                        Advertiser1_AdvertiserID1 = c.Int(),
                        Advertiser11_AdvertiserID = c.Int(),
                        Advertiser2_AdvertiserID = c.Int(),
                        Advertiser21_AdvertiserID = c.Int(),
                        Advertiser3_AdvertiserID = c.Int(),
                        Industry_IndustryID5 = c.Int(),
                        Industry_IndustryID6 = c.Int(),
                        Industry_IndustryID7 = c.Int(),
                        Industry_IndustryID8 = c.Int(),
                        Industry_IndustryID9 = c.Int(),
                        Industry_IndustryID10 = c.Int(),
                        Industry_IndustryID11 = c.Int(),
                        Industry1_IndustryID1 = c.Int(),
                        Industry11_IndustryID = c.Int(),
                        Industry2_IndustryID = c.Int(),
                        Industry21_IndustryID = c.Int(),
                        Industry3_IndustryID = c.Int(),
                        Advertiser_AdvertiserID6 = c.Int(),
                        Advertiser_AdvertiserID7 = c.Int(),
                        Advertiser_AdvertiserID8 = c.Int(),
                        Advertiser_AdvertiserID9 = c.Int(),
                        Advertiser_AdvertiserID10 = c.Int(),
                        Advertiser_AdvertiserID11 = c.Int(),
                        Advertiser_AdvertiserID12 = c.Int(),
                        Advertiser1_AdvertiserID2 = c.Int(),
                        Advertiser10_AdvertiserID = c.Int(),
                        Advertiser11_AdvertiserID1 = c.Int(),
                        Advertiser111_AdvertiserID = c.Int(),
                        Advertiser12_AdvertiserID = c.Int(),
                        Advertiser2_AdvertiserID1 = c.Int(),
                        Advertiser21_AdvertiserID1 = c.Int(),
                        Advertiser22_AdvertiserID = c.Int(),
                        Advertiser3_AdvertiserID1 = c.Int(),
                        Advertiser31_AdvertiserID = c.Int(),
                        Advertiser4_AdvertiserID = c.Int(),
                        Advertiser41_AdvertiserID = c.Int(),
                        Advertiser5_AdvertiserID = c.Int(),
                        Advertiser6_AdvertiserID = c.Int(),
                        Advertiser7_AdvertiserID = c.Int(),
                        Advertiser8_AdvertiserID = c.Int(),
                        Advertiser9_AdvertiserID = c.Int(),
                        Industry_IndustryID12 = c.Int(),
                        Industry_IndustryID13 = c.Int(),
                        Industry_IndustryID14 = c.Int(),
                        Industry_IndustryID15 = c.Int(),
                        Industry_IndustryID16 = c.Int(),
                        Industry_IndustryID17 = c.Int(),
                        Industry_IndustryID18 = c.Int(),
                        Industry_IndustryID19 = c.Int(),
                        Industry_IndustryID20 = c.Int(),
                        Industry_IndustryID21 = c.Int(),
                        Industry_IndustryID22 = c.Int(),
                        Industry_IndustryID23 = c.Int(),
                        Industry_IndustryID24 = c.Int(),
                        Industry_IndustryID25 = c.Int(),
                        Industry_IndustryID26 = c.Int(),
                        Industry_IndustryID27 = c.Int(),
                        Industry_IndustryID28 = c.Int(),
                        Industry_IndustryID29 = c.Int(),
                        Industry_IndustryID30 = c.Int(),
                        Industry1_IndustryID2 = c.Int(),
                        Industry10_IndustryID = c.Int(),
                        Industry11_IndustryID1 = c.Int(),
                        Industry111_IndustryID = c.Int(),
                        Industry12_IndustryID = c.Int(),
                        Industry2_IndustryID1 = c.Int(),
                        Industry21_IndustryID1 = c.Int(),
                        Industry22_IndustryID = c.Int(),
                        Industry3_IndustryID1 = c.Int(),
                        Industry31_IndustryID = c.Int(),
                        Industry4_IndustryID = c.Int(),
                        Industry41_IndustryID = c.Int(),
                        Industry5_IndustryID = c.Int(),
                        Industry6_IndustryID = c.Int(),
                        Industry7_IndustryID = c.Int(),
                        Industry8_IndustryID = c.Int(),
                        Industry9_IndustryID = c.Int(),
                        Advertiser_AdvertiserID13 = c.Int(),
                        Advertiser_AdvertiserID14 = c.Int(),
                        Advertiser_AdvertiserID15 = c.Int(),
                        Advertiser_AdvertiserID16 = c.Int(),
                        Advertiser_AdvertiserID17 = c.Int(),
                        Advertiser_AdvertiserID18 = c.Int(),
                        Advertiser_AdvertiserID19 = c.Int(),
                        Advertiser_AdvertiserID20 = c.Int(),
                        Advertiser_AdvertiserID21 = c.Int(),
                        Advertiser_AdvertiserID22 = c.Int(),
                        Advertiser_AdvertiserID23 = c.Int(),
                        Advertiser_AdvertiserID24 = c.Int(),
                        Advertiser_AdvertiserID25 = c.Int(),
                        Advertiser_AdvertiserID26 = c.Int(),
                        Advertiser_AdvertiserID27 = c.Int(),
                        Advertiser_AdvertiserID28 = c.Int(),
                        Advertiser_AdvertiserID29 = c.Int(),
                        Advertiser_AdvertiserID30 = c.Int(),
                    })
                .PrimaryKey(t => t.CampaignID)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID12)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser1_AdvertiserID2)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser10_AdvertiserID)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser11_AdvertiserID1)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser111_AdvertiserID)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser12_AdvertiserID)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser2_AdvertiserID1)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser21_AdvertiserID1)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser22_AdvertiserID)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser3_AdvertiserID1)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser31_AdvertiserID)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser4_AdvertiserID)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser41_AdvertiserID)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser5_AdvertiserID)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser6_AdvertiserID)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser7_AdvertiserID)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser8_AdvertiserID)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser9_AdvertiserID)
                .ForeignKey("dbo.Agency", t => t.AgencyID)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID12)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID13)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID14)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID15)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID16)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID17)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID18)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID19)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID20)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID21)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID22)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID23)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID24)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID25)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID26)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID27)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID28)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID29)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID30)
                .ForeignKey("dbo.Industry", t => t.Industry1_IndustryID2)
                .ForeignKey("dbo.Industry", t => t.Industry10_IndustryID)
                .ForeignKey("dbo.Industry", t => t.Industry11_IndustryID1)
                .ForeignKey("dbo.Industry", t => t.Industry111_IndustryID)
                .ForeignKey("dbo.Industry", t => t.Industry12_IndustryID)
                .ForeignKey("dbo.Industry", t => t.Industry2_IndustryID1)
                .ForeignKey("dbo.Industry", t => t.Industry21_IndustryID1)
                .ForeignKey("dbo.Industry", t => t.Industry22_IndustryID)
                .ForeignKey("dbo.Industry", t => t.Industry3_IndustryID1)
                .ForeignKey("dbo.Industry", t => t.Industry31_IndustryID)
                .ForeignKey("dbo.Industry", t => t.Industry4_IndustryID)
                .ForeignKey("dbo.Industry", t => t.Industry41_IndustryID)
                .ForeignKey("dbo.Industry", t => t.Industry5_IndustryID)
                .ForeignKey("dbo.Industry", t => t.Industry6_IndustryID)
                .ForeignKey("dbo.Industry", t => t.Industry7_IndustryID)
                .ForeignKey("dbo.Industry", t => t.Industry8_IndustryID)
                .ForeignKey("dbo.Industry", t => t.Industry9_IndustryID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID13)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID14)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID15)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID16)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID17)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID18)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID19)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID20)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID21)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID22)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID23)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID24)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID25)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID26)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID27)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID28)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID29)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID30)
                .Index(t => t.ProductID)
                .Index(t => t.AgencyID)
                .Index(t => t.Advertiser_AdvertiserID12)
                .Index(t => t.Advertiser1_AdvertiserID2)
                .Index(t => t.Advertiser10_AdvertiserID)
                .Index(t => t.Advertiser11_AdvertiserID1)
                .Index(t => t.Advertiser111_AdvertiserID)
                .Index(t => t.Advertiser12_AdvertiserID)
                .Index(t => t.Advertiser2_AdvertiserID1)
                .Index(t => t.Advertiser21_AdvertiserID1)
                .Index(t => t.Advertiser22_AdvertiserID)
                .Index(t => t.Advertiser3_AdvertiserID1)
                .Index(t => t.Advertiser31_AdvertiserID)
                .Index(t => t.Advertiser4_AdvertiserID)
                .Index(t => t.Advertiser41_AdvertiserID)
                .Index(t => t.Advertiser5_AdvertiserID)
                .Index(t => t.Advertiser6_AdvertiserID)
                .Index(t => t.Advertiser7_AdvertiserID)
                .Index(t => t.Advertiser8_AdvertiserID)
                .Index(t => t.Advertiser9_AdvertiserID)
                .Index(t => t.Industry_IndustryID12)
                .Index(t => t.Industry_IndustryID13)
                .Index(t => t.Industry_IndustryID14)
                .Index(t => t.Industry_IndustryID15)
                .Index(t => t.Industry_IndustryID16)
                .Index(t => t.Industry_IndustryID17)
                .Index(t => t.Industry_IndustryID18)
                .Index(t => t.Industry_IndustryID19)
                .Index(t => t.Industry_IndustryID20)
                .Index(t => t.Industry_IndustryID21)
                .Index(t => t.Industry_IndustryID22)
                .Index(t => t.Industry_IndustryID23)
                .Index(t => t.Industry_IndustryID24)
                .Index(t => t.Industry_IndustryID25)
                .Index(t => t.Industry_IndustryID26)
                .Index(t => t.Industry_IndustryID27)
                .Index(t => t.Industry_IndustryID28)
                .Index(t => t.Industry_IndustryID29)
                .Index(t => t.Industry_IndustryID30)
                .Index(t => t.Industry1_IndustryID2)
                .Index(t => t.Industry10_IndustryID)
                .Index(t => t.Industry11_IndustryID1)
                .Index(t => t.Industry111_IndustryID)
                .Index(t => t.Industry12_IndustryID)
                .Index(t => t.Industry2_IndustryID1)
                .Index(t => t.Industry21_IndustryID1)
                .Index(t => t.Industry22_IndustryID)
                .Index(t => t.Industry3_IndustryID1)
                .Index(t => t.Industry31_IndustryID)
                .Index(t => t.Industry4_IndustryID)
                .Index(t => t.Industry41_IndustryID)
                .Index(t => t.Industry5_IndustryID)
                .Index(t => t.Industry6_IndustryID)
                .Index(t => t.Industry7_IndustryID)
                .Index(t => t.Industry8_IndustryID)
                .Index(t => t.Industry9_IndustryID)
                .Index(t => t.Advertiser_AdvertiserID13)
                .Index(t => t.Advertiser_AdvertiserID14)
                .Index(t => t.Advertiser_AdvertiserID15)
                .Index(t => t.Advertiser_AdvertiserID16)
                .Index(t => t.Advertiser_AdvertiserID17)
                .Index(t => t.Advertiser_AdvertiserID18)
                .Index(t => t.Advertiser_AdvertiserID19)
                .Index(t => t.Advertiser_AdvertiserID20)
                .Index(t => t.Advertiser_AdvertiserID21)
                .Index(t => t.Advertiser_AdvertiserID22)
                .Index(t => t.Advertiser_AdvertiserID23)
                .Index(t => t.Advertiser_AdvertiserID24)
                .Index(t => t.Advertiser_AdvertiserID25)
                .Index(t => t.Advertiser_AdvertiserID26)
                .Index(t => t.Advertiser_AdvertiserID27)
                .Index(t => t.Advertiser_AdvertiserID28)
                .Index(t => t.Advertiser_AdvertiserID29)
                .Index(t => t.Advertiser_AdvertiserID30);
            
            CreateTable(
                "dbo.Agency",
                c => new
                    {
                        AgencyID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ContactPerson = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.AgencyID);
            
            CreateTable(
                "dbo.Subscription",
                c => new
                    {
                        SubscriptionID = c.Int(nullable: false),
                        Amount = c.Double(),
                        Paid = c.Double(),
                        StartDate = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.SubscriptionID)
                .ForeignKey("dbo.Agency", t => t.SubscriptionID)
                .Index(t => t.SubscriptionID);
            
            CreateTable(
                "dbo.CampaignDevice",
                c => new
                    {
                        CampaignDeviceID = c.Int(nullable: false, identity: true),
                        CampaignID = c.Int(nullable: false),
                        DeviceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CampaignDeviceID)
                .ForeignKey("dbo.Campaign", t => t.CampaignID)
                .ForeignKey("dbo.Device", t => t.DeviceID)
                .Index(t => t.CampaignID)
                .Index(t => t.DeviceID);
            
            CreateTable(
                "dbo.Device",
                c => new
                    {
                        DeviceID = c.Int(nullable: false, identity: true),
                        IMEI = c.String(),
                        Name = c.String(),
                        SerialNo = c.String(),
                        DeviceStatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DeviceID)
                .ForeignKey("dbo.DeviceStatus", t => t.DeviceStatusID)
                .Index(t => t.DeviceStatusID);
            
            CreateTable(
                "dbo.DeviceStatus",
                c => new
                    {
                        DeviceStatusID = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.DeviceStatusID);
            
            CreateTable(
                "dbo.CampaignRoute",
                c => new
                    {
                        CampaignRouteID = c.Int(nullable: false, identity: true),
                        CampaignID = c.Int(nullable: false),
                        RouteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CampaignRouteID)
                .ForeignKey("dbo.Campaign", t => t.CampaignID)
                .ForeignKey("dbo.Route", t => t.RouteID)
                .Index(t => t.CampaignID)
                .Index(t => t.RouteID);
            
            CreateTable(
                "dbo.Route",
                c => new
                    {
                        RouteID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.RouteID);
            
            CreateTable(
                "dbo.Industry",
                c => new
                    {
                        IndustryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IndustryID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateTable(
                "dbo.FaceBound",
                c => new
                    {
                        FaceBoundID = c.Int(nullable: false, identity: true),
                        Bound = c.String(),
                    })
                .PrimaryKey(t => t.FaceBoundID);
            
            CreateTable(
                "dbo.FaceCondition",
                c => new
                    {
                        FaceConditionID = c.Int(nullable: false, identity: true),
                        Condition = c.String(),
                    })
                .PrimaryKey(t => t.FaceConditionID);
            
            CreateTable(
                "dbo.FaceImage",
                c => new
                    {
                        FaceImageID = c.Int(nullable: false, identity: true),
                        Image = c.Binary(),
                        TimeStamp = c.DateTime(nullable: false),
                        Face_FaceID = c.Int(),
                        Face_FaceID1 = c.Int(),
                        Face_FaceID2 = c.Int(),
                        Face1_FaceID = c.Int(),
                        Face_FaceID3 = c.Int(),
                        Face_FaceID4 = c.Int(),
                        Face_FaceID5 = c.Int(),
                        Face1_FaceID1 = c.Int(),
                        Face11_FaceID = c.Int(),
                        Face2_FaceID = c.Int(),
                        Face21_FaceID = c.Int(),
                        Face3_FaceID = c.Int(),
                        Face_FaceID6 = c.Int(),
                        Face_FaceID7 = c.Int(),
                        Face_FaceID8 = c.Int(),
                        Face_FaceID9 = c.Int(),
                        Face_FaceID10 = c.Int(),
                        Face_FaceID11 = c.Int(),
                        Face_FaceID12 = c.Int(),
                        Face1_FaceID2 = c.Int(),
                        Face10_FaceID = c.Int(),
                        Face11_FaceID1 = c.Int(),
                        Face111_FaceID = c.Int(),
                        Face12_FaceID = c.Int(),
                        Face2_FaceID1 = c.Int(),
                        Face21_FaceID1 = c.Int(),
                        Face22_FaceID = c.Int(),
                        Face3_FaceID1 = c.Int(),
                        Face31_FaceID = c.Int(),
                        Face4_FaceID = c.Int(),
                        Face41_FaceID = c.Int(),
                        Face5_FaceID = c.Int(),
                        Face6_FaceID = c.Int(),
                        Face7_FaceID = c.Int(),
                        Face8_FaceID = c.Int(),
                        Face9_FaceID = c.Int(),
                        Face_FaceID13 = c.Int(),
                        Face_FaceID14 = c.Int(),
                        Face_FaceID15 = c.Int(),
                        Face_FaceID16 = c.Int(),
                        Face_FaceID17 = c.Int(),
                        Face_FaceID18 = c.Int(),
                        Face_FaceID19 = c.Int(),
                        Face_FaceID20 = c.Int(),
                        Face_FaceID21 = c.Int(),
                        Face_FaceID22 = c.Int(),
                        Face_FaceID23 = c.Int(),
                        Face_FaceID24 = c.Int(),
                        Face_FaceID25 = c.Int(),
                        Face_FaceID26 = c.Int(),
                        Face_FaceID27 = c.Int(),
                        Face_FaceID28 = c.Int(),
                        Face_FaceID29 = c.Int(),
                        Face_FaceID30 = c.Int(),
                        Face_FaceID31 = c.Int(),
                        Face1_FaceID3 = c.Int(),
                        Face10_FaceID1 = c.Int(),
                        Face101_FaceID = c.Int(),
                        Face11_FaceID2 = c.Int(),
                        Face111_FaceID1 = c.Int(),
                        Face112_FaceID = c.Int(),
                        Face12_FaceID1 = c.Int(),
                        Face121_FaceID = c.Int(),
                        Face13_FaceID = c.Int(),
                        Face131_FaceID = c.Int(),
                        Face14_FaceID = c.Int(),
                        Face141_FaceID = c.Int(),
                        Face15_FaceID = c.Int(),
                        Face16_FaceID = c.Int(),
                        Face17_FaceID = c.Int(),
                        Face18_FaceID = c.Int(),
                        Face19_FaceID = c.Int(),
                        Face2_FaceID2 = c.Int(),
                        Face20_FaceID = c.Int(),
                        Face21_FaceID2 = c.Int(),
                        Face211_FaceID = c.Int(),
                        Face22_FaceID1 = c.Int(),
                        Face221_FaceID = c.Int(),
                        Face23_FaceID = c.Int(),
                        Face231_FaceID = c.Int(),
                        Face24_FaceID = c.Int(),
                        Face25_FaceID = c.Int(),
                        Face26_FaceID = c.Int(),
                        Face27_FaceID = c.Int(),
                        Face28_FaceID = c.Int(),
                        Face29_FaceID = c.Int(),
                        Face3_FaceID2 = c.Int(),
                        Face30_FaceID = c.Int(),
                        Face31_FaceID1 = c.Int(),
                        Face311_FaceID = c.Int(),
                        Face32_FaceID = c.Int(),
                        Face321_FaceID = c.Int(),
                        Face33_FaceID = c.Int(),
                        Face34_FaceID = c.Int(),
                        Face35_FaceID = c.Int(),
                        Face4_FaceID1 = c.Int(),
                        Face41_FaceID1 = c.Int(),
                        Face42_FaceID = c.Int(),
                        Face5_FaceID1 = c.Int(),
                        Face51_FaceID = c.Int(),
                        Face6_FaceID1 = c.Int(),
                        Face61_FaceID = c.Int(),
                        Face7_FaceID1 = c.Int(),
                        Face71_FaceID = c.Int(),
                        Face8_FaceID1 = c.Int(),
                        Face81_FaceID = c.Int(),
                        Face9_FaceID1 = c.Int(),
                        Face91_FaceID = c.Int(),
                        Face_FaceID32 = c.Int(),
                        Face_FaceID33 = c.Int(),
                        Face_FaceID34 = c.Int(),
                        Face_FaceID35 = c.Int(),
                        Face_FaceID36 = c.Int(),
                        Face_FaceID37 = c.Int(),
                        Face_FaceID38 = c.Int(),
                        Face_FaceID39 = c.Int(),
                        Face_FaceID40 = c.Int(),
                        Face_FaceID41 = c.Int(),
                        Face_FaceID42 = c.Int(),
                        Face_FaceID43 = c.Int(),
                        Face_FaceID44 = c.Int(),
                        Face_FaceID45 = c.Int(),
                        Face_FaceID46 = c.Int(),
                        Face_FaceID47 = c.Int(),
                        Face_FaceID48 = c.Int(),
                        Face_FaceID49 = c.Int(),
                        Face_FaceID50 = c.Int(),
                        Face_FaceID51 = c.Int(),
                        Face_FaceID52 = c.Int(),
                        Face_FaceID53 = c.Int(),
                        Face_FaceID54 = c.Int(),
                        Face_FaceID55 = c.Int(),
                        Face_FaceID56 = c.Int(),
                        Face_FaceID57 = c.Int(),
                        Face_FaceID58 = c.Int(),
                        Face_FaceID59 = c.Int(),
                        Face_FaceID60 = c.Int(),
                        Face_FaceID61 = c.Int(),
                        Face_FaceID62 = c.Int(),
                        Face_FaceID63 = c.Int(),
                        Face_FaceID64 = c.Int(),
                        Face_FaceID65 = c.Int(),
                        Face_FaceID66 = c.Int(),
                        Face_FaceID67 = c.Int(),
                        Face_FaceID68 = c.Int(),
                        Face_FaceID69 = c.Int(),
                        Face_FaceID70 = c.Int(),
                        Face_FaceID71 = c.Int(),
                        Face_FaceID72 = c.Int(),
                        Face_FaceID73 = c.Int(),
                        Face_FaceID74 = c.Int(),
                        Face_FaceID75 = c.Int(),
                        Face_FaceID76 = c.Int(),
                        Face_FaceID77 = c.Int(),
                        Face_FaceID78 = c.Int(),
                        Face_FaceID79 = c.Int(),
                        Face_FaceID80 = c.Int(),
                        Face_FaceID81 = c.Int(),
                        Face_FaceID82 = c.Int(),
                        Face_FaceID83 = c.Int(),
                        Face_FaceID84 = c.Int(),
                        Face_FaceID85 = c.Int(),
                    })
                .PrimaryKey(t => t.FaceImageID)
                .ForeignKey("dbo.Face", t => t.Face_FaceID31)
                .ForeignKey("dbo.Face", t => t.Face1_FaceID3)
                .ForeignKey("dbo.Face", t => t.Face10_FaceID1)
                .ForeignKey("dbo.Face", t => t.Face101_FaceID)
                .ForeignKey("dbo.Face", t => t.Face11_FaceID2)
                .ForeignKey("dbo.Face", t => t.Face111_FaceID1)
                .ForeignKey("dbo.Face", t => t.Face112_FaceID)
                .ForeignKey("dbo.Face", t => t.Face12_FaceID1)
                .ForeignKey("dbo.Face", t => t.Face121_FaceID)
                .ForeignKey("dbo.Face", t => t.Face13_FaceID)
                .ForeignKey("dbo.Face", t => t.Face131_FaceID)
                .ForeignKey("dbo.Face", t => t.Face14_FaceID)
                .ForeignKey("dbo.Face", t => t.Face141_FaceID)
                .ForeignKey("dbo.Face", t => t.Face15_FaceID)
                .ForeignKey("dbo.Face", t => t.Face16_FaceID)
                .ForeignKey("dbo.Face", t => t.Face17_FaceID)
                .ForeignKey("dbo.Face", t => t.Face18_FaceID)
                .ForeignKey("dbo.Face", t => t.Face19_FaceID)
                .ForeignKey("dbo.Face", t => t.Face2_FaceID2)
                .ForeignKey("dbo.Face", t => t.Face20_FaceID)
                .ForeignKey("dbo.Face", t => t.Face21_FaceID2)
                .ForeignKey("dbo.Face", t => t.Face211_FaceID)
                .ForeignKey("dbo.Face", t => t.Face22_FaceID1)
                .ForeignKey("dbo.Face", t => t.Face221_FaceID)
                .ForeignKey("dbo.Face", t => t.Face23_FaceID)
                .ForeignKey("dbo.Face", t => t.Face231_FaceID)
                .ForeignKey("dbo.Face", t => t.Face24_FaceID)
                .ForeignKey("dbo.Face", t => t.Face25_FaceID)
                .ForeignKey("dbo.Face", t => t.Face26_FaceID)
                .ForeignKey("dbo.Face", t => t.Face27_FaceID)
                .ForeignKey("dbo.Face", t => t.Face28_FaceID)
                .ForeignKey("dbo.Face", t => t.Face29_FaceID)
                .ForeignKey("dbo.Face", t => t.Face3_FaceID2)
                .ForeignKey("dbo.Face", t => t.Face30_FaceID)
                .ForeignKey("dbo.Face", t => t.Face31_FaceID1)
                .ForeignKey("dbo.Face", t => t.Face311_FaceID)
                .ForeignKey("dbo.Face", t => t.Face32_FaceID)
                .ForeignKey("dbo.Face", t => t.Face321_FaceID)
                .ForeignKey("dbo.Face", t => t.Face33_FaceID)
                .ForeignKey("dbo.Face", t => t.Face34_FaceID)
                .ForeignKey("dbo.Face", t => t.Face35_FaceID)
                .ForeignKey("dbo.Face", t => t.Face4_FaceID1)
                .ForeignKey("dbo.Face", t => t.Face41_FaceID1)
                .ForeignKey("dbo.Face", t => t.Face42_FaceID)
                .ForeignKey("dbo.Face", t => t.Face5_FaceID1)
                .ForeignKey("dbo.Face", t => t.Face51_FaceID)
                .ForeignKey("dbo.Face", t => t.Face6_FaceID1)
                .ForeignKey("dbo.Face", t => t.Face61_FaceID)
                .ForeignKey("dbo.Face", t => t.Face7_FaceID1)
                .ForeignKey("dbo.Face", t => t.Face71_FaceID)
                .ForeignKey("dbo.Face", t => t.Face8_FaceID1)
                .ForeignKey("dbo.Face", t => t.Face81_FaceID)
                .ForeignKey("dbo.Face", t => t.Face9_FaceID1)
                .ForeignKey("dbo.Face", t => t.Face91_FaceID)
                .ForeignKey("dbo.Face", t => t.Face_FaceID32)
                .ForeignKey("dbo.Face", t => t.Face_FaceID33)
                .ForeignKey("dbo.Face", t => t.Face_FaceID34)
                .ForeignKey("dbo.Face", t => t.Face_FaceID35)
                .ForeignKey("dbo.Face", t => t.Face_FaceID36)
                .ForeignKey("dbo.Face", t => t.Face_FaceID37)
                .ForeignKey("dbo.Face", t => t.Face_FaceID38)
                .ForeignKey("dbo.Face", t => t.Face_FaceID39)
                .ForeignKey("dbo.Face", t => t.Face_FaceID40)
                .ForeignKey("dbo.Face", t => t.Face_FaceID41)
                .ForeignKey("dbo.Face", t => t.Face_FaceID42)
                .ForeignKey("dbo.Face", t => t.Face_FaceID43)
                .ForeignKey("dbo.Face", t => t.Face_FaceID44)
                .ForeignKey("dbo.Face", t => t.Face_FaceID45)
                .ForeignKey("dbo.Face", t => t.Face_FaceID46)
                .ForeignKey("dbo.Face", t => t.Face_FaceID47)
                .ForeignKey("dbo.Face", t => t.Face_FaceID48)
                .ForeignKey("dbo.Face", t => t.Face_FaceID49)
                .ForeignKey("dbo.Face", t => t.Face_FaceID50)
                .ForeignKey("dbo.Face", t => t.Face_FaceID51)
                .ForeignKey("dbo.Face", t => t.Face_FaceID52)
                .ForeignKey("dbo.Face", t => t.Face_FaceID53)
                .ForeignKey("dbo.Face", t => t.Face_FaceID54)
                .ForeignKey("dbo.Face", t => t.Face_FaceID55)
                .ForeignKey("dbo.Face", t => t.Face_FaceID56)
                .ForeignKey("dbo.Face", t => t.Face_FaceID57)
                .ForeignKey("dbo.Face", t => t.Face_FaceID58)
                .ForeignKey("dbo.Face", t => t.Face_FaceID59)
                .ForeignKey("dbo.Face", t => t.Face_FaceID60)
                .ForeignKey("dbo.Face", t => t.Face_FaceID61)
                .ForeignKey("dbo.Face", t => t.Face_FaceID62)
                .ForeignKey("dbo.Face", t => t.Face_FaceID63)
                .ForeignKey("dbo.Face", t => t.Face_FaceID64)
                .ForeignKey("dbo.Face", t => t.Face_FaceID65)
                .ForeignKey("dbo.Face", t => t.Face_FaceID66)
                .ForeignKey("dbo.Face", t => t.Face_FaceID67)
                .ForeignKey("dbo.Face", t => t.Face_FaceID68)
                .ForeignKey("dbo.Face", t => t.Face_FaceID69)
                .ForeignKey("dbo.Face", t => t.Face_FaceID70)
                .ForeignKey("dbo.Face", t => t.Face_FaceID71)
                .ForeignKey("dbo.Face", t => t.Face_FaceID72)
                .ForeignKey("dbo.Face", t => t.Face_FaceID73)
                .ForeignKey("dbo.Face", t => t.Face_FaceID74)
                .ForeignKey("dbo.Face", t => t.Face_FaceID75)
                .ForeignKey("dbo.Face", t => t.Face_FaceID76)
                .ForeignKey("dbo.Face", t => t.Face_FaceID77)
                .ForeignKey("dbo.Face", t => t.Face_FaceID78)
                .ForeignKey("dbo.Face", t => t.Face_FaceID79)
                .ForeignKey("dbo.Face", t => t.Face_FaceID80)
                .ForeignKey("dbo.Face", t => t.Face_FaceID81)
                .ForeignKey("dbo.Face", t => t.Face_FaceID82)
                .ForeignKey("dbo.Face", t => t.Face_FaceID83)
                .ForeignKey("dbo.Face", t => t.Face_FaceID84)
                .ForeignKey("dbo.Face", t => t.Face_FaceID85)
                .Index(t => t.Face_FaceID31)
                .Index(t => t.Face1_FaceID3)
                .Index(t => t.Face10_FaceID1)
                .Index(t => t.Face101_FaceID)
                .Index(t => t.Face11_FaceID2)
                .Index(t => t.Face111_FaceID1)
                .Index(t => t.Face112_FaceID)
                .Index(t => t.Face12_FaceID1)
                .Index(t => t.Face121_FaceID)
                .Index(t => t.Face13_FaceID)
                .Index(t => t.Face131_FaceID)
                .Index(t => t.Face14_FaceID)
                .Index(t => t.Face141_FaceID)
                .Index(t => t.Face15_FaceID)
                .Index(t => t.Face16_FaceID)
                .Index(t => t.Face17_FaceID)
                .Index(t => t.Face18_FaceID)
                .Index(t => t.Face19_FaceID)
                .Index(t => t.Face2_FaceID2)
                .Index(t => t.Face20_FaceID)
                .Index(t => t.Face21_FaceID2)
                .Index(t => t.Face211_FaceID)
                .Index(t => t.Face22_FaceID1)
                .Index(t => t.Face221_FaceID)
                .Index(t => t.Face23_FaceID)
                .Index(t => t.Face231_FaceID)
                .Index(t => t.Face24_FaceID)
                .Index(t => t.Face25_FaceID)
                .Index(t => t.Face26_FaceID)
                .Index(t => t.Face27_FaceID)
                .Index(t => t.Face28_FaceID)
                .Index(t => t.Face29_FaceID)
                .Index(t => t.Face3_FaceID2)
                .Index(t => t.Face30_FaceID)
                .Index(t => t.Face31_FaceID1)
                .Index(t => t.Face311_FaceID)
                .Index(t => t.Face32_FaceID)
                .Index(t => t.Face321_FaceID)
                .Index(t => t.Face33_FaceID)
                .Index(t => t.Face34_FaceID)
                .Index(t => t.Face35_FaceID)
                .Index(t => t.Face4_FaceID1)
                .Index(t => t.Face41_FaceID1)
                .Index(t => t.Face42_FaceID)
                .Index(t => t.Face5_FaceID1)
                .Index(t => t.Face51_FaceID)
                .Index(t => t.Face6_FaceID1)
                .Index(t => t.Face61_FaceID)
                .Index(t => t.Face7_FaceID1)
                .Index(t => t.Face71_FaceID)
                .Index(t => t.Face8_FaceID1)
                .Index(t => t.Face81_FaceID)
                .Index(t => t.Face9_FaceID1)
                .Index(t => t.Face91_FaceID)
                .Index(t => t.Face_FaceID32)
                .Index(t => t.Face_FaceID33)
                .Index(t => t.Face_FaceID34)
                .Index(t => t.Face_FaceID35)
                .Index(t => t.Face_FaceID36)
                .Index(t => t.Face_FaceID37)
                .Index(t => t.Face_FaceID38)
                .Index(t => t.Face_FaceID39)
                .Index(t => t.Face_FaceID40)
                .Index(t => t.Face_FaceID41)
                .Index(t => t.Face_FaceID42)
                .Index(t => t.Face_FaceID43)
                .Index(t => t.Face_FaceID44)
                .Index(t => t.Face_FaceID45)
                .Index(t => t.Face_FaceID46)
                .Index(t => t.Face_FaceID47)
                .Index(t => t.Face_FaceID48)
                .Index(t => t.Face_FaceID49)
                .Index(t => t.Face_FaceID50)
                .Index(t => t.Face_FaceID51)
                .Index(t => t.Face_FaceID52)
                .Index(t => t.Face_FaceID53)
                .Index(t => t.Face_FaceID54)
                .Index(t => t.Face_FaceID55)
                .Index(t => t.Face_FaceID56)
                .Index(t => t.Face_FaceID57)
                .Index(t => t.Face_FaceID58)
                .Index(t => t.Face_FaceID59)
                .Index(t => t.Face_FaceID60)
                .Index(t => t.Face_FaceID61)
                .Index(t => t.Face_FaceID62)
                .Index(t => t.Face_FaceID63)
                .Index(t => t.Face_FaceID64)
                .Index(t => t.Face_FaceID65)
                .Index(t => t.Face_FaceID66)
                .Index(t => t.Face_FaceID67)
                .Index(t => t.Face_FaceID68)
                .Index(t => t.Face_FaceID69)
                .Index(t => t.Face_FaceID70)
                .Index(t => t.Face_FaceID71)
                .Index(t => t.Face_FaceID72)
                .Index(t => t.Face_FaceID73)
                .Index(t => t.Face_FaceID74)
                .Index(t => t.Face_FaceID75)
                .Index(t => t.Face_FaceID76)
                .Index(t => t.Face_FaceID77)
                .Index(t => t.Face_FaceID78)
                .Index(t => t.Face_FaceID79)
                .Index(t => t.Face_FaceID80)
                .Index(t => t.Face_FaceID81)
                .Index(t => t.Face_FaceID82)
                .Index(t => t.Face_FaceID83)
                .Index(t => t.Face_FaceID84)
                .Index(t => t.Face_FaceID85);
            
            CreateTable(
                "dbo.FaceOccupancy",
                c => new
                    {
                        FaceOccupancyID = c.Int(nullable: false, identity: true),
                        Occupancy = c.String(),
                    })
                .PrimaryKey(t => t.FaceOccupancyID);
            
            CreateTable(
                "dbo.FacePosition",
                c => new
                    {
                        FacePositionID = c.Int(nullable: false, identity: true),
                        Position = c.String(),
                    })
                .PrimaryKey(t => t.FacePositionID);
            
            CreateTable(
                "dbo.FaceSize",
                c => new
                    {
                        FaceSizeID = c.Int(nullable: false, identity: true),
                        Height = c.Double(nullable: false),
                        Width = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.FaceSizeID);
            
            CreateTable(
                "dbo.FaceVisibilityRating",
                c => new
                    {
                        FaceVisibilityRatingID = c.Int(nullable: false, identity: true),
                        VegetationCoverScore = c.Double(),
                        SightLightingScore = c.Double(),
                        BacklightScore = c.Double(),
                        UnlightScore = c.Double(),
                        TrafficScore = c.Double(),
                        ClutterScore = c.Double(),
                    })
                .PrimaryKey(t => t.FaceVisibilityRatingID);
            
            CreateTable(
                "dbo.Structure",
                c => new
                    {
                        StructureID = c.Int(nullable: false, identity: true),
                        FaceCount = c.Int(nullable: false),
                        Comment = c.String(),
                        Latitude = c.Double(),
                        Longitude = c.Double(),
                        Geom = c.Geometry(),
                        StructureTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StructureID)
                .ForeignKey("dbo.StructureType", t => t.StructureTypeID)
                .Index(t => t.StructureTypeID);
            
            CreateTable(
                "dbo.StructureOwner",
                c => new
                    {
                        StructureOwnerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        MobileNumber = c.String(),
                        StructureID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StructureOwnerID)
                .ForeignKey("dbo.Structure", t => t.StructureID)
                .Index(t => t.StructureID);
            
            CreateTable(
                "dbo.StructureType",
                c => new
                    {
                        StructureTypeID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.StructureTypeID);
            
            CreateTable(
                "dbo.SweepStructure",
                c => new
                    {
                        SweepStructureID = c.Int(nullable: false, identity: true),
                        StructureID = c.Int(nullable: false),
                        SweepID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SweepStructureID)
                .ForeignKey("dbo.Structure", t => t.StructureID)
                .ForeignKey("dbo.Sweep", t => t.SweepID)
                .Index(t => t.StructureID)
                .Index(t => t.SweepID);
            
            CreateTable(
                "dbo.Sweep",
                c => new
                    {
                        SweepID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SweepID);
            
            CreateTable(
                "dbo.SiteRunUp",
                c => new
                    {
                        SiteRunUpID = c.Int(nullable: false, identity: true),
                        DistanceOption = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SiteRunUpID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Face", "StructureType9_StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType8_StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType7_StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType6_StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType5_StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType41_StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType4_StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType31_StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType3_StructureTypeID1", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType22_StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType21_StructureTypeID1", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType2_StructureTypeID1", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType12_StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType111_StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType11_StructureTypeID1", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType10_StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType1_StructureTypeID2", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID30", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureOwner9_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner8_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner7_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner6_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner5_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner41_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner4_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner31_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner3_StructureOwnerID1", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner22_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner21_StructureOwnerID1", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner2_StructureOwnerID1", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner12_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner111_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner11_StructureOwnerID1", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner10_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner1_StructureOwnerID2", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID30", "dbo.StructureOwner");
            DropForeignKey("dbo.SweepStructure", "SweepID", "dbo.Sweep");
            DropForeignKey("dbo.SweepStructure", "StructureID", "dbo.Structure");
            DropForeignKey("dbo.Structure", "StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID29", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID28", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID27", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID26", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID25", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID24", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID23", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID22", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID21", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID20", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID19", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID18", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID17", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID16", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID15", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID14", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID13", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID12", "dbo.StructureType");
            DropForeignKey("dbo.StructureOwner", "StructureID", "dbo.Structure");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID29", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID28", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID27", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID26", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID25", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID24", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID23", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID22", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID21", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID20", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID19", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID18", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID17", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID16", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID15", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID14", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID13", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID12", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureID", "dbo.Structure");
            DropForeignKey("dbo.Face", "FaceVisibilityRatingID", "dbo.FaceVisibilityRating");
            DropForeignKey("dbo.Face", "FaceSizeID", "dbo.FaceSize");
            DropForeignKey("dbo.Face", "FacePositionID", "dbo.FacePosition");
            DropForeignKey("dbo.Face", "FaceOccupancyID", "dbo.FaceOccupancy");
            DropForeignKey("dbo.FaceImage", "Face_FaceID85", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID84", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID83", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID82", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID81", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID80", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID79", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID78", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID77", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID76", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID75", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID74", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID73", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID72", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID71", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID70", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID69", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID68", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID67", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID66", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID65", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID64", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID63", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID62", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID61", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID60", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID59", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID58", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID57", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID56", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID55", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID54", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID53", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID52", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID51", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID50", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID49", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID48", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID47", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID46", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID45", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID44", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID43", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID42", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID41", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID40", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID39", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID38", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID37", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID36", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID35", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID34", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID33", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID32", "dbo.Face");
            DropForeignKey("dbo.Face", "FaceImage91_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage9_FaceImageID1", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage81_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage8_FaceImageID1", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage71_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage7_FaceImageID1", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage61_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage6_FaceImageID1", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage51_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage5_FaceImageID1", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage42_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage41_FaceImageID1", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage4_FaceImageID1", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage35_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage34_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage33_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage321_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage32_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage311_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage31_FaceImageID1", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage30_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage3_FaceImageID2", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage29_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage28_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage27_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage26_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage25_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage24_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage231_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage23_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage221_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage22_FaceImageID1", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage211_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage21_FaceImageID2", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage20_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage2_FaceImageID2", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage19_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage18_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage17_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage16_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage15_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage141_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage14_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage131_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage13_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage121_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage12_FaceImageID1", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage112_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage111_FaceImageID1", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage11_FaceImageID2", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage101_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage10_FaceImageID1", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage1_FaceImageID3", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID85", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID84", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID83", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID82", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID81", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID80", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID79", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID78", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID77", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID76", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID75", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID74", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID73", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID72", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID71", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID70", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID69", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID68", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID67", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID66", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID65", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID64", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID63", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID62", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID61", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID60", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID59", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID58", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID57", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID56", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID55", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID54", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID53", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID52", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID51", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID50", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID49", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID48", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID47", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID46", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID45", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID44", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID43", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID42", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID41", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID40", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID39", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID38", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID37", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID36", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID35", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID34", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID33", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID32", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID31", "dbo.FaceImage");
            DropForeignKey("dbo.FaceImage", "Face91_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face9_FaceID1", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face81_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face8_FaceID1", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face71_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face7_FaceID1", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face61_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face6_FaceID1", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face51_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face5_FaceID1", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face42_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face41_FaceID1", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face4_FaceID1", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face35_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face34_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face33_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face321_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face32_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face311_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face31_FaceID1", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face30_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face3_FaceID2", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face29_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face28_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face27_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face26_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face25_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face24_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face231_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face23_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face221_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face22_FaceID1", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face211_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face21_FaceID2", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face20_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face2_FaceID2", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face19_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face18_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face17_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face16_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face15_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face141_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face14_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face131_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face13_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face121_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face12_FaceID1", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face112_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face111_FaceID1", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face11_FaceID2", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face101_FaceID", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face10_FaceID1", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face1_FaceID3", "dbo.Face");
            DropForeignKey("dbo.FaceImage", "Face_FaceID31", "dbo.Face");
            DropForeignKey("dbo.Face", "FaceConditionID", "dbo.FaceCondition");
            DropForeignKey("dbo.Face", "FaceBoundID", "dbo.FaceBound");
            DropForeignKey("dbo.Face", "FaceAvailabilityID", "dbo.FaceAvailability");
            DropForeignKey("dbo.Advert", "FaceID", "dbo.Face");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID30", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID29", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID28", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID27", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID26", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID25", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID24", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID23", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID22", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID21", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID20", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID19", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID18", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID17", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID16", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID15", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID14", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID13", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Campaign", "Industry9_IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry8_IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry7_IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry6_IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry5_IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry41_IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry4_IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry31_IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry3_IndustryID1", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry22_IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry21_IndustryID1", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry2_IndustryID1", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry12_IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry111_IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry11_IndustryID1", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry10_IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry1_IndustryID2", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID30", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID29", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID28", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID27", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID26", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID25", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID24", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID23", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID22", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID21", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID20", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID19", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID18", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID17", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID16", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID15", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID14", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID13", "dbo.Industry");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID12", "dbo.Industry");
            DropForeignKey("dbo.CampaignRoute", "RouteID", "dbo.Route");
            DropForeignKey("dbo.CampaignRoute", "CampaignID", "dbo.Campaign");
            DropForeignKey("dbo.Device", "DeviceStatusID", "dbo.DeviceStatus");
            DropForeignKey("dbo.CampaignDevice", "DeviceID", "dbo.Device");
            DropForeignKey("dbo.CampaignDevice", "CampaignID", "dbo.Campaign");
            DropForeignKey("dbo.Subscription", "SubscriptionID", "dbo.Agency");
            DropForeignKey("dbo.Campaign", "AgencyID", "dbo.Agency");
            DropForeignKey("dbo.Advert", "CampaignID", "dbo.Campaign");
            DropForeignKey("dbo.Campaign", "Advertiser9_AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser8_AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser7_AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser6_AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser5_AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser41_AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser4_AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser31_AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser3_AdvertiserID1", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser22_AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser21_AdvertiserID1", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser2_AdvertiserID1", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser12_AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser111_AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser11_AdvertiserID1", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser10_AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser1_AdvertiserID2", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID12", "dbo.Advertiser");
            DropForeignKey("dbo.Advert", "AdvertiserID", "dbo.Advertiser");
            DropIndex("dbo.SweepStructure", new[] { "SweepID" });
            DropIndex("dbo.SweepStructure", new[] { "StructureID" });
            DropIndex("dbo.StructureOwner", new[] { "StructureID" });
            DropIndex("dbo.Structure", new[] { "StructureTypeID" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID85" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID84" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID83" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID82" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID81" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID80" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID79" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID78" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID77" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID76" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID75" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID74" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID73" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID72" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID71" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID70" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID69" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID68" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID67" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID66" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID65" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID64" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID63" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID62" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID61" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID60" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID59" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID58" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID57" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID56" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID55" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID54" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID53" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID52" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID51" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID50" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID49" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID48" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID47" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID46" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID45" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID44" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID43" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID42" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID41" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID40" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID39" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID38" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID37" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID36" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID35" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID34" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID33" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID32" });
            DropIndex("dbo.FaceImage", new[] { "Face91_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face9_FaceID1" });
            DropIndex("dbo.FaceImage", new[] { "Face81_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face8_FaceID1" });
            DropIndex("dbo.FaceImage", new[] { "Face71_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face7_FaceID1" });
            DropIndex("dbo.FaceImage", new[] { "Face61_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face6_FaceID1" });
            DropIndex("dbo.FaceImage", new[] { "Face51_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face5_FaceID1" });
            DropIndex("dbo.FaceImage", new[] { "Face42_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face41_FaceID1" });
            DropIndex("dbo.FaceImage", new[] { "Face4_FaceID1" });
            DropIndex("dbo.FaceImage", new[] { "Face35_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face34_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face33_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face321_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face32_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face311_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face31_FaceID1" });
            DropIndex("dbo.FaceImage", new[] { "Face30_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face3_FaceID2" });
            DropIndex("dbo.FaceImage", new[] { "Face29_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face28_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face27_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face26_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face25_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face24_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face231_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face23_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face221_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face22_FaceID1" });
            DropIndex("dbo.FaceImage", new[] { "Face211_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face21_FaceID2" });
            DropIndex("dbo.FaceImage", new[] { "Face20_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face2_FaceID2" });
            DropIndex("dbo.FaceImage", new[] { "Face19_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face18_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face17_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face16_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face15_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face141_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face14_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face131_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face13_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face121_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face12_FaceID1" });
            DropIndex("dbo.FaceImage", new[] { "Face112_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face111_FaceID1" });
            DropIndex("dbo.FaceImage", new[] { "Face11_FaceID2" });
            DropIndex("dbo.FaceImage", new[] { "Face101_FaceID" });
            DropIndex("dbo.FaceImage", new[] { "Face10_FaceID1" });
            DropIndex("dbo.FaceImage", new[] { "Face1_FaceID3" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID31" });
            DropIndex("dbo.CampaignRoute", new[] { "RouteID" });
            DropIndex("dbo.CampaignRoute", new[] { "CampaignID" });
            DropIndex("dbo.Device", new[] { "DeviceStatusID" });
            DropIndex("dbo.CampaignDevice", new[] { "DeviceID" });
            DropIndex("dbo.CampaignDevice", new[] { "CampaignID" });
            DropIndex("dbo.Subscription", new[] { "SubscriptionID" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID30" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID29" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID28" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID27" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID26" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID25" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID24" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID23" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID22" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID21" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID20" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID19" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID18" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID17" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID16" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID15" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID14" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID13" });
            DropIndex("dbo.Campaign", new[] { "Industry9_IndustryID" });
            DropIndex("dbo.Campaign", new[] { "Industry8_IndustryID" });
            DropIndex("dbo.Campaign", new[] { "Industry7_IndustryID" });
            DropIndex("dbo.Campaign", new[] { "Industry6_IndustryID" });
            DropIndex("dbo.Campaign", new[] { "Industry5_IndustryID" });
            DropIndex("dbo.Campaign", new[] { "Industry41_IndustryID" });
            DropIndex("dbo.Campaign", new[] { "Industry4_IndustryID" });
            DropIndex("dbo.Campaign", new[] { "Industry31_IndustryID" });
            DropIndex("dbo.Campaign", new[] { "Industry3_IndustryID1" });
            DropIndex("dbo.Campaign", new[] { "Industry22_IndustryID" });
            DropIndex("dbo.Campaign", new[] { "Industry21_IndustryID1" });
            DropIndex("dbo.Campaign", new[] { "Industry2_IndustryID1" });
            DropIndex("dbo.Campaign", new[] { "Industry12_IndustryID" });
            DropIndex("dbo.Campaign", new[] { "Industry111_IndustryID" });
            DropIndex("dbo.Campaign", new[] { "Industry11_IndustryID1" });
            DropIndex("dbo.Campaign", new[] { "Industry10_IndustryID" });
            DropIndex("dbo.Campaign", new[] { "Industry1_IndustryID2" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID30" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID29" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID28" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID27" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID26" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID25" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID24" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID23" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID22" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID21" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID20" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID19" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID18" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID17" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID16" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID15" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID14" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID13" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID12" });
            DropIndex("dbo.Campaign", new[] { "Advertiser9_AdvertiserID" });
            DropIndex("dbo.Campaign", new[] { "Advertiser8_AdvertiserID" });
            DropIndex("dbo.Campaign", new[] { "Advertiser7_AdvertiserID" });
            DropIndex("dbo.Campaign", new[] { "Advertiser6_AdvertiserID" });
            DropIndex("dbo.Campaign", new[] { "Advertiser5_AdvertiserID" });
            DropIndex("dbo.Campaign", new[] { "Advertiser41_AdvertiserID" });
            DropIndex("dbo.Campaign", new[] { "Advertiser4_AdvertiserID" });
            DropIndex("dbo.Campaign", new[] { "Advertiser31_AdvertiserID" });
            DropIndex("dbo.Campaign", new[] { "Advertiser3_AdvertiserID1" });
            DropIndex("dbo.Campaign", new[] { "Advertiser22_AdvertiserID" });
            DropIndex("dbo.Campaign", new[] { "Advertiser21_AdvertiserID1" });
            DropIndex("dbo.Campaign", new[] { "Advertiser2_AdvertiserID1" });
            DropIndex("dbo.Campaign", new[] { "Advertiser12_AdvertiserID" });
            DropIndex("dbo.Campaign", new[] { "Advertiser111_AdvertiserID" });
            DropIndex("dbo.Campaign", new[] { "Advertiser11_AdvertiserID1" });
            DropIndex("dbo.Campaign", new[] { "Advertiser10_AdvertiserID" });
            DropIndex("dbo.Campaign", new[] { "Advertiser1_AdvertiserID2" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID12" });
            DropIndex("dbo.Campaign", new[] { "AgencyID" });
            DropIndex("dbo.Campaign", new[] { "ProductID" });
            DropIndex("dbo.Advert", new[] { "CampaignID" });
            DropIndex("dbo.Advert", new[] { "AdvertiserID" });
            DropIndex("dbo.Advert", new[] { "FaceID" });
            DropIndex("dbo.Face", new[] { "StructureType9_StructureTypeID" });
            DropIndex("dbo.Face", new[] { "StructureType8_StructureTypeID" });
            DropIndex("dbo.Face", new[] { "StructureType7_StructureTypeID" });
            DropIndex("dbo.Face", new[] { "StructureType6_StructureTypeID" });
            DropIndex("dbo.Face", new[] { "StructureType5_StructureTypeID" });
            DropIndex("dbo.Face", new[] { "StructureType41_StructureTypeID" });
            DropIndex("dbo.Face", new[] { "StructureType4_StructureTypeID" });
            DropIndex("dbo.Face", new[] { "StructureType31_StructureTypeID" });
            DropIndex("dbo.Face", new[] { "StructureType3_StructureTypeID1" });
            DropIndex("dbo.Face", new[] { "StructureType22_StructureTypeID" });
            DropIndex("dbo.Face", new[] { "StructureType21_StructureTypeID1" });
            DropIndex("dbo.Face", new[] { "StructureType2_StructureTypeID1" });
            DropIndex("dbo.Face", new[] { "StructureType12_StructureTypeID" });
            DropIndex("dbo.Face", new[] { "StructureType111_StructureTypeID" });
            DropIndex("dbo.Face", new[] { "StructureType11_StructureTypeID1" });
            DropIndex("dbo.Face", new[] { "StructureType10_StructureTypeID" });
            DropIndex("dbo.Face", new[] { "StructureType1_StructureTypeID2" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID30" });
            DropIndex("dbo.Face", new[] { "StructureOwner9_StructureOwnerID" });
            DropIndex("dbo.Face", new[] { "StructureOwner8_StructureOwnerID" });
            DropIndex("dbo.Face", new[] { "StructureOwner7_StructureOwnerID" });
            DropIndex("dbo.Face", new[] { "StructureOwner6_StructureOwnerID" });
            DropIndex("dbo.Face", new[] { "StructureOwner5_StructureOwnerID" });
            DropIndex("dbo.Face", new[] { "StructureOwner41_StructureOwnerID" });
            DropIndex("dbo.Face", new[] { "StructureOwner4_StructureOwnerID" });
            DropIndex("dbo.Face", new[] { "StructureOwner31_StructureOwnerID" });
            DropIndex("dbo.Face", new[] { "StructureOwner3_StructureOwnerID1" });
            DropIndex("dbo.Face", new[] { "StructureOwner22_StructureOwnerID" });
            DropIndex("dbo.Face", new[] { "StructureOwner21_StructureOwnerID1" });
            DropIndex("dbo.Face", new[] { "StructureOwner2_StructureOwnerID1" });
            DropIndex("dbo.Face", new[] { "StructureOwner12_StructureOwnerID" });
            DropIndex("dbo.Face", new[] { "StructureOwner111_StructureOwnerID" });
            DropIndex("dbo.Face", new[] { "StructureOwner11_StructureOwnerID1" });
            DropIndex("dbo.Face", new[] { "StructureOwner10_StructureOwnerID" });
            DropIndex("dbo.Face", new[] { "StructureOwner1_StructureOwnerID2" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID30" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID29" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID28" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID27" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID26" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID25" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID24" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID23" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID22" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID21" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID20" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID19" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID18" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID17" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID16" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID15" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID14" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID13" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID12" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID29" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID28" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID27" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID26" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID25" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID24" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID23" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID22" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID21" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID20" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID19" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID18" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID17" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID16" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID15" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID14" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID13" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID12" });
            DropIndex("dbo.Face", new[] { "FaceImage91_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage9_FaceImageID1" });
            DropIndex("dbo.Face", new[] { "FaceImage81_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage8_FaceImageID1" });
            DropIndex("dbo.Face", new[] { "FaceImage71_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage7_FaceImageID1" });
            DropIndex("dbo.Face", new[] { "FaceImage61_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage6_FaceImageID1" });
            DropIndex("dbo.Face", new[] { "FaceImage51_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage5_FaceImageID1" });
            DropIndex("dbo.Face", new[] { "FaceImage42_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage41_FaceImageID1" });
            DropIndex("dbo.Face", new[] { "FaceImage4_FaceImageID1" });
            DropIndex("dbo.Face", new[] { "FaceImage35_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage34_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage33_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage321_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage32_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage311_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage31_FaceImageID1" });
            DropIndex("dbo.Face", new[] { "FaceImage30_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage3_FaceImageID2" });
            DropIndex("dbo.Face", new[] { "FaceImage29_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage28_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage27_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage26_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage25_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage24_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage231_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage23_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage221_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage22_FaceImageID1" });
            DropIndex("dbo.Face", new[] { "FaceImage211_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage21_FaceImageID2" });
            DropIndex("dbo.Face", new[] { "FaceImage20_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage2_FaceImageID2" });
            DropIndex("dbo.Face", new[] { "FaceImage19_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage18_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage17_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage16_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage15_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage141_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage14_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage131_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage13_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage121_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage12_FaceImageID1" });
            DropIndex("dbo.Face", new[] { "FaceImage112_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage111_FaceImageID1" });
            DropIndex("dbo.Face", new[] { "FaceImage11_FaceImageID2" });
            DropIndex("dbo.Face", new[] { "FaceImage101_FaceImageID" });
            DropIndex("dbo.Face", new[] { "FaceImage10_FaceImageID1" });
            DropIndex("dbo.Face", new[] { "FaceImage1_FaceImageID3" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID85" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID84" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID83" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID82" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID81" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID80" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID79" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID78" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID77" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID76" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID75" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID74" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID73" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID72" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID71" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID70" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID69" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID68" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID67" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID66" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID65" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID64" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID63" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID62" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID61" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID60" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID59" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID58" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID57" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID56" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID55" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID54" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID53" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID52" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID51" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID50" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID49" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID48" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID47" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID46" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID45" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID44" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID43" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID42" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID41" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID40" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID39" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID38" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID37" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID36" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID35" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID34" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID33" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID32" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID31" });
            DropIndex("dbo.Face", new[] { "StructureID" });
            DropIndex("dbo.Face", new[] { "FaceAvailabilityID" });
            DropIndex("dbo.Face", new[] { "FaceVisibilityRatingID" });
            DropIndex("dbo.Face", new[] { "FacePositionID" });
            DropIndex("dbo.Face", new[] { "FaceBoundID" });
            DropIndex("dbo.Face", new[] { "FaceConditionID" });
            DropIndex("dbo.Face", new[] { "FaceSizeID" });
            DropIndex("dbo.Face", new[] { "FaceOccupancyID" });
            DropTable("dbo.SiteRunUp");
            DropTable("dbo.Sweep");
            DropTable("dbo.SweepStructure");
            DropTable("dbo.StructureType");
            DropTable("dbo.StructureOwner");
            DropTable("dbo.Structure");
            DropTable("dbo.FaceVisibilityRating");
            DropTable("dbo.FaceSize");
            DropTable("dbo.FacePosition");
            DropTable("dbo.FaceOccupancy");
            DropTable("dbo.FaceImage");
            DropTable("dbo.FaceCondition");
            DropTable("dbo.FaceBound");
            DropTable("dbo.Product");
            DropTable("dbo.Industry");
            DropTable("dbo.Route");
            DropTable("dbo.CampaignRoute");
            DropTable("dbo.DeviceStatus");
            DropTable("dbo.Device");
            DropTable("dbo.CampaignDevice");
            DropTable("dbo.Subscription");
            DropTable("dbo.Agency");
            DropTable("dbo.Campaign");
            DropTable("dbo.Advertiser");
            DropTable("dbo.Advert");
            DropTable("dbo.Face");
            DropTable("dbo.FaceAvailability");
        }
    }
}
