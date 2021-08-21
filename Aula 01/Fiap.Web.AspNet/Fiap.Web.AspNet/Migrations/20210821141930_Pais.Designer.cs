﻿// <auto-generated />
using System;
using Fiap.Web.AspNet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fiap.Web.AspNet.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210821141930_Pais")]
    partial class Pais
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fiap.Web.AspNet.Models.CidadeModel", b =>
                {
                    b.Property<int>("CidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("NomeCidade")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("QuantidadeHabitantes")
                        .HasColumnType("int");

                    b.HasKey("CidadeId");

                    b.HasIndex("NomeCidade", "Estado");

                    b.ToTable("Cidades");

                    b.HasData(
                        new
                        {
                            CidadeId = 1,
                            Estado = "SP",
                            NomeCidade = "São Paulo",
                            QuantidadeHabitantes = 11
                        },
                        new
                        {
                            CidadeId = 2,
                            Estado = "RJ",
                            NomeCidade = "Rio de Janeiro",
                            QuantidadeHabitantes = 5
                        });
                });

            modelBuilder.Entity("Fiap.Web.AspNet.Models.ClienteModel", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RepresentanteId")
                        .HasColumnType("int");

                    b.HasKey("ClienteId");

                    b.HasIndex("RepresentanteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Fiap.Web.AspNet.Models.PaisModel", b =>
                {
                    b.Property<int>("PaisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Continente")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NomePais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PaisId");

                    b.HasIndex("NomePais");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("Fiap.Web.AspNet.Models.RepresentanteModel", b =>
                {
                    b.Property<int>("RepresentanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeRepresentante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RepresentanteId");

                    b.ToTable("Representantes");
                });

            modelBuilder.Entity("Fiap.Web.AspNet.Models.ClienteModel", b =>
                {
                    b.HasOne("Fiap.Web.AspNet.Models.RepresentanteModel", "Representante")
                        .WithMany()
                        .HasForeignKey("RepresentanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Representante");
                });
#pragma warning restore 612, 618
        }
    }
}