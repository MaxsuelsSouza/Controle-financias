using ControleFinancia.Api.Data.Mappings;
using ControleFinancia.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleFinancia.Api.Data
{
    public class AplicationContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}