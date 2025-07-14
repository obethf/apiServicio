using Microsoft.EntityFrameworkCore;
using apiServicio.Models;

namespace apiServicio.Data
{
    public class ProgramacionWebIIContext : DbContext
    {
        public ProgramacionWebIIContext(DbContextOptions<ProgramacionWebIIContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}

