namespace FNUC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategorieId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Categorie_CategorieId = c.Int(),
                    })
                .PrimaryKey(t => t.CategorieId)
                .ForeignKey("dbo.Categories", t => t.Categorie_CategorieId)
                .Index(t => t.Categorie_CategorieId);
            
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        ProduitsId = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 50),
                        Description = c.String(),
                        Prix = c.Single(nullable: false),
                        DateAjout = c.DateTime(),
                        CategorieId = c.Int(nullable: false),
                        TypeId = c.Int(nullable: false),
                        Quantite = c.Int(nullable: false),
                        Categorie_CategorieId = c.Int(),
                        type_CategorieId = c.Int(),
                    })
                .PrimaryKey(t => t.ProduitsId)
                .ForeignKey("dbo.Categories", t => t.Categorie_CategorieId)
                .ForeignKey("dbo.Categories", t => t.type_CategorieId)
                .Index(t => t.Categorie_CategorieId)
                .Index(t => t.type_CategorieId);
            
            CreateTable(
                "dbo.ShoppingBaskets",
                c => new
                    {
                        ShoppingBasketId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShoppingBasketId);
            
            CreateTable(
                "dbo.ShoppingProducts",
                c => new
                    {
                        ShoppingProductId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        PricePerUnity = c.Int(nullable: false),
                        ShoppingBasket_ShoppingBasketId = c.Int(),
                    })
                .PrimaryKey(t => t.ShoppingProductId)
                .ForeignKey("dbo.ShoppingBaskets", t => t.ShoppingBasket_ShoppingBasketId)
                .Index(t => t.ShoppingBasket_ShoppingBasketId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingProducts", "ShoppingBasket_ShoppingBasketId", "dbo.ShoppingBaskets");
            DropForeignKey("dbo.ProductDetails", "type_CategorieId", "dbo.Categories");
            DropForeignKey("dbo.ProductDetails", "Categorie_CategorieId", "dbo.Categories");
            DropForeignKey("dbo.Categories", "Categorie_CategorieId", "dbo.Categories");
            DropIndex("dbo.ShoppingProducts", new[] { "ShoppingBasket_ShoppingBasketId" });
            DropIndex("dbo.ProductDetails", new[] { "type_CategorieId" });
            DropIndex("dbo.ProductDetails", new[] { "Categorie_CategorieId" });
            DropIndex("dbo.Categories", new[] { "Categorie_CategorieId" });
            DropTable("dbo.ShoppingProducts");
            DropTable("dbo.ShoppingBaskets");
            DropTable("dbo.ProductDetails");
            DropTable("dbo.Categories");
        }
    }
}
