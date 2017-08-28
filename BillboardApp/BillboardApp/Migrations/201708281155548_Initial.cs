namespace BillboardApp.Migrations
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
                        FaceConditionID = c.Int(nullable: false),
                        FaceBoundID = c.Int(nullable: false),
                        FacePositionID = c.Int(nullable: false),
                        FaceAvailabilityID = c.Int(nullable: false),
                        StructureID = c.Int(nullable: false),
                        FaceOrientationID = c.Int(nullable: false),
                        StructureOwner_StructureOwnerID = c.Int(),
                    })
                .PrimaryKey(t => t.FaceID)
                .ForeignKey("dbo.FaceAvailability", t => t.FaceAvailabilityID)
                .ForeignKey("dbo.FaceBound", t => t.FaceBoundID)
                .ForeignKey("dbo.FaceCondition", t => t.FaceConditionID)
                .ForeignKey("dbo.FaceOccupancy", t => t.FaceOccupancyID)
                .ForeignKey("dbo.FaceOrientation", t => t.FaceOrientationID)
                .ForeignKey("dbo.FacePosition", t => t.FacePositionID)
                .ForeignKey("dbo.FaceSize", t => t.FaceSizeID)
                .ForeignKey("dbo.Structure", t => t.StructureID)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID)
                .Index(t => t.FaceOccupancyID)
                .Index(t => t.FaceSizeID)
                .Index(t => t.FaceConditionID)
                .Index(t => t.FaceBoundID)
                .Index(t => t.FacePositionID)
                .Index(t => t.FaceAvailabilityID)
                .Index(t => t.StructureID)
                .Index(t => t.FaceOrientationID)
                .Index(t => t.StructureOwner_StructureOwnerID);
            
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
                        Image = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        FaceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FaceImageID)
                .ForeignKey("dbo.Face", t => t.FaceID)
                .Index(t => t.FaceID);
            
            CreateTable(
                "dbo.FaceOccupancy",
                c => new
                    {
                        FaceOccupancyID = c.Int(nullable: false, identity: true),
                        Occupancy = c.String(),
                    })
                .PrimaryKey(t => t.FaceOccupancyID);
            
            CreateTable(
                "dbo.FaceOrientation",
                c => new
                    {
                        FaceOrientationID = c.Int(nullable: false, identity: true),
                        Orientation = c.String(),
                    })
                .PrimaryKey(t => t.FaceOrientationID);
            
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
                        StructureOwnerID = c.Int(nullable: false),
                        StructureOwner_StructureOwnerID = c.Int(),
                    })
                .PrimaryKey(t => t.StructureID)
                .ForeignKey("dbo.StructureOwner", t => t.StructureOwner_StructureOwnerID)
                .ForeignKey("dbo.StructureType", t => t.StructureTypeID)
                .Index(t => t.StructureTypeID)
                .Index(t => t.StructureOwner_StructureOwnerID);
            
            CreateTable(
                "dbo.StructureOwner",
                c => new
                    {
                        StructureOwnerID = c.Int(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        MobileNumber = c.String(),
                        Structure_StructureID = c.Int(),
                    })
                .PrimaryKey(t => t.StructureOwnerID)
                .ForeignKey("dbo.Structure", t => t.Structure_StructureID)
                .Index(t => t.Structure_StructureID);
            
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
                "dbo.County",
                c => new
                    {
                        Code = c.Int(nullable: false),
                        DateCreated = c.DateTime(),
                        DateRetired = c.DateTime(),
                        Name = c.String(nullable: false, maxLength: 50),
                        Abbreviation = c.String(nullable: false, maxLength: 3),
                        Geom = c.Geometry(),
                    })
                .PrimaryKey(t => t.Code);
            
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
                "dbo.Industry",
                c => new
                    {
                        IndustryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IndustryID);
            
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
                "dbo.SiteRunUp",
                c => new
                    {
                        SiteRunUpID = c.Int(nullable: false, identity: true),
                        DistanceOption = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SiteRunUpID);
            
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
            DropForeignKey("dbo.User", "RoleID", "dbo.Role");
            DropForeignKey("dbo.Campaign", "Industry_IndustryID", "dbo.Industry");
            DropForeignKey("dbo.Device", "DeviceStatusID", "dbo.DeviceStatus");
            DropForeignKey("dbo.CampaignDevice", "DeviceID", "dbo.Device");
            DropForeignKey("dbo.CampaignDevice", "CampaignID", "dbo.Campaign");
            DropForeignKey("dbo.Campaign", "Advertiser_AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Structure", "StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.StructureOwner", "Structure_StructureID", "dbo.Structure");
            DropForeignKey("dbo.Structure", "StructureOwner_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureOwner_StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureID", "dbo.Structure");
            DropForeignKey("dbo.Face", "FaceSizeID", "dbo.FaceSize");
            DropForeignKey("dbo.Face", "FacePositionID", "dbo.FacePosition");
            DropForeignKey("dbo.Face", "FaceOrientationID", "dbo.FaceOrientation");
            DropForeignKey("dbo.Face", "FaceOccupancyID", "dbo.FaceOccupancy");
            DropForeignKey("dbo.FaceImage", "FaceID", "dbo.Face");
            DropForeignKey("dbo.Face", "FaceConditionID", "dbo.FaceCondition");
            DropForeignKey("dbo.Face", "FaceBoundID", "dbo.FaceBound");
            DropForeignKey("dbo.Face", "FaceAvailabilityID", "dbo.FaceAvailability");
            DropForeignKey("dbo.Advert", "FaceID", "dbo.Face");
            DropForeignKey("dbo.Advert", "CampaignID", "dbo.Campaign");
            DropForeignKey("dbo.Campaign", "ProductID", "dbo.Product");
            DropForeignKey("dbo.CampaignRoute", "RouteID", "dbo.Route");
            DropForeignKey("dbo.CampaignRoute", "CampaignID", "dbo.Campaign");
            DropForeignKey("dbo.Subscription", "SubscriptionID", "dbo.Agency");
            DropForeignKey("dbo.Campaign", "AgencyID", "dbo.Agency");
            DropForeignKey("dbo.Advert", "AdvertiserID", "dbo.Advertiser");
            DropIndex("dbo.SweepStructure", new[] { "SweepID" });
            DropIndex("dbo.SweepStructure", new[] { "StructureID" });
            DropIndex("dbo.User", new[] { "RoleID" });
            DropIndex("dbo.Device", new[] { "DeviceStatusID" });
            DropIndex("dbo.CampaignDevice", new[] { "DeviceID" });
            DropIndex("dbo.CampaignDevice", new[] { "CampaignID" });
            DropIndex("dbo.StructureOwner", new[] { "Structure_StructureID" });
            DropIndex("dbo.Structure", new[] { "StructureOwner_StructureOwnerID" });
            DropIndex("dbo.Structure", new[] { "StructureTypeID" });
            DropIndex("dbo.FaceImage", new[] { "FaceID" });
            DropIndex("dbo.Face", new[] { "StructureOwner_StructureOwnerID" });
            DropIndex("dbo.Face", new[] { "FaceOrientationID" });
            DropIndex("dbo.Face", new[] { "StructureID" });
            DropIndex("dbo.Face", new[] { "FaceAvailabilityID" });
            DropIndex("dbo.Face", new[] { "FacePositionID" });
            DropIndex("dbo.Face", new[] { "FaceBoundID" });
            DropIndex("dbo.Face", new[] { "FaceConditionID" });
            DropIndex("dbo.Face", new[] { "FaceSizeID" });
            DropIndex("dbo.Face", new[] { "FaceOccupancyID" });
            DropIndex("dbo.CampaignRoute", new[] { "RouteID" });
            DropIndex("dbo.CampaignRoute", new[] { "CampaignID" });
            DropIndex("dbo.Subscription", new[] { "SubscriptionID" });
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
            DropTable("dbo.SiteRunUp");
            DropTable("dbo.SiteLighting");
            DropTable("dbo.User");
            DropTable("dbo.Role");
            DropTable("dbo.Industry");
            DropTable("dbo.FaceVisibilityRating");
            DropTable("dbo.County");
            DropTable("dbo.Constituency");
            DropTable("dbo.Clutter");
            DropTable("dbo.DeviceStatus");
            DropTable("dbo.Device");
            DropTable("dbo.CampaignDevice");
            DropTable("dbo.Backlight");
            DropTable("dbo.StructureType");
            DropTable("dbo.StructureOwner");
            DropTable("dbo.Structure");
            DropTable("dbo.FaceSize");
            DropTable("dbo.FacePosition");
            DropTable("dbo.FaceOrientation");
            DropTable("dbo.FaceOccupancy");
            DropTable("dbo.FaceImage");
            DropTable("dbo.FaceCondition");
            DropTable("dbo.FaceBound");
            DropTable("dbo.FaceAvailability");
            DropTable("dbo.Face");
            DropTable("dbo.Product");
            DropTable("dbo.Route");
            DropTable("dbo.CampaignRoute");
            DropTable("dbo.Subscription");
            DropTable("dbo.Agency");
            DropTable("dbo.Campaign");
            DropTable("dbo.Advert");
            DropTable("dbo.Advertiser");
        }
    }
}
