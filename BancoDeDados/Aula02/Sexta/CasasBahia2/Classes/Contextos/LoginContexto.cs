using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasasBahia2.Classes.Contextos
{
    internal class LoginContexto : DbContext
    {
        //Propriedade
        public DbSet<Entidades.Login> Logins { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string caminho = @"Server=ECFP507D1319377\SQLEXPRESS02; Database=CasasBahia2; Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(caminho);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.Login>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.Usuario);
                entidade.Property(e => e.Senha);
                entidade.Property(e => e.Regra);
            });
        }
    }
}
