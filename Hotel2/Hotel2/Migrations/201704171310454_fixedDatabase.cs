namespace Hotel2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Billings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cpf = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        HotelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.HotelId, cascadeDelete: true)
                .Index(t => t.HotelId);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ApplicationUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUserId, cascadeDelete: true)
                .Index(t => t.ApplicationUserId);
            
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreditCardNumber = c.String(),
                        Pass = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        HotelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.HotelId, cascadeDelete: true)
                .Index(t => t.HotelId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        Checkin = c.DateTime(nullable: false),
                        Checkout = c.DateTime(nullable: false),
                        Room_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.Room_Id)
                .Index(t => t.ClientId)
                .Index(t => t.Room_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Room_Id", "dbo.Rooms");
            DropForeignKey("dbo.Reservations", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Billings", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Rooms", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Clients", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", "ApplicationUserId", "dbo.ApplicationUsers");
            DropIndex("dbo.Reservations", new[] { "Room_Id" });
            DropIndex("dbo.Reservations", new[] { "ClientId" });
            DropIndex("dbo.Rooms", new[] { "HotelId" });
            DropIndex("dbo.Hotels", new[] { "ApplicationUserId" });
            DropIndex("dbo.Clients", new[] { "HotelId" });
            DropIndex("dbo.Billings", new[] { "ClientId" });
            DropTable("dbo.Reservations");
            DropTable("dbo.Rooms");
            DropTable("dbo.ApplicationUsers");
            DropTable("dbo.Hotels");
            DropTable("dbo.Clients");
            DropTable("dbo.Billings");
        }
    }
}
