namespace StoreManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUserId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Sales", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "UserId", c => c.Int(nullable: false));
        }
    }
}
