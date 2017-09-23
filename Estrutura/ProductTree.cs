using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estrutura
{
    public class ProductTree
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Codigo { get; set; }

        [StringLength(10)]
        public string ProdutoId { get; set; }

        [StringLength(2)]
        public string Unidade { get; set; }

        [StringLength(2)]
        public string Sequencia { get; set; }

        public float Custo { get; set; }

        public byte ClasseCusto{ get; set; }

    }
}
