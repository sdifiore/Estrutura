namespace Estrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInsumosTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Insumoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(maxLength: 6),
                        Descricao = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Insumoes");
        }
    }
}
