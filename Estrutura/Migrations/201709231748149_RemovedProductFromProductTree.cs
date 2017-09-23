namespace Estrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedProductFromProductTree : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductTrees", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductTrees", new[] { "Product_Id" });
            DropColumn("dbo.ProductTrees", "Product_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductTrees", "Product_Id", c => c.Int());
            CreateIndex("dbo.ProductTrees", "Product_Id");
            AddForeignKey("dbo.ProductTrees", "Product_Id", "dbo.Products", "Id");
        }
    }
}
