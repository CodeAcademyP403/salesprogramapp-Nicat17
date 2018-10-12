namespace MarketProgram.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDataType : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ShopProducts", "BuyerId", "dbo.Buyers");
            DropIndex("dbo.ShopProducts", new[] { "BuyerId" });
            AddColumn("dbo.ShopProducts", "Buyer_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.ShopProducts", "BuyerId", c => c.String());
            AlterColumn("dbo.ShopProducts", "WeightId", c => c.String());
            AlterColumn("dbo.TopSellingStations", "WeightId", c => c.String());
            CreateIndex("dbo.ShopProducts", "Buyer_Id");
            AddForeignKey("dbo.ShopProducts", "Buyer_Id", "dbo.Buyers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShopProducts", "Buyer_Id", "dbo.Buyers");
            DropIndex("dbo.ShopProducts", new[] { "Buyer_Id" });
            AlterColumn("dbo.TopSellingStations", "WeightId", c => c.Int(nullable: false));
            AlterColumn("dbo.ShopProducts", "WeightId", c => c.Int(nullable: false));
            AlterColumn("dbo.ShopProducts", "BuyerId", c => c.Int(nullable: false));
            DropColumn("dbo.ShopProducts", "Buyer_Id");
            CreateIndex("dbo.ShopProducts", "BuyerId");
            AddForeignKey("dbo.ShopProducts", "BuyerId", "dbo.Buyers", "Id", cascadeDelete: true);
        }
    }
}
