using System.ComponentModel.DataAnnotations;

namespace Estrutura
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Codigo { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        [StringLength(10)]
        public string Unidade { get; set; }

        [StringLength(1)]
        public string Tipo { get; set; }

        [StringLength(2)]
        public string ClasseCusto { get; set; }

        [StringLength(2)]
        public string Categoria { get; set; }

        [StringLength(3)]
        public string Familia { get; set; }

        [StringLength(4)]
        public string Linha { get; set; }
    }
}
