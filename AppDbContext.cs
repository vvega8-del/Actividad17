using Microsoft.EntityFrameworkCore;
using MiProyectoBlazor.Models;

namespace MiProyectoBlazor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}