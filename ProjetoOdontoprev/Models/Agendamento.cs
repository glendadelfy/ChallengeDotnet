using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOdontoprev.Models
{
    [Table("table_agendamento")]

    public class Agendamento
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("data_agenda")]
        public DateTime DataAgendamento { get; set; }
        [Column("descricao_agenda")]
        [Required]
        public string Descricao { get; set; }
    }
}
