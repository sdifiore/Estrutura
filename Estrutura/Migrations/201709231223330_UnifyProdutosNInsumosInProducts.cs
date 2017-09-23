namespace Estrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UnifyProdutosNInsumosInProducts : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Insumoes", newName: "Products");
            DropForeignKey("dbo.ProductTrees", "Produto_Id", "dbo.Produtoes");
            DropIndex("dbo.ProductTrees", new[] { "Produto_Id" });
            AddColumn("dbo.ProductTrees", "Product_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductTrees", "Product_Id");
            AddForeignKey("dbo.ProductTrees", "Product_Id", "dbo.Products", "Id", cascadeDelete: true);
            DropColumn("dbo.ProductTrees", "Produto_Id");
            DropTable("dbo.Produtoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(maxLength: 10),
                        Descricao = c.String(maxLength: 100),
                        Unidade = c.String(maxLength: 10),
                        Tipo = c.String(maxLength: 1),
                        ClasseCusto = c.String(maxLength: 2),
                        Categoria = c.String(maxLength: 2),
                        Familia = c.String(maxLength: 3),
                        Linha = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ProductTrees", "Produto_Id", c => c.Int(nullable: false));
            DropForeignKey("dbo.ProductTrees", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductTrees", new[] { "Product_Id" });
            DropColumn("dbo.ProductTrees", "Product_Id");
            CreateIndex("dbo.ProductTrees", "Produto_Id");
            AddForeignKey("dbo.ProductTrees", "Produto_Id", "dbo.Produtoes", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.Products", newName: "Insumoes");
        }
    }
}
