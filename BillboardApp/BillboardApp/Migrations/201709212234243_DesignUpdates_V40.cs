namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DesignUpdates_V40 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Advert", "AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Product", "AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Advert", "FaceID", "dbo.Face");
            DropForeignKey("dbo.Face", "FaceOccupancyID", "dbo.FaceOccupancy");
            DropForeignKey("dbo.Face", "FaceBoundID", "dbo.FaceBound");
            DropForeignKey("dbo.Face", "FaceConditionID", "dbo.FaceCondition");
            DropForeignKey("dbo.FaceImage", "FaceID", "dbo.Face");
            DropForeignKey("dbo.Face", "FaceOrientationID", "dbo.FaceOrientation");
            DropForeignKey("dbo.Face", "FacePositionID", "dbo.FacePosition");
            DropForeignKey("dbo.Face", "FaceSizeID", "dbo.FaceSize");
            DropForeignKey("dbo.Face", "StructureID", "dbo.Structure");
            DropForeignKey("dbo.Structure", "StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Structure", "StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Campaign", "AgencyID", "dbo.Agency");
            DropForeignKey("dbo.CampaignRoute", "CampaignID", "dbo.Campaign");
            DropForeignKey("dbo.Campaign", "IndustryID", "dbo.Industry");
            DropForeignKey("dbo.CampaignRoute", "RouteID", "dbo.Route");
            DropForeignKey("dbo.Street", "RouteID", "dbo.Route");
            DropForeignKey("dbo.Industry", "IndustryTypeID", "dbo.IndustryType");
            DropForeignKey("dbo.CampaignDevice", "CampaignID", "dbo.Campaign");
            DropForeignKey("dbo.CampaignDevice", "DeviceID", "dbo.Device");
            DropForeignKey("dbo.Device", "DeviceStatusID", "dbo.DeviceStatus");
            DropForeignKey("dbo.User", "RoleID", "dbo.Role");
            DropForeignKey("dbo.SweepStructure", "SweepID", "dbo.Sweep");
            DropForeignKey("dbo.SweepStructure", "StructureID", "dbo.Structure");
            AddForeignKey("dbo.Advert", "AdvertiserID", "dbo.Advertiser", "AdvertiserID", cascadeDelete: true);
            AddForeignKey("dbo.Campaign", "AdvertiserID", "dbo.Advertiser", "AdvertiserID", cascadeDelete: true);
            AddForeignKey("dbo.Product", "AdvertiserID", "dbo.Advertiser", "AdvertiserID", cascadeDelete: true);
            AddForeignKey("dbo.Advert", "FaceID", "dbo.Face", "FaceID", cascadeDelete: true);
            AddForeignKey("dbo.Face", "FaceOccupancyID", "dbo.FaceOccupancy", "FaceOccupancyID", cascadeDelete: true);
            AddForeignKey("dbo.Face", "FaceBoundID", "dbo.FaceBound", "FaceBoundID", cascadeDelete: true);
            AddForeignKey("dbo.Face", "FaceConditionID", "dbo.FaceCondition", "FaceConditionID", cascadeDelete: true);
            AddForeignKey("dbo.FaceImage", "FaceID", "dbo.Face", "FaceID", cascadeDelete: true);
            AddForeignKey("dbo.Face", "FaceOrientationID", "dbo.FaceOrientation", "FaceOrientationID", cascadeDelete: true);
            AddForeignKey("dbo.Face", "FacePositionID", "dbo.FacePosition", "FacePositionID", cascadeDelete: true);
            AddForeignKey("dbo.Face", "FaceSizeID", "dbo.FaceSize", "FaceSizeID", cascadeDelete: true);
            AddForeignKey("dbo.Face", "StructureID", "dbo.Structure", "StructureID", cascadeDelete: true);
            AddForeignKey("dbo.Structure", "StructureOwnerID", "dbo.StructureOwner", "StructureOwnerID", cascadeDelete: true);
            AddForeignKey("dbo.Structure", "StructureTypeID", "dbo.StructureType", "StructureTypeID", cascadeDelete: true);
            AddForeignKey("dbo.Campaign", "AgencyID", "dbo.Agency", "AgencyID", cascadeDelete: true);
            AddForeignKey("dbo.CampaignRoute", "CampaignID", "dbo.Campaign", "CampaignID", cascadeDelete: true);
            AddForeignKey("dbo.Campaign", "IndustryID", "dbo.Industry", "IndustryID", cascadeDelete: true);
            AddForeignKey("dbo.CampaignRoute", "RouteID", "dbo.Route", "RouteID", cascadeDelete: true);
            AddForeignKey("dbo.Street", "RouteID", "dbo.Route", "RouteID", cascadeDelete: true);
            AddForeignKey("dbo.Industry", "IndustryTypeID", "dbo.IndustryType", "IndustryTypeID", cascadeDelete: true);
            AddForeignKey("dbo.CampaignDevice", "CampaignID", "dbo.Campaign", "CampaignID", cascadeDelete: true);
            AddForeignKey("dbo.CampaignDevice", "DeviceID", "dbo.Device", "DeviceID", cascadeDelete: true);
            AddForeignKey("dbo.Device", "DeviceStatusID", "dbo.DeviceStatus", "DeviceStatusID", cascadeDelete: true);
            AddForeignKey("dbo.User", "RoleID", "dbo.Role", "RoleID", cascadeDelete: true);
            AddForeignKey("dbo.SweepStructure", "SweepID", "dbo.Sweep", "SweepID", cascadeDelete: true);
            AddForeignKey("dbo.SweepStructure", "StructureID", "dbo.Structure", "StructureID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SweepStructure", "StructureID", "dbo.Structure");
            DropForeignKey("dbo.SweepStructure", "SweepID", "dbo.Sweep");
            DropForeignKey("dbo.User", "RoleID", "dbo.Role");
            DropForeignKey("dbo.Device", "DeviceStatusID", "dbo.DeviceStatus");
            DropForeignKey("dbo.CampaignDevice", "DeviceID", "dbo.Device");
            DropForeignKey("dbo.CampaignDevice", "CampaignID", "dbo.Campaign");
            DropForeignKey("dbo.Industry", "IndustryTypeID", "dbo.IndustryType");
            DropForeignKey("dbo.Street", "RouteID", "dbo.Route");
            DropForeignKey("dbo.CampaignRoute", "RouteID", "dbo.Route");
            DropForeignKey("dbo.Campaign", "IndustryID", "dbo.Industry");
            DropForeignKey("dbo.CampaignRoute", "CampaignID", "dbo.Campaign");
            DropForeignKey("dbo.Campaign", "AgencyID", "dbo.Agency");
            DropForeignKey("dbo.Structure", "StructureTypeID", "dbo.StructureType");
            DropForeignKey("dbo.Structure", "StructureOwnerID", "dbo.StructureOwner");
            DropForeignKey("dbo.Face", "StructureID", "dbo.Structure");
            DropForeignKey("dbo.Face", "FaceSizeID", "dbo.FaceSize");
            DropForeignKey("dbo.Face", "FacePositionID", "dbo.FacePosition");
            DropForeignKey("dbo.Face", "FaceOrientationID", "dbo.FaceOrientation");
            DropForeignKey("dbo.FaceImage", "FaceID", "dbo.Face");
            DropForeignKey("dbo.Face", "FaceConditionID", "dbo.FaceCondition");
            DropForeignKey("dbo.Face", "FaceBoundID", "dbo.FaceBound");
            DropForeignKey("dbo.Face", "FaceOccupancyID", "dbo.FaceOccupancy");
            DropForeignKey("dbo.Advert", "FaceID", "dbo.Face");
            DropForeignKey("dbo.Product", "AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Campaign", "AdvertiserID", "dbo.Advertiser");
            DropForeignKey("dbo.Advert", "AdvertiserID", "dbo.Advertiser");
            AddForeignKey("dbo.SweepStructure", "StructureID", "dbo.Structure", "StructureID");
            AddForeignKey("dbo.SweepStructure", "SweepID", "dbo.Sweep", "SweepID");
            AddForeignKey("dbo.User", "RoleID", "dbo.Role", "RoleID");
            AddForeignKey("dbo.Device", "DeviceStatusID", "dbo.DeviceStatus", "DeviceStatusID");
            AddForeignKey("dbo.CampaignDevice", "DeviceID", "dbo.Device", "DeviceID");
            AddForeignKey("dbo.CampaignDevice", "CampaignID", "dbo.Campaign", "CampaignID");
            AddForeignKey("dbo.Industry", "IndustryTypeID", "dbo.IndustryType", "IndustryTypeID");
            AddForeignKey("dbo.Street", "RouteID", "dbo.Route", "RouteID");
            AddForeignKey("dbo.CampaignRoute", "RouteID", "dbo.Route", "RouteID");
            AddForeignKey("dbo.Campaign", "IndustryID", "dbo.Industry", "IndustryID");
            AddForeignKey("dbo.CampaignRoute", "CampaignID", "dbo.Campaign", "CampaignID");
            AddForeignKey("dbo.Campaign", "AgencyID", "dbo.Agency", "AgencyID");
            AddForeignKey("dbo.Structure", "StructureTypeID", "dbo.StructureType", "StructureTypeID");
            AddForeignKey("dbo.Structure", "StructureOwnerID", "dbo.StructureOwner", "StructureOwnerID");
            AddForeignKey("dbo.Face", "StructureID", "dbo.Structure", "StructureID");
            AddForeignKey("dbo.Face", "FaceSizeID", "dbo.FaceSize", "FaceSizeID");
            AddForeignKey("dbo.Face", "FacePositionID", "dbo.FacePosition", "FacePositionID");
            AddForeignKey("dbo.Face", "FaceOrientationID", "dbo.FaceOrientation", "FaceOrientationID");
            AddForeignKey("dbo.FaceImage", "FaceID", "dbo.Face", "FaceID");
            AddForeignKey("dbo.Face", "FaceConditionID", "dbo.FaceCondition", "FaceConditionID");
            AddForeignKey("dbo.Face", "FaceBoundID", "dbo.FaceBound", "FaceBoundID");
            AddForeignKey("dbo.Face", "FaceOccupancyID", "dbo.FaceOccupancy", "FaceOccupancyID");
            AddForeignKey("dbo.Advert", "FaceID", "dbo.Face", "FaceID");
            AddForeignKey("dbo.Product", "AdvertiserID", "dbo.Advertiser", "AdvertiserID");
            AddForeignKey("dbo.Campaign", "AdvertiserID", "dbo.Advertiser", "AdvertiserID");
            AddForeignKey("dbo.Advert", "AdvertiserID", "dbo.Advertiser", "AdvertiserID");
        }
    }
}
