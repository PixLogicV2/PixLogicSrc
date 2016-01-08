namespace PixLogic.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorie",
                c => new
                    {
                        CategorieId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        level = c.Int(nullable: false),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.CategorieId);
            
            CreateTable(
                "dbo.Reservable",
                c => new
                    {
                        ReservableId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReservableId);
            
            CreateTable(
                "dbo.Log",
                c => new
                    {
                        LogId = c.Int(nullable: false, identity: true),
                        isPack = c.Boolean(nullable: false),
                        beginDateEmprunt = c.DateTime(),
                        endDateEmprunt = c.DateTime(),
                        userName = c.String(),
                        userNickname = c.String(),
                        userMail = c.String(),
                        userClasse = c.String(),
                        userPhoneNumber = c.String(),
                        reservableName = c.String(),
                    })
                .PrimaryKey(t => t.LogId);
            
            CreateTable(
                "dbo.MailConfig",
                c => new
                    {
                        MailConfigId = c.Int(nullable: false, identity: true),
                        serveurStmp = c.String(),
                        port = c.Int(nullable: false),
                        email = c.String(),
                        mdp = c.String(),
                    })
                .PrimaryKey(t => t.MailConfigId);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        ManagerId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ManagerId);
            
            CreateTable(
                "dbo.Requete",
                c => new
                    {
                        RequeteId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        text = c.String(),
                    })
                .PrimaryKey(t => t.RequeteId);
            
            CreateTable(
                "dbo.Reservation",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        isPack = c.Boolean(nullable: false),
                        beginDateReservation = c.DateTime(),
                        endDateReservation = c.DateTime(),
                        beginDateEmprunt = c.DateTime(),
                        endDateEmprunt = c.DateTime(),
                        dateRendu = c.DateTime(),
                        manager_ManagerId = c.Int(),
                        reservable_ReservableId = c.Int(),
                        user_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Managers", t => t.manager_ManagerId)
                .ForeignKey("dbo.Reservable", t => t.reservable_ReservableId)
                .ForeignKey("dbo.User", t => t.user_UserId)
                .Index(t => t.manager_ManagerId)
                .Index(t => t.reservable_ReservableId)
                .Index(t => t.user_UserId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        nickname = c.String(),
                        mail = c.String(),
                        phoneNumber = c.String(),
                        image = c.Binary(),
                        credits = c.Int(nullable: false),
                        userClass_UserClassId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.UserClass", t => t.userClass_UserClassId)
                .Index(t => t.userClass_UserClassId);
            
            CreateTable(
                "dbo.UserClass",
                c => new
                    {
                        UserClassId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        credits = c.Int(nullable: false),
                        level = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserClassId);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        ReservableId = c.Int(nullable: false),
                        categorie_CategorieId = c.Int(),
                        pack_ReservableId = c.Int(),
                        description = c.String(),
                        dispo = c.Boolean(nullable: false),
                        image = c.Binary(),
                        reference = c.String(),
                        quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReservableId)
                .ForeignKey("dbo.Reservable", t => t.ReservableId)
                .ForeignKey("dbo.Categorie", t => t.categorie_CategorieId)
                .ForeignKey("dbo.Pack", t => t.pack_ReservableId)
                .Index(t => t.ReservableId)
                .Index(t => t.categorie_CategorieId)
                .Index(t => t.pack_ReservableId);
            
            CreateTable(
                "dbo.Pack",
                c => new
                    {
                        ReservableId = c.Int(nullable: false),
                        description = c.String(),
                        dispo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ReservableId)
                .ForeignKey("dbo.Reservable", t => t.ReservableId)
                .Index(t => t.ReservableId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pack", "ReservableId", "dbo.Reservable");
            DropForeignKey("dbo.Item", "pack_ReservableId", "dbo.Pack");
            DropForeignKey("dbo.Item", "categorie_CategorieId", "dbo.Categorie");
            DropForeignKey("dbo.Item", "ReservableId", "dbo.Reservable");
            DropForeignKey("dbo.Reservation", "user_UserId", "dbo.User");
            DropForeignKey("dbo.User", "userClass_UserClassId", "dbo.UserClass");
            DropForeignKey("dbo.Reservation", "reservable_ReservableId", "dbo.Reservable");
            DropForeignKey("dbo.Reservation", "manager_ManagerId", "dbo.Managers");
            DropIndex("dbo.Pack", new[] { "ReservableId" });
            DropIndex("dbo.Item", new[] { "pack_ReservableId" });
            DropIndex("dbo.Item", new[] { "categorie_CategorieId" });
            DropIndex("dbo.Item", new[] { "ReservableId" });
            DropIndex("dbo.User", new[] { "userClass_UserClassId" });
            DropIndex("dbo.Reservation", new[] { "user_UserId" });
            DropIndex("dbo.Reservation", new[] { "reservable_ReservableId" });
            DropIndex("dbo.Reservation", new[] { "manager_ManagerId" });
            DropTable("dbo.Pack");
            DropTable("dbo.Item");
            DropTable("dbo.UserClass");
            DropTable("dbo.User");
            DropTable("dbo.Reservation");
            DropTable("dbo.Requete");
            DropTable("dbo.Managers");
            DropTable("dbo.MailConfig");
            DropTable("dbo.Log");
            DropTable("dbo.Reservable");
            DropTable("dbo.Categorie");
        }
    }
}
