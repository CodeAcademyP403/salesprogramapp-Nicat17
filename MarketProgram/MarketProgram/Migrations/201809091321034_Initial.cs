namespace MarketProgram.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buyers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 255),
                        ConfirmPassword = c.String(nullable: false, maxLength: 255),
                        Percent = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShopProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BuyingTime = c.DateTime(nullable: false),
                        BuyerId = c.Int(nullable: false),
                        Category = c.String(nullable: false, maxLength: 100),
                        Name = c.String(nullable: false, maxLength: 100),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Currency = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        WeightId = c.Int(nullable: false),
                        Usage = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buyers", t => t.BuyerId, cascadeDelete: true)
                .Index(t => t.BuyerId);
            
            CreateTable(
                "dbo.TopSellingStations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SellingTime = c.DateTime(nullable: false),
                        Category = c.String(nullable: false, maxLength: 100),
                        Name = c.String(nullable: false, maxLength: 100),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Currency = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        WeightId = c.Int(nullable: false),
                        Usage = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShopProducts", "BuyerId", "dbo.Buyers");
            DropIndex("dbo.ShopProducts", new[] { "BuyerId" });
            DropTable("dbo.TopSellingStations");
            DropTable("dbo.ShopProducts");
            DropTable("dbo.Buyers");
        }
    }
}
