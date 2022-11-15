using Microsoft.EntityFrameworkCore;
using PracticasEspecializacion.Models;

namespace PracticasEspecializacion.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Notas> notas { get; set; }
    
    }
}
