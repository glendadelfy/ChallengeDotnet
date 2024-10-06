using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOdontoprev.Models
{
    [Table("table_paciente")]
    public class Paciente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("name_paciente")]
        public string Nome { get; set; }
        [Column("idade_paciente")]
        [Required]
        public int Idade { get; set; }
        [Column("nascimento_paciente")]
        [Required]
        public DateTime Nascimento { get; set; }

    }
}
