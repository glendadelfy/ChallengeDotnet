using Microsoft.EntityFrameworkCore;
using ProjetoOdontoprev.Models;

namespace ProjetoOdontoprev.Controllers
{
    public class PacienteContext : DbContext
    {
        public PacienteContext(DbContextOptions<PacienteContext> options) : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
    }
}
