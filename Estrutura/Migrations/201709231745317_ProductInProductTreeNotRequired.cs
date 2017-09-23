namespace Estrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductInProductTreeNotRequired : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductTrees", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductTrees", new[] { "Product_Id" });
            AlterColumn("dbo.ProductTrees", "Product_Id", c => c.Int());
            CreateIndex("dbo.ProductTrees", "Product_Id");
            AddForeignKey("dbo.ProductTrees", "Product_Id", "dbo.Products", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTrees", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductTrees", new[] { "Product_Id" });
            AlterColumn("dbo.ProductTrees", "Product_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductTrees", "Product_Id");
            AddForeignKey("dbo.ProductTrees", "Product_Id", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
