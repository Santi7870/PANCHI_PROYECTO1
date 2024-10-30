﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PANCHI_PROYECTO1.Data;

#nullable disable

namespace PANCHI_PROYECTO1.Migrations
{
    [DbContext(typeof(PANCHI_PROYECTO1Context))]
    [Migration("20241030140135_SantiagoPanchi")]
    partial class SantiagoPanchi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PANCHI_PROYECTO1.Models.Celular", b =>
                {
                    b.Property<int>("IdCelular")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCelular"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<int>("SPanchiId")
                        .HasColumnType("int");

                    b.HasKey("IdCelular");

                    b.HasIndex("SPanchiId")
                        .IsUnique();

                    b.ToTable("Celular");
                });

            modelBuilder.Entity("PANCHI_PROYECTO1.Models.SPanchi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Extranjero")
                        .HasColumnType("bit");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("SPanchi");
                });

            modelBuilder.Entity("PANCHI_PROYECTO1.Models.Celular", b =>
                {
                    b.HasOne("PANCHI_PROYECTO1.Models.SPanchi", "sPanchi")
                        .WithOne("celular")
                        .HasForeignKey("PANCHI_PROYECTO1.Models.Celular", "SPanchiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sPanchi");
                });

            modelBuilder.Entity("PANCHI_PROYECTO1.Models.SPanchi", b =>
                {
                    b.Navigation("celular")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
