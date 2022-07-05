namespace PBL3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropTableAccount : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Accounts", "ID_Employee", "dbo.Employees");
            DropIndex("dbo.Accounts", new[] { "ID_Employee" });
            DropTable("dbo.Accounts");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.ID_Account);
            
            CreateIndex("dbo.Accounts", "ID_Employee");
            AddForeignKey("dbo.Accounts", "ID_Employee", "dbo.Employees", "ID_Employee");
        }
    }
}
