namespace Estrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedRequiredProductTree : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductTrees", "ProdutoId", c => c.String(maxLength: 10));
            AlterColumn("dbo.ProductTrees", "Unidade", c => c.String(maxLength: 2));
            AlterColumn("dbo.ProductTrees", "Sequencia", c => c.String(maxLength: 1));
            AlterColumn("dbo.ProductTrees", "UnConsComp", c => c.String(maxLength: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductTrees", "UnConsComp", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.ProductTrees", "Sequencia", c => c.String(nullable: false, maxLength: 1));
            AlterColumn("dbo.ProductTrees", "Unidade", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.ProductTrees", "ProdutoId", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
