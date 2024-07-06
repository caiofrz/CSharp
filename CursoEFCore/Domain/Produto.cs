using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CursoEFCore.ValueObjects;

namespace CursoEFCore.Domain
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string CodigoBarras { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public TipoProdutoEnum TipoProduto { get; set; }
        public bool Ativos { get; set; }
    }
}