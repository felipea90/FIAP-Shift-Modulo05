using Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Fiap.Web.AspNet.Data
{
    public class DataContext : DbContext
    {
        //public DataContext(DbContextOptions options) : base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("databaseUrl"));
                optionsBuilder.EnableSensitiveDataLogging();
                optionsBuilder.LogTo(Console.Write);
            }
        }

        public DbSet<RepresentanteModel> Representantes { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }

    }
}
