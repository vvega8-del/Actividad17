using Microsoft.EntityFrameworkCore;
using BlazorApp11.Models;

namespace BlazorApp11.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}