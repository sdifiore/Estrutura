namespace Estrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProdutoToProductTree : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductTrees", "ProdutoId", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.ProductTrees", "Produto_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductTrees", "Produto_Id");
            AddForeignKey("dbo.ProductTrees", "Produto_Id", "dbo.Produtoes", "Id", cascadeDelete: true);
            DropColumn("dbo.ProductTrees", "Component");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductTrees", "Component", c => c.String(nullable: false, maxLength: 10));
            DropForeignKey("dbo.ProductTrees", "Produto_Id", "dbo.Produtoes");
            DropIndex("dbo.ProductTrees", new[] { "Produto_Id" });
            DropColumn("dbo.ProductTrees", "Produto_Id");
            DropColumn("dbo.ProductTrees", "ProdutoId");
        }
    }
}
