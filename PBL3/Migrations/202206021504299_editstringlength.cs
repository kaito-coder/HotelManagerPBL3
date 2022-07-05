namespace PBL3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editstringlength : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservations", "ID_Room", "dbo.Rooms");
            DropIndex("dbo.Reservations", new[] { "ID_Room" });
            DropPrimaryKey("dbo.Rooms");
            AlterColumn("dbo.Reservations", "ID_Room", c => c.String(maxLength: 10));
            AlterColumn("dbo.Rooms", "ID_Room", c => c.String(nullable: false, maxLength: 10));
            AddPrimaryKey("dbo.Rooms", "ID_Room");
            CreateIndex("dbo.Reservations", "ID_Room");
            AddForeignKey("dbo.Reservations", "ID_Room", "dbo.Rooms", "ID_Room");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "ID_Room", "dbo.Rooms");
            DropIndex("dbo.Reservations", new[] { "ID_Room" });
            DropPrimaryKey("dbo.Rooms");
            AlterColumn("dbo.Rooms", "ID_Room", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Reservations", "ID_Room", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Rooms", "ID_Room");
            CreateIndex("dbo.Reservations", "ID_Room");
            AddForeignKey("dbo.Reservations", "ID_Room", "dbo.Rooms", "ID_Room");
        }
    }
}
