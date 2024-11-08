using Microsoft.EntityFrameworkCore;
using ProjetoOdontoprev.Models;
using System.Collections.Generic;

namespace ProjetoOdontoprev.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
