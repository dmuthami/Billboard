namespace Billboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
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
                "dbo.Campaign",
                c => new
                    {
                        CampaignID = c.Int(nullable: false, identity: true),
                        CampaignName = c.String(),
                        ProductID = c.Int(nullable: false),
                        AgencyID = c.Int(nullable: false),
                        Advertiser_AdvertiserID = c.Int(),
                        Industry_IndustryID = c.Int(),
                    })
                .PrimaryKey(t => t.CampaignID)
                .ForeignKey("dbo.Agency", t => t.AgencyID)
                .ForeignKey("dbo.Product", t => t.ProductID)
                .ForeignKey("dbo.Advertiser", t => t.Advertiser_AdvertiserID)
                .ForeignKey("dbo.Industry", t => t.Industry_IndustryID)
                .Index(t => t.ProductID)
                .Index(t => t.AgencyID)
                .Index(t => t.Advertiser_AdvertiserID)
                .Index(t => t.Industry_IndustryID);
            
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
                "dbo.Product",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ProductID);
            
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
                    })
                .PrimaryKey(t => t.FaceID)
                .ForeignKey("dbo.FaceAvailability", t => t.FaceAvailabilityID)
                .ForeignKey("dbo.FaceBound", t => t.FaceBoundID)
                .ForeignKey("dbo.FaceCondition", t => t.FaceConditionID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID)
                .ForeignKey("dbo.FaceImage", t => t.FaceImage_FaceImageID1)
                .ForeignKey("dbo.FaceOccupancy", t => t.FaceOccupancyID)
                .ForeignKey("dbo.FacePosition", t => t.FacePositionID)
                .ForeignKey("dbo.FaceSize", t => t.FaceSizeID)
                .ForeignKey("dbo.FaceVisibilityRating", t => t.FaceVisibilityRatingID)
                .ForeignKey("dbo.Structure", t => t.StructureID)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID)
                .ForeignKey("dbo.StructureType", t => t.StructureType_StructureTypeID)
                .Index(t => t.FaceOccupancyID)
                .Index(t => t.FaceSizeID)
                .Index(t => t.FaceConditionID)
                .Index(t => t.FaceBoundID)
                .Index(t => t.FacePositionID)
                .Index(t => t.FaceVisibilityRatingID)
                .Index(t => t.FaceAvailabilityID)
                .Index(t => t.StructureID)
                .Index(t => t.FaceImage_FaceImageID)
                .Index(t => t.FaceImage_FaceImageID1)
                .Index(t => t.StructureOwner_StructureOwnerID)
                .Index(t => t.StructureType_StructureTypeID);
            
            CreateTable(
                "dbo.FaceAvailability",
                c => new
                    {
                        FaceAvailabilityID = c.Int(nullable: false, identity: true),
                        AvailabilityType = c.String(),
                    })
                .PrimaryKey(t => t.FaceAvailabilityID);
            
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
                    })
                .PrimaryKey(t => t.FaceImageID)
                .ForeignKey("dbo.Face", t => t.Face_FaceID)
                .ForeignKey("dbo.Face", t => t.Face_FaceID1)
                .Index(t => t.Face_FaceID)
                .Index(t => t.Face_FaceID1);
            
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
                        Comment = c.String(nullable: false),
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
                        StructureOwnerID = c.Int(nullable: false),
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
                "dbo.Backlight",
                c => new
                    {
                        BacklightID = c.Int(nullable: false, identity: true),
                        Parameter = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BacklightID);
            
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
                "dbo.Clutter",
                c => new
                    {
                        ClutterID = c.Int(nullable: false, identity: true),
                        Parameter = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClutterID);
            
            CreateTable(
                "dbo.Constituency",
                c => new
                    {
                        ConstituencyID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Abbreviation = c.String(nullable: false, maxLength: 3),
                        Geom = c.Geometry(),
                    })
                .PrimaryKey(t => t.ConstituencyID);
            
            CreateTable(
                "dbo.Industry",
                c => new
                    {
                        IndustryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IndustryID);
            
            CreateTable(
                "dbo.SiteLighting",
                c => new
                    {
                        SiteLightingID = c.Int(nullable: false, identity: true),
                        Parameter = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SiteLightingID);
            
            CreateTable(
                "dbo.Street",
                c => new
                    {
                        StreetID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Geom = c.Geometry(),
                    })
                .PrimaryKey(t => t.StreetID);
            
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
                "dbo.Traffic",
                c => new
                    {
                        TrafficID = c.Int(nullable: false, identity: true),
                        Paramameter = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrafficID);
            
            CreateTable(
                "dbo.VegetationCover",
                c => new
                    {
                        VegetationCoverID = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                        Score = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.VegetationCoverID);
            
            CreateTable(
                "dbo.Ward",
                c => new
                    {
                        WardID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Abbreviation = c.String(nullable: false, maxLength: 3),
                        Geom = c.Geometry(),
                    })
                .PrimaryKey(t => t.WardID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SweepStructure", "SweepID", "dbo.Sweep");
            DropForeignKey("dbo.SweepStructure", "StructureID", "dbo.Structure");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Device", "DeviceStatusID", "dbo.DeviceStatus");
            DropForeignKey("dbo.CampaignDevice", "DeviceID", "dbo.Device");
            DropForeignKey("dbo.CampaignDevice", "CampaignID", "dbo.Campaign");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Structure", "StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureType_StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.StructureOwner", "StructureID", "dbo.Structure");
            DropForeignKey("dbo.Face", "StructureID", "dbo.Structure");
            DropForeignKey("dbo.Face", "FaceVisibilityRatingID", "dbo.FaceVisibilityRating");
            DropForeignKey("dbo.Face", "FaceSizeID", "dbo.FaceSize");
            DropForeignKey("dbo.Face", "FacePositionID", "dbo.FacePosition");
            DropForeignKey("dbo.Face", "FaceOccupancyID", "dbo.FaceOccupancy");
            DropForeignKey("dbo.FaceImage", "Face_FaceID1", "dbo.Face");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID1", "dbo.FaceImage");
            DropForeignKey("dbo.Face", "FaceImage_FaceImageID", "dbo.FaceImage");
            DropForeignKey("dbo.FaceImage", "Face_FaceID", "dbo.Face");
            DropForeignKey("dbo.Face", "FaceConditionID", "dbo.FaceCondition");
            DropForeignKey("dbo.Face", "FaceBoundID", "dbo.FaceBound");
            DropForeignKey("dbo.Face", "FaceAvailabilityID", "dbo.FaceAvailability");
            DropForeignKey("dbo.Advert", "FaceID", "dbo.Face");
            DropForeignKey("dbo.Advert", "CampaignID", "dbo.Campaign");
            DropForeignKey("dbo.Campaign", "ProductID", "dbo.Product");
            DropForeignKey("dbo.CampaignRoute", "RouteID", "dbo.Route");
            DropForeignKey("dbo.CampaignRoute", "CampaignID", "dbo.Campaign");
            DropForeignKey("dbo.Campaign", "AgencyID", "dbo.Agency");
            DropForeignKey("dbo.Advert", "AdvertiserID", "dbo.Advertiser");
            DropIndex("dbo.SweepStructure", new[] { "SweepID" });
            DropIndex("dbo.SweepStructure", new[] { "StructureID" });
            DropIndex("dbo.Device", new[] { "DeviceStatusID" });
            DropIndex("dbo.CampaignDevice", new[] { "DeviceID" });
            DropIndex("dbo.CampaignDevice", new[] { "CampaignID" });
            DropIndex("dbo.StructureOwner", new[] { "StructureID" });
            DropIndex("dbo.Structure", new[] { "StructureTypeID" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID1" });
            DropIndex("dbo.FaceImage", new[] { "Face_FaceID" });
            DropIndex("dbo.Face", new[] { "StructureType_StructureTypeID" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID1" });
            DropIndex("dbo.Face", new[] { "FaceImage_FaceImageID" });
            DropIndex("dbo.Face", new[] { "StructureID" });
            DropIndex("dbo.Face", new[] { "FaceAvailabilityID" });
            DropIndex("dbo.Face", new[] { "FaceVisibilityRatingID" });
            DropIndex("dbo.Face", new[] { "FacePositionID" });
            DropIndex("dbo.Face", new[] { "FaceBoundID" });
            DropIndex("dbo.Face", new[] { "FaceConditionID" });
            DropIndex("dbo.Face", new[] { "FaceSizeID" });
            DropIndex("dbo.Face", new[] { "FaceOccupancyID" });
            DropIndex("dbo.CampaignRoute", new[] { "RouteID" });
            DropIndex("dbo.CampaignRoute", new[] { "CampaignID" });
            DropIndex("dbo.Campaign", new[] { "Industry_IndustryID" });
            DropIndex("dbo.Campaign", new[] { "Advertiser_AdvertiserID" });
            DropIndex("dbo.Campaign", new[] { "AgencyID" });
            DropIndex("dbo.Campaign", new[] { "ProductID" });
            DropIndex("dbo.Advert", new[] { "CampaignID" });
            DropIndex("dbo.Advert", new[] { "AdvertiserID" });
            DropIndex("dbo.Advert", new[] { "FaceID" });
            DropTable("dbo.Ward");
            DropTable("dbo.VegetationCover");
            DropTable("dbo.Traffic");
            DropTable("dbo.SweepStructure");
            DropTable("dbo.Sweep");
            DropTable("dbo.Street");
            DropTable("dbo.SiteLighting");
            DropTable("dbo.Industry");
            DropTable("dbo.Constituency");
            DropTable("dbo.Clutter");
            DropTable("dbo.DeviceStatus");
            DropTable("dbo.Device");
            DropTable("dbo.CampaignDevice");
            DropTable("dbo.Backlight");
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
            DropTable("dbo.FaceAvailability");
            DropTable("dbo.Face");
            DropTable("dbo.Product");
            DropTable("dbo.Route");
            DropTable("dbo.CampaignRoute");
            DropTable("dbo.Agency");
            DropTable("dbo.Campaign");
            DropTable("dbo.Advert");
            DropTable("dbo.Advertiser");
        }
    }
}
