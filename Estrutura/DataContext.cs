using System.Data.Entity;

namespace Estrutura
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=SqlServer")
        {
        }

        public DbSet<LogData> LogData { get; set; }
        public DbSet<Product> Produtos { get; set; }
        public DbSet<ProductTree> ProductsTree { get; set; }
    }
}
