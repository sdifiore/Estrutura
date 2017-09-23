namespace Estrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveInsumoes : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Insumos");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Insumos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(maxLength: 6),
                        Descricao = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
