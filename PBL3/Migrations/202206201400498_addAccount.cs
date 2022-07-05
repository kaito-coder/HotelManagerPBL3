namespace PBL3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID_Employee = c.String(nullable: false, maxLength: 20),
                        UserName = c.String(maxLength: 100),
                        Password = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID_Employee)
                .ForeignKey("dbo.Employees", t => t.ID_Employee)
                .Index(t => t.ID_Employee);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "ID_Employee", "dbo.Employees");
            DropIndex("dbo.Accounts", new[] { "ID_Employee" });
            DropTable("dbo.Accounts");
        }
    }
}
