using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoOdontoprev.Models
{
    [Table("table_usuario_use")]
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; }
        [Column("name_user")]
        public required string Name { get; set; } = "Sem nome";
        [Column("cpf_user")]
        [Required]
        [MaxLength(11)]
        public int Cpf { get; set; }
        [Column("email_user")]
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Column("password_user")]
        [Required]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        [Column("status_active_user")]
        public bool isActive { get; set; } = true;
        [Column("role_user")]
        public string Role { get; set; } = "User";
        [Column("avatar_user")]
        public string Avatar { get; set; } = "https://images.hdqwalls.com/download/cute-pikachu-6o-3840x2160.jpg";
    }
}
