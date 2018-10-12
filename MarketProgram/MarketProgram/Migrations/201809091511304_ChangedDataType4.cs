namespace MarketProgram.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDataType4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ShopProducts", "BuyerId", "dbo.Buyers");
            DropIndex("dbo.ShopProducts", new[] { "BuyerId" });
            DropColumn("dbo.ShopProducts", "WeightId");
            DropColumn("dbo.TopSellingStations", "WeightId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TopSellingStations", "WeightId", c => c.Int(nullable: false));
            AddColumn("dbo.ShopProducts", "WeightId", c => c.Int(nullable: false));
            CreateIndex("dbo.ShopProducts", "BuyerId");
            AddForeignKey("dbo.ShopProducts", "BuyerId", "dbo.Buyers", "Id", cascadeDelete: true);
        }
    }
}
