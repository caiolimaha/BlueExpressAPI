using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueExpressAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueExpressAPI.Data
{
    public class BlueDbContext : DbContext
    {
        public BlueDbContext(DbContextOptions<BlueDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Mensagem>()
            .HasOne(mensagem => mensagem.Categoria)
            .WithMany(categoria => categoria.Mensagens)
            .HasForeignKey(mensagem => mensagem.CategoriaId);
        }

        public DbSet<Mensagem> Mensagens { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

    }
}