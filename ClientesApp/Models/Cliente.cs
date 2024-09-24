using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientesApp.Models
{
    public class Cliente
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Column("data_nascimento")]
        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "Data inválida")]
        public DateTime DataNascimento { get; set; }

        [Column("ativo")]
        public bool Ativo { get; set; }
    }
}
