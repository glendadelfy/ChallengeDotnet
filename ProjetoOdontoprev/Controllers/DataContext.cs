using Microsoft.EntityFrameworkCore;
using ProjetoOdontoprev.Models;
using System.Collections.Generic;

namespace ProjetoOdontoprev.Controllers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Dentista> Dentistas { get; set; }
    }
}
