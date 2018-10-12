namespace MarketProgram.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForDataTypeCount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShopProducts", "Count", c => c.Short(nullable: false));
            AddColumn("dbo.TopSellingStations", "Count", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TopSellingStations", "Count");
            DropColumn("dbo.ShopProducts", "Count");
        }
    }
}
