using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoOdontoprev.Models
{
    [Table("table_dentista")]
    public class Dentista
    {
        [Key]
        public int Id { get; set; }
        [Column("nome_dentista")]
        public string Nome { get; set; } = string.Empty;
        [Column("email_dentista")]
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Column("password_dentista")]
        [Required]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        [Column("status_active_dentista")]
        public bool isActive { get; set; } = true;
        [Column("description_dentista")]
        public string Description { get; set; }
    }
}
