using BillboardApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BillboardApp.DAL
{
    public class BillboardContext : DbContext
    {
        public BillboardContext()
            : base("BillboardContext")
        {
            //Database.SetInitializer<SchoolContext>(new SchoolInitializer());
            //Database.SetInitializer(new SchoolInitializer());
        }

        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Advertiser> Advertisers { get; set; }
        public DbSet<Agency> Agencys { get; set; }
        public DbSet<Backlight> Backlights { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<CampaignDevice> CampaignDevices { get; set; }
        //public DbSet<CampaignRoute> CampaignRoutes { get; set; }
        public DbSet<FaceClutter> FaceClutters { get; set; }
        public DbSet<Constituency> Constituencys { get; set; }
        public DbSet<County> Countys { get; set; }

        public DbSet<Device> Devices { get; set; }
        public DbSet<DeviceStatus> DeviceStatuses { get; set; }
        public DbSet<Face> Faces { get; set; }
        public DbSet<FaceOccupancy> FaceOccupancies { get; set; }
        public DbSet<FaceBound> FaceBounds { get; set; }       
        public DbSet<FaceCondition> FaceConditions { get; set; }
        public DbSet<FaceImage> FaceImages { get; set; }
        public DbSet<FacePosition> FacePosition { get; set; }        
        public DbSet<FaceSize> FaceSize { get; set; }

        public DbSet<FaceVisibilityRating> FaceVisibilityRatings { get; set; }
        public DbSet<Industry> Industrys { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<FaceLighting> FaceLightings { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Structure> Structures { get; set; }
        public DbSet<StructureOwner> StructureOwners { get; set; }
        public DbSet<StructureType> StructureTypes { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        public DbSet<Sweep> Sweeps { get; set; }
        public DbSet<SweepStructure> SweepStructures { get; set; }
        public DbSet<FaceTraffic> FaceTraffics { get; set; }
        public DbSet<VegetationCover> VegetationCovers { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<FaceOrientation> FaceOrientations { get; set; }
        public DbSet<FaceRunUp> SiteRunUps { get; set; }
        public DbSet<conauth> conauths { get; set; }


        public DbSet<concompany> concompanys { get; set; }
        public DbSet<conconfigurations> conconfigurationz { get; set; }
        public DbSet<conconfigurationtype> conconfigurationtypes { get; set; }
        public DbSet<conindustry> conindustrys { get; set; }
        public DbSet<conlife> conlife { get; set; }
        public DbSet<connotifications> connotificationz { get; set; }
        public DbSet<conobjectrights> conobjectrightz { get; set; }
        public DbSet<conobjects> conobjectz { get; set; }
        public DbSet<conobjectscaption> conobjectscaptionz { get; set; }
        public DbSet<conprofiles> conprofilez { get; set; }

        public DbSet<conroles> conrolez { get; set; }
        public DbSet<conuser> conusers { get; set; }
        public DbSet<conuserrecovery> conuserrecoverys { get; set; }
        public DbSet<conuserrecoverytype> conuserrecoverytypes { get; set; }
        public DbSet<conuserroles> conuserroles { get; set; }
        public System.Data.Entity.DbSet<BillboardApp.Models.IndustryType> IndustryTypes { get; set; }
        public DbSet<StreetGIS> StreetGISz { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // Configure Agency & Subscription entity one to one
            modelBuilder.Entity<Agency>()
                        .HasOptional(s => s.Subscription) // Mark Subscription property optional in Agency entity
                        // mark Agency property as required in Subscription entity. 
                        //Cannot save Subscription without Agency
                        .WithRequired(subscription => subscription.Agency)
                        .WillCascadeOnDelete(true);
        
            //County 
            modelBuilder.Entity<County>().HasKey(t => t.Code)
                .Property(t=>t.Code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //configure Face & Face Visibility Rating entities on to a one to one relationship

            modelBuilder.Entity<Face>().HasOptional(f => f.FaceVisibilityRating)
                .WithRequired(faceVisibilityRating => faceVisibilityRating.Face);

        }

        
    }
}