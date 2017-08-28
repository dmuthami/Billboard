﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillboardApp
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
        public virtual DbSet<Backlight> Backlights { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<CampaignDevice> CampaignDevices { get; set; }
        public virtual DbSet<CampaignRoute> CampaignRoutes { get; set; }
        public virtual DbSet<Clutter> Clutters { get; set; }
        public virtual DbSet<Constituency> Constituencies { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<DeviceStatu> DeviceStatus { get; set; }
        public virtual DbSet<Face> Faces { get; set; }
        public virtual DbSet<FaceAvailability> FaceAvailabilities { get; set; }
        public virtual DbSet<FaceBound> FaceBounds { get; set; }
        public virtual DbSet<FaceCondition> FaceConditions { get; set; }
        public virtual DbSet<FaceImage> FaceImages { get; set; }
        public virtual DbSet<FaceOccupancy> FaceOccupancies { get; set; }
        public virtual DbSet<FaceOrientation> FaceOrientations { get; set; }
        public virtual DbSet<FacePosition> FacePositions { get; set; }
        public virtual DbSet<FaceSize> FaceSizes { get; set; }
        public virtual DbSet<FaceVisibilityRating> FaceVisibilityRatings { get; set; }
        public virtual DbSet<Industry> Industries { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<SiteLighting> SiteLightings { get; set; }
        public virtual DbSet<SiteRunUp> SiteRunUps { get; set; }
        public virtual DbSet<Street> Streets { get; set; }
        public virtual DbSet<Structure> Structures { get; set; }
        public virtual DbSet<StructureOwner> StructureOwners { get; set; }
        public virtual DbSet<StructureType> StructureTypes { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<Sweep> Sweeps { get; set; }
        public virtual DbSet<SweepStructure> SweepStructures { get; set; }
        public virtual DbSet<Traffic> Traffic { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VegetationCover> VegetationCovers { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }
    }
}