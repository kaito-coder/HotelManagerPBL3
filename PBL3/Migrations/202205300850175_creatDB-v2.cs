namespace PBL3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creatDBv2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID_Account = c.String(nullable: false, maxLength: 20),
                        ID_Employee = c.String(maxLength: 20),
                        UserName = c.String(maxLength: 100),
                        Password = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID_Account)
                .ForeignKey("dbo.Employees", t => t.ID_Employee)
                .Index(t => t.ID_Employee);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID_Employee = c.String(nullable: false, maxLength: 20),
                        NameEmployee = c.String(maxLength: 100),
                        Gender = c.Boolean(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Phone = c.String(maxLength: 100),
                        CCCD = c.String(maxLength: 100),
                        Address = c.String(maxLength: 100),
                        Date_In = c.DateTime(nullable: false),
                        Salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Employee);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        ID_Bill = c.Int(nullable: false, identity: true),
                        ID_Reservation = c.String(maxLength: 20),
                        DatePay = c.DateTime(nullable: false),
                        Total = c.Double(nullable: false),
                        PaymentMethod = c.String(),
                    })
                .PrimaryKey(t => t.ID_Bill)
                .ForeignKey("dbo.Reservations", t => t.ID_Reservation)
                .Index(t => t.ID_Reservation);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ID_Reservation = c.String(nullable: false, maxLength: 20),
                        CheckIn = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                        ID_Room = c.String(maxLength: 20),
                        ID_Customer = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID_Reservation)
                .ForeignKey("dbo.Customers", t => t.ID_Customer)
                .ForeignKey("dbo.Rooms", t => t.ID_Room)
                .Index(t => t.ID_Room)
                .Index(t => t.ID_Customer);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID_Customer = c.String(nullable: false, maxLength: 20),
                        NameCustomer = c.String(maxLength: 20),
                        Gender = c.Boolean(nullable: false),
                        Phone = c.String(maxLength: 100),
                        CCCD = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID_Customer);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        ID_Room = c.String(nullable: false, maxLength: 20),
                        ID_TypeRoom = c.Int(nullable: false),
                        ID_StatusRoom = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Room)
                .ForeignKey("dbo.StatusRooms", t => t.ID_StatusRoom, cascadeDelete: true)
                .ForeignKey("dbo.TypeRooms", t => t.ID_TypeRoom, cascadeDelete: true)
                .Index(t => t.ID_TypeRoom)
                .Index(t => t.ID_StatusRoom);
            
            CreateTable(
                "dbo.StatusRooms",
                c => new
                    {
                        ID_StatusRoom = c.Int(nullable: false, identity: true),
                        NameStatusRoom = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID_StatusRoom);
            
            CreateTable(
                "dbo.TypeRooms",
                c => new
                    {
                        ID_TypeRoom = c.Int(nullable: false, identity: true),
                        NameTypeRoom = c.String(maxLength: 100),
                        PriceTypeRoom = c.Double(nullable: false),
                        NumberOfBed = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_TypeRoom);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ID_Service = c.String(nullable: false, maxLength: 20),
                        NameService = c.String(maxLength: 100),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Service);
            
            CreateTable(
                "dbo.ServiceReservations",
                c => new
                    {
                        Service_ID_Service = c.String(nullable: false, maxLength: 20),
                        Reservation_ID_Reservation = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => new { t.Service_ID_Service, t.Reservation_ID_Reservation })
                .ForeignKey("dbo.Services", t => t.Service_ID_Service, cascadeDelete: true)
                .ForeignKey("dbo.Reservations", t => t.Reservation_ID_Reservation, cascadeDelete: true)
                .Index(t => t.Service_ID_Service)
                .Index(t => t.Reservation_ID_Reservation);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceReservations", "Reservation_ID_Reservation", "dbo.Reservations");
            DropForeignKey("dbo.ServiceReservations", "Service_ID_Service", "dbo.Services");
            DropForeignKey("dbo.Rooms", "ID_TypeRoom", "dbo.TypeRooms");
            DropForeignKey("dbo.Rooms", "ID_StatusRoom", "dbo.StatusRooms");
            DropForeignKey("dbo.Reservations", "ID_Room", "dbo.Rooms");
            DropForeignKey("dbo.Reservations", "ID_Customer", "dbo.Customers");
            DropForeignKey("dbo.Bills", "ID_Reservation", "dbo.Reservations");
            DropForeignKey("dbo.Accounts", "ID_Employee", "dbo.Employees");
            DropIndex("dbo.ServiceReservations", new[] { "Reservation_ID_Reservation" });
            DropIndex("dbo.ServiceReservations", new[] { "Service_ID_Service" });
            DropIndex("dbo.Rooms", new[] { "ID_StatusRoom" });
            DropIndex("dbo.Rooms", new[] { "ID_TypeRoom" });
            DropIndex("dbo.Reservations", new[] { "ID_Customer" });
            DropIndex("dbo.Reservations", new[] { "ID_Room" });
            DropIndex("dbo.Bills", new[] { "ID_Reservation" });
            DropIndex("dbo.Accounts", new[] { "ID_Employee" });
            DropTable("dbo.ServiceReservations");
            DropTable("dbo.Services");
            DropTable("dbo.TypeRooms");
            DropTable("dbo.StatusRooms");
            DropTable("dbo.Rooms");
            DropTable("dbo.Customers");
            DropTable("dbo.Reservations");
            DropTable("dbo.Bills");
            DropTable("dbo.Employees");
            DropTable("dbo.Accounts");
        }
    }
}
