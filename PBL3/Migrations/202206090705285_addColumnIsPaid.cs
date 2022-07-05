namespace PBL3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addColumnIsPaid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bills", "IsPaid", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bills", "IsPaid");
        }
    }
}
