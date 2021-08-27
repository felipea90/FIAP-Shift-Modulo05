using Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Fiap.Web.AspNet.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DataContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();

                optionsBuilder.UseSqlServer(config.GetConnectionString("databaseUrl"));
                optionsBuilder.EnableSensitiveDataLogging();
                optionsBuilder.LogTo(Console.Write);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PaisModel>()
            //    .ToTable("Pais");

            modelBuilder.Entity<PaisModel>()
                .HasKey(p => p.PaisId);

            modelBuilder.Entity<PaisModel>()
                .Property(p => p.PaisId)
                //.HasColumnName("CD_Pais")
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<PaisModel>()
                .Property(p => p.NomePais)
                //.HasColumnName("NM_Pais")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<PaisModel>()
                .Property(p => p.Continente)
                .HasMaxLength(50);

            modelBuilder.Entity<PaisModel>()
                .HasIndex(p => p.NomePais);

            modelBuilder.Entity<CidadeModel>().HasData(
            new CidadeModel()
            {
                CidadeId = 1,
                NomeCidade = "São Paulo",
                Estado = "SP",
                QuantidadeHabitantes = 11
            },
            new CidadeModel()
            {
                CidadeId = 2,
                NomeCidade = "Rio de Janeiro",
                Estado = "RJ",
                QuantidadeHabitantes = 5
            }
            );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<RepresentanteModel> Representantes { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<CidadeModel> Cidades { get; set; }
        public DbSet<PaisModel> Pais { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<LojaModel> Lojas { get; set; }
        public DbSet<ProdutoLojaModel> ProdutoLoja { get; set; }

    }
}
