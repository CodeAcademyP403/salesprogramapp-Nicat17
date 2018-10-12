namespace MarketProgram.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDataType2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ShopProducts", "Buyer_Id", "dbo.Buyers");
            DropIndex("dbo.ShopProducts", new[] { "Buyer_Id" });
            AlterColumn("dbo.ShopProducts", "BuyerId", c => c.String(nullable: false));
            AlterColumn("dbo.ShopProducts", "WeightId", c => c.String(nullable: false));
            AlterColumn("dbo.ShopProducts", "Buyer_Id", c => c.Int());
            AlterColumn("dbo.TopSellingStations", "WeightId", c => c.String(nullable: false));
            CreateIndex("dbo.ShopProducts", "Buyer_Id");
            AddForeignKey("dbo.ShopProducts", "Buyer_Id", "dbo.Buyers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShopProducts", "Buyer_Id", "dbo.Buyers");
            DropIndex("dbo.ShopProducts", new[] { "Buyer_Id" });
            AlterColumn("dbo.TopSellingStations", "WeightId", c => c.String());
            AlterColumn("dbo.ShopProducts", "Buyer_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.ShopProducts", "WeightId", c => c.String());
            AlterColumn("dbo.ShopProducts", "BuyerId", c => c.String());
            CreateIndex("dbo.ShopProducts", "Buyer_Id");
            AddForeignKey("dbo.ShopProducts", "Buyer_Id", "dbo.Buyers", "Id", cascadeDelete: true);
        }
    }
}
