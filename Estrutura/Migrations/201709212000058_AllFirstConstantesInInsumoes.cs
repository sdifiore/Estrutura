namespace Estrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllFirstConstantesInInsumoes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Insumoes", "Unidade", c => c.String(maxLength: 10));
            AddColumn("dbo.Insumoes", "Tipo", c => c.String(maxLength: 1));
            AddColumn("dbo.Insumoes", "ClasseCusto", c => c.String(maxLength: 2));
            AddColumn("dbo.Insumoes", "Categoria", c => c.String(maxLength: 2));
            AddColumn("dbo.Insumoes", "Familia", c => c.String(maxLength: 3));
            AddColumn("dbo.Insumoes", "Linha", c => c.String(maxLength: 4));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Insumoes", "Linha");
            DropColumn("dbo.Insumoes", "Familia");
            DropColumn("dbo.Insumoes", "Categoria");
            DropColumn("dbo.Insumoes", "ClasseCusto");
            DropColumn("dbo.Insumoes", "Tipo");
            DropColumn("dbo.Insumoes", "Unidade");
        }
    }
}
