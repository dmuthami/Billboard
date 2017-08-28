namespace BillboardApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserManagement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.conauth",
                c => new
                    {
                        authId = c.Int(nullable: false, identity: true),
                        username = c.String(maxLength: 200),
                        password = c.String(maxLength: 200),
                        loginKey = c.String(maxLength: 50),
                        userId = c.Int(nullable: false),
                        profileId = c.Int(nullable: false),
                        statusId = c.Int(nullable: false),
                        customerId = c.Int(nullable: false),
                        supplierId = c.Int(nullable: false),
                        employeeId = c.Int(nullable: false),
                        branchId = c.Int(nullable: false),
                        life = c.Int(nullable: false),
                        createbyId = c.Int(nullable: false),
                        createdt = c.DateTime(nullable: false),
                        writebyId = c.Int(nullable: false),
                        writedt = c.Int(nullable: false),
                        companyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.authId);
            
            CreateTable(
                "dbo.concompany",
                c => new
                    {
                        companyId = c.Int(nullable: false, identity: true),
                        logo = c.String(maxLength: 100),
                        regDate = c.DateTime(nullable: false),
                        companyNo = c.String(maxLength: 15),
                        startDate = c.DateTime(),
                        companyName = c.String(maxLength: 100),
                        companyInitials = c.String(maxLength: 40),
                        taxpinNo = c.String(maxLength: 50),
                        branches = c.String(maxLength: 3),
                        memo = c.String(maxLength: 200),
                        age = c.Int(nullable: false),
                        countryId = c.Int(nullable: false),
                        industryId = c.Int(nullable: false),
                        physicalAddress = c.String(maxLength: 50),
                        primaryMobileNo = c.String(maxLength: 50),
                        otherMobileNo = c.String(maxLength: 50),
                        primaryLandline = c.String(maxLength: 50),
                        otherLandline = c.String(maxLength: 50),
                        primaryEmail = c.String(maxLength: 50),
                        otherEmail = c.String(maxLength: 50),
                        boxAddress = c.String(maxLength: 50),
                        boxAddressCode = c.String(maxLength: 10),
                        boxAddressTown = c.String(maxLength: 50),
                        websiteUrl = c.String(maxLength: 50),
                        life = c.Int(nullable: false),
                        createbyId = c.Int(nullable: false),
                        createdt = c.DateTime(),
                        writebyId = c.Int(nullable: false),
                        writedt = c.DateTime(),
                    })
                .PrimaryKey(t => t.companyId);
            
            CreateTable(
                "dbo.conconfigurationtype",
                c => new
                    {
                        configurationTypeId = c.Int(nullable: false, identity: true),
                        configurationTypeName = c.String(maxLength: 50),
                        life = c.Int(nullable: false),
                        createbyId = c.Int(nullable: false),
                        createDt = c.DateTime(nullable: false),
                        writebyId = c.Int(nullable: false),
                        writedt = c.DateTime(),
                        companyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.configurationTypeId);
            
            CreateTable(
                "dbo.conconfigurations",
                c => new
                    {
                        configurationsId = c.Int(nullable: false, identity: true),
                        configkey = c.String(maxLength: 50),
                        configvalue = c.String(),
                        configurationTypeId = c.Int(nullable: false),
                        life = c.Int(nullable: false),
                        createbyId = c.Int(nullable: false),
                        createdt = c.DateTime(),
                        writebyId = c.Int(nullable: false),
                        writedt = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.configurationsId);
            
            CreateTable(
                "dbo.conindustry",
                c => new
                    {
                        industryId = c.Int(nullable: false, identity: true),
                        industry = c.String(maxLength: 100),
                        industryCode = c.String(maxLength: 50),
                        life = c.Int(nullable: false),
                        createbyId = c.Int(nullable: false),
                        createdt = c.DateTime(nullable: false),
                        writebyId = c.Int(nullable: false),
                        writedt = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.industryId);
            
            CreateTable(
                "dbo.conlife",
                c => new
                    {
                        lifeId = c.Int(nullable: false, identity: true),
                        descriprion = c.String(maxLength: 30),
                        system = c.Int(nullable: false),
                        life = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.lifeId);
            
            CreateTable(
                "dbo.connotifications",
                c => new
                    {
                        notificationsId = c.Int(nullable: false, identity: true),
                        objectId = c.Int(nullable: false),
                        notifTableName = c.String(maxLength: 50),
                        notifColumnName = c.String(maxLength: 50),
                        notifCriteria = c.String(),
                        life = c.Int(nullable: false),
                        createbyId = c.Int(nullable: false),
                        createdt = c.DateTime(),
                        writebyId = c.Int(nullable: false),
                        writedt = c.DateTime(),
                    })
                .PrimaryKey(t => t.notificationsId);
            
            CreateTable(
                "dbo.conobjectrights",
                c => new
                    {
                        objectRightsId = c.Int(nullable: false, identity: true),
                        profileId = c.Int(nullable: false),
                        objectId = c.Int(nullable: false),
                        canview = c.Int(nullable: false),
                        canadd = c.Int(nullable: false),
                        canedit = c.Int(nullable: false),
                        candel = c.Int(nullable: false),
                        canauthorize = c.Int(nullable: false),
                        canapprove = c.Int(nullable: false),
                        canexport = c.Int(nullable: false),
                        life = c.Int(nullable: false),
                        createbyId = c.Int(nullable: false),
                        createdt = c.DateTime(nullable: false),
                        writebyId = c.Int(nullable: false),
                        writedt = c.DateTime(),
                    })
                .PrimaryKey(t => t.objectRightsId);
            
            CreateTable(
                "dbo.conobjectscaption",
                c => new
                    {
                        objectCaptionId = c.Int(nullable: false, identity: true),
                        objectId = c.Int(nullable: false),
                        industryId = c.Int(nullable: false),
                        objectCaptionName = c.String(),
                        icons = c.String(maxLength: 100),
                        islarge = c.String(maxLength: 50),
                        quicklink = c.Int(nullable: false),
                        setpath = c.String(),
                        reportpath = c.String(),
                        objectCaptionSort = c.Int(nullable: false),
                        available = c.Int(nullable: false),
                        life = c.Int(nullable: false),
                        createbyId = c.Int(nullable: false),
                        createdt = c.DateTime(),
                        writebyId = c.Int(nullable: false),
                        writedt = c.DateTime(),
                        companyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.objectCaptionId);
            
            CreateTable(
                "dbo.conobjects",
                c => new
                    {
                        objectId = c.Int(nullable: false, identity: true),
                        objectCode = c.String(maxLength: 50),
                        level = c.Int(nullable: false),
                        parentObjectId = c.Int(nullable: false),
                        isreport = c.Int(nullable: false),
                        isgraph = c.Int(nullable: false),
                        isbuttonselect = c.Int(nullable: false),
                        isbuttonselectwithmenu = c.Int(nullable: false),
                        hasnotification = c.Int(nullable: false),
                        hasreportsubmenu = c.Int(nullable: false),
                        life = c.Int(nullable: false),
                        createbyId = c.Int(nullable: false),
                        createdt = c.DateTime(),
                        writebyId = c.Int(nullable: false),
                        writedt = c.DateTime(nullable: false),
                        objectName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.objectId);
            
            CreateTable(
                "dbo.conprofiles",
                c => new
                    {
                        profileId = c.Int(nullable: false, identity: true),
                        profilename = c.String(maxLength: 30),
                        companyId = c.Int(nullable: false),
                        life = c.Int(nullable: false),
                        createbyId = c.Int(nullable: false),
                        createdt = c.DateTime(),
                        writebyId = c.Int(nullable: false),
                        writedt = c.DateTime(),
                    })
                .PrimaryKey(t => t.profileId);
            
            CreateTable(
                "dbo.conroles",
                c => new
                    {
                        roleid = c.Int(nullable: false, identity: true),
                        rolename = c.String(maxLength: 50),
                        homepage = c.String(maxLength: 50),
                        dashboard = c.String(maxLength: 100),
                        companyId = c.Int(nullable: false),
                        life = c.Int(nullable: false),
                        createbyId = c.Int(nullable: false),
                        createdt = c.DateTime(),
                        writebyId = c.Int(nullable: false),
                        writedt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.roleid);
            
            CreateTable(
                "dbo.conuserrecovery",
                c => new
                    {
                        userRecoveryId = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                        userRecoveryTypeId = c.Int(nullable: false),
                        recoveryCode = c.String(maxLength: 50),
                        expiryDateTime = c.DateTime(),
                        isRecovered = c.Int(nullable: false),
                        dateTimeRecovered = c.DateTime(nullable: false),
                        life = c.Int(nullable: false),
                        createbyId = c.Int(nullable: false),
                        createdt = c.DateTime(nullable: false),
                        writebyId = c.Int(nullable: false),
                        writedt = c.DateTime(nullable: false),
                        companyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.userRecoveryId);
            
            CreateTable(
                "dbo.conuserrecoverytype",
                c => new
                    {
                        userRecoveryTypeId = c.Int(nullable: false, identity: true),
                        recoveryTypeName = c.String(maxLength: 50),
                        life = c.Int(nullable: false),
                        createbyId = c.Int(nullable: false),
                        createdt = c.DateTime(),
                        writebyId = c.Int(nullable: false),
                        writedt = c.DateTime(),
                        companyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.userRecoveryTypeId);
            
            CreateTable(
                "dbo.conuserroles",
                c => new
                    {
                        userroleid = c.Int(nullable: false, identity: true),
                        userid = c.Int(nullable: false),
                        roleid = c.Int(nullable: false),
                        mainrole = c.Int(nullable: false),
                        companyId = c.Int(nullable: false),
                        life = c.Int(nullable: false),
                        createbyId = c.Int(nullable: false),
                        createdt = c.DateTime(),
                        writebyId = c.Int(nullable: false),
                        writedt = c.DateTime(),
                    })
                .PrimaryKey(t => t.userroleid);
            
            CreateTable(
                "dbo.conuser",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        surname = c.String(),
                        otherName = c.String(),
                        recoveryphone = c.String(),
                        recoveryemail = c.String(),
                        profileId = c.Int(nullable: false),
                        status = c.Int(nullable: false),
                        companyId = c.Int(nullable: false),
                        life = c.Int(nullable: false),
                        createbyId = c.Int(nullable: false),
                        createdt = c.DateTime(),
                        writebyId = c.Int(nullable: false),
                        writedt = c.DateTime(),
                    })
                .PrimaryKey(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.conuser");
            DropTable("dbo.conuserroles");
            DropTable("dbo.conuserrecoverytype");
            DropTable("dbo.conuserrecovery");
            DropTable("dbo.conroles");
            DropTable("dbo.conprofiles");
            DropTable("dbo.conobjects");
            DropTable("dbo.conobjectscaption");
            DropTable("dbo.conobjectrights");
            DropTable("dbo.connotifications");
            DropTable("dbo.conlife");
            DropTable("dbo.conindustry");
            DropTable("dbo.conconfigurations");
            DropTable("dbo.conconfigurationtype");
            DropTable("dbo.concompany");
            DropTable("dbo.conauth");
        }
    }
}
