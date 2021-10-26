using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario_Receita>()
                .HasOne(u => u.Usuario)
                .WithMany(ur => ur.Usuario_Receitas)
                .HasForeignKey(ui => ui.UsuarioId);

            modelBuilder.Entity<Usuario_Receita>()
               .HasOne(u => u.Receita)
               .WithMany(ur => ur.Usuario_Receitas)
               .HasForeignKey(ui => ui.ReceitaId);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Usuario_Receita> Usuarios_Receitas { get; set; }
    }
}
