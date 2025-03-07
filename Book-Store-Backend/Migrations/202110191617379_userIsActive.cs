namespace Book_Store_Backend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userIsActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "isActive", c => c.Boolean(nullable: false, defaultValue: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "isActive");
        }
    }
}
