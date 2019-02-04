namespace LoginPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BikeNullable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "BikeId", c => c.Int());
            CreateIndex("dbo.Users", "BikeId");
            AddForeignKey("dbo.Users", "BikeId", "dbo.Bikes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "BikeId", "dbo.Bikes");
            DropIndex("dbo.Users", new[] { "BikeId" });
            DropColumn("dbo.Users", "BikeId");
        }
    }
}
