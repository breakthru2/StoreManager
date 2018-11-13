namespace StoreManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConvertTelToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "TelNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "TelNumber", c => c.Int(nullable: false));
        }
    }
}
