namespace Estrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductTreeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductTrees",
                c => new
                    {
                        Codigo = c.String(nullable: false, maxLength: 10),
                        Component = c.String(nullable: false, maxLength: 10),
                        Unidade = c.String(nullable: false, maxLength: 2),
                        Sequencia = c.String(nullable: false, maxLength: 1),
                        UnConsComp = c.String(nullable: false, maxLength: 2),
                        Custo = c.Single(nullable: false),
                        ClasseCusto = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductTrees");
        }
    }
}
