using Banco.CLasses.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.CLasses.Contextos
{
    internal class ContaContext : DbContext
    {
        //Propriedades
        public DbSet<Conta> contas {  get; set; }

        //Metodos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string config = @"Server=ECFP507D1319377\SQLEXPRESS";
            optionsBuilder.UseSqlServer();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conta>(entidade =>
            {
                entidade.HasKey(e => e.Id);
                entidade.Property(e => e.NumeroDaConta);
                entidade.Property(e => e.TitularDaConta);
                entidade.Property(e => e.SaldoDaConta);
                
            });
        }
    }
}
