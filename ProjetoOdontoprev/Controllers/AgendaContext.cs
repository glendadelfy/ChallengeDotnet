using Microsoft.EntityFrameworkCore;
using ProjetoOdontoprev.Models;

namespace ProjetoOdontoprev.Controllers
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

        public DbSet<Agendamento> agendamentos { get; set; }
    }
}
