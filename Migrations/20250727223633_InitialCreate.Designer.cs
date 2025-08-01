﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RegistrosEntradaSaidaAPI.Database;

#nullable disable

namespace RegistrosEntradaSaidaAPI.Migrations
{
    [DbContext(typeof(DatabaseConnection))]
    [Migration("20250727223633_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RegistrosEntradaSaidaAPI.Database.Entities.Registros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DataEntrada")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DataSaida")
                        .HasColumnType("text");

                    b.Property<string>("HoraEntrada")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HoraSaida")
                        .HasColumnType("text");

                    b.Property<int>("MotoristaId")
                        .HasColumnType("integer");

                    b.Property<int>("VeiculoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Registros");
                });
#pragma warning restore 612, 618
        }
    }
}
