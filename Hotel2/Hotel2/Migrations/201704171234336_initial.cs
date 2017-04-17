namespace Hotel2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Billings", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Clients", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", "ApplicationUserId", "dbo.ApplicationUsers");
            DropForeignKey("dbo.Rooms", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Reservations", "ClientId", "dbo.Clients");
            DropIndex("dbo.Reservations", new[] { "RoomId" });
            RenameColumn(table: "dbo.Reservations", name: "RoomId", newName: "Room_Id");
            AlterColumn("dbo.Reservations", "Room_Id", c => c.Int());
            CreateIndex("dbo.Reservations", "Room_Id");
            AddForeignKey("dbo.Billings", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Clients", "HotelId", "dbo.Hotels", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Hotels", "ApplicationUserId", "dbo.ApplicationUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rooms", "HotelId", "dbo.Hotels", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reservations", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Rooms", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", "ApplicationUserId", "dbo.ApplicationUsers");
            DropForeignKey("dbo.Clients", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Billings", "ClientId", "dbo.Clients");
            DropIndex("dbo.Reservations", new[] { "Room_Id" });
            AlterColumn("dbo.Reservations", "Room_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Reservations", name: "Room_Id", newName: "RoomId");
            CreateIndex("dbo.Reservations", "RoomId");
            AddForeignKey("dbo.Reservations", "ClientId", "dbo.Clients", "Id");
            AddForeignKey("dbo.Rooms", "HotelId", "dbo.Hotels", "Id");
            AddForeignKey("dbo.Hotels", "ApplicationUserId", "dbo.ApplicationUsers", "Id");
            AddForeignKey("dbo.Clients", "HotelId", "dbo.Hotels", "Id");
            AddForeignKey("dbo.Billings", "ClientId", "dbo.Clients", "Id");
        }
    }
}
