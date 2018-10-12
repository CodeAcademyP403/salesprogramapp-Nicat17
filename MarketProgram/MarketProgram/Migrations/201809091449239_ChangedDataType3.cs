namespace MarketProgram.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDataType3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ShopProducts", "Buyer_Id", "dbo.Buyers");
            DropIndex("dbo.ShopProducts", new[] { "Buyer_Id" });
            DropColumn("dbo.ShopProducts", "BuyerId");
            RenameColumn(table: "dbo.ShopProducts", name: "Buyer_Id", newName: "BuyerId");
            AlterColumn("dbo.ShopProducts", "BuyerId", c => c.Int(nullable: false));
            AlterColumn("dbo.ShopProducts", "WeightId", c => c.Int(nullable: false));
            AlterColumn("dbo.ShopProducts", "BuyerId", c => c.Int(nullable: false));
            AlterColumn("dbo.TopSellingStations", "WeightId", c => c.Int(nullable: false));
            CreateIndex("dbo.ShopProducts", "BuyerId");
            AddForeignKey("dbo.ShopProducts", "BuyerId", "dbo.Buyers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShopProducts", "BuyerId", "dbo.Buyers");
            DropIndex("dbo.ShopProducts", new[] { "BuyerId" });
            AlterColumn("dbo.TopSellingStations", "WeightId", c => c.String(nullable: false));
            AlterColumn("dbo.ShopProducts", "BuyerId", c => c.Int());
            AlterColumn("dbo.ShopProducts", "WeightId", c => c.String(nullable: false));
            AlterColumn("dbo.ShopProducts", "BuyerId", c => c.String(nullable: false));
            RenameColumn(table: "dbo.ShopProducts", name: "BuyerId", newName: "Buyer_Id");
            AddColumn("dbo.ShopProducts", "BuyerId", c => c.String(nullable: false));
            CreateIndex("dbo.ShopProducts", "Buyer_Id");
            AddForeignKey("dbo.ShopProducts", "Buyer_Id", "dbo.Buyers", "Id");
        }
    }
}
