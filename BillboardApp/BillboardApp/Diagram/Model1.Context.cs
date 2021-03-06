﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillboardApp.Diagram
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Advert> Adverts { get; set; }
        public virtual DbSet<Advertiser> Advertisers { get; set; }
        public virtual DbSet<Agency> Agencies { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Backlight> Backlights { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<CampaignDevice> CampaignDevices { get; set; }
        public virtual DbSet<CampaignRoute> CampaignRoutes { get; set; }
        public virtual DbSet<conauth> conauths { get; set; }
        public virtual DbSet<concompany> concompanies { get; set; }
        public virtual DbSet<conconfiguration> conconfigurations { get; set; }
        public virtual DbSet<conconfigurationtype> conconfigurationtypes { get; set; }
        public virtual DbSet<conindustry> conindustries { get; set; }
        public virtual DbSet<conlife> conlives { get; set; }
        public virtual DbSet<connotification> connotifications { get; set; }
        public virtual DbSet<conobjectright> conobjectrights { get; set; }
        public virtual DbSet<conobject> conobjects { get; set; }
        public virtual DbSet<conobjectscaption> conobjectscaptions { get; set; }
        public virtual DbSet<conprofile> conprofiles { get; set; }
        public virtual DbSet<conrole> conroles { get; set; }
        public virtual DbSet<Constituency> Constituencies { get; set; }
        public virtual DbSet<conuser> conusers { get; set; }
        public virtual DbSet<conuserrecovery> conuserrecoveries { get; set; }
        public virtual DbSet<conuserrecoverytype> conuserrecoverytypes { get; set; }
        public virtual DbSet<conuserrole> conuserroles { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<DeviceStatu> DeviceStatus { get; set; }
        public virtual DbSet<Face> Faces { get; set; }
        public virtual DbSet<FaceBound> FaceBounds { get; set; }
        public virtual DbSet<FaceClutter> FaceClutters { get; set; }
        public virtual DbSet<FaceCondition> FaceConditions { get; set; }
        public virtual DbSet<FaceImage> FaceImages { get; set; }
        public virtual DbSet<FaceLighting> FaceLightings { get; set; }
        public virtual DbSet<FaceOccupancy> FaceOccupancies { get; set; }
        public virtual DbSet<FaceOrientation> FaceOrientations { get; set; }
        public virtual DbSet<FacePosition> FacePositions { get; set; }
        public virtual DbSet<FaceRunUp> FaceRunUps { get; set; }
        public virtual DbSet<FaceSize> FaceSizes { get; set; }
        public virtual DbSet<FaceTraffic> FaceTraffics { get; set; }
        public virtual DbSet<FaceVisibilityRating> FaceVisibilityRatings { get; set; }
        public virtual DbSet<Industry> Industries { get; set; }
        public virtual DbSet<IndustryType> IndustryTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Street> Streets { get; set; }
        public virtual DbSet<StreetGI> StreetGIS { get; set; }
        public virtual DbSet<Structure> Structures { get; set; }
        public virtual DbSet<StructureOwner> StructureOwners { get; set; }
        public virtual DbSet<StructureType> StructureTypes { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<Sweep> Sweeps { get; set; }
        public virtual DbSet<SweepStructure> SweepStructures { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VegetationCover> VegetationCovers { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }
    }
}
