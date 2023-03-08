﻿// <auto-generated />
using System;
using GeneracionOrdenDespacho.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeneracionOrdenDespacho.Migrations
{
    [DbContext(typeof(PersistenciaDbContext))]
    [Migration("20230308002534_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.1.23111.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeneracionOrdenDespacho.Persistencia.Modelos.DespachoUltimaMilla", b =>
                {
                    b.Property<Guid>("DespachoUltimaMillaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("IdentificadorDelivery")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Items")
                        .IsRequired()
                        .HasMaxLength(40000)
                        .HasColumnType("longtext");

                    b.Property<string>("NombreBodega")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<Guid>("OrdenId")
                        .HasColumnType("char(36)");

                    b.HasKey("DespachoUltimaMillaId");

                    b.HasIndex("OrdenId");

                    b.ToTable("DespachosUltimaMilla");
                });

            modelBuilder.Entity("GeneracionOrdenDespacho.Persistencia.Modelos.Orden", b =>
                {
                    b.Property<Guid>("OrdenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("DireccionUsuario")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("varchar(1024)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("OrdenId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("GeneracionOrdenDespacho.Persistencia.Modelos.DespachoUltimaMilla", b =>
                {
                    b.HasOne("GeneracionOrdenDespacho.Persistencia.Modelos.Orden", "Orden")
                        .WithMany("Despachos")
                        .HasForeignKey("OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orden");
                });

            modelBuilder.Entity("GeneracionOrdenDespacho.Persistencia.Modelos.Orden", b =>
                {
                    b.Navigation("Despachos");
                });
#pragma warning restore 612, 618
        }
    }
}
