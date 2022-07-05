namespace PBL3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editDBv3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Accounts", "ID_Account", "dbo.Employees");
            DropIndex("dbo.Accounts", new[] { "ID_Account" });
            DropColumn("dbo.Employees", "ID_Account");
            DropTable("dbo.Accounts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID_Account = c.String(nullable: false, maxLength: 20),
                        UserName = c.String(maxLength: 20),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID_Account);
            
            AddColumn("dbo.Employees", "ID_Account", c => c.String(maxLength: 100));
            CreateIndex("dbo.Accounts", "ID_Account");
            AddForeignKey("dbo.Accounts", "ID_Account", "dbo.Employees", "ID_Employee");
        }
    }
}
