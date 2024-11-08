﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoOdontoprev.DTOs
{
    public class UsuarioModelRegister
    {
        public string Name { get; set; } = "Sem Nome";
        
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        
    }
}
