using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOdontoprev.Models
{
    [Table("table_agendamento")]

    public class Agendamento
    {
        [Key]
        public int Id { get; set; }
        [Column("data_agenda")]
        [Required]
        public DateTime DataAgendamento { get; set; }
        [Column("descricao_agenda")]
        public string Descricao { get; set; }
    }
}
