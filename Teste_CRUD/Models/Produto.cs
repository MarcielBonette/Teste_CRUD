using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste_CRUD.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name ="Código")]
        public int Id { get; set; }


        [Column("Nome")]
        [Display(Name="Código")]
        public string Nome { get; set; }
    }
}
