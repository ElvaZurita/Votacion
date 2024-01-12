﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Votacion.Models;

#nullable disable

namespace Votacion.Migrations
{
    [DbContext(typeof(LibreriaContext))]
    partial class LibreriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Votacion.Models.Entidades.Candidato", b =>
                {
                    b.Property<int>("IdCandidato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCandidato"));

                    b.Property<decimal>("Activo")
                        .HasColumnType("decimal (18,2)");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdEleccion")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCandidato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RutaImagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCandidato");

                    b.HasIndex("IdEleccion");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Candidatos");
                });

            modelBuilder.Entity("Votacion.Models.Entidades.Eleccion", b =>
                {
                    b.Property<int>("IdEleccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEleccion"));

                    b.Property<decimal>("Activo")
                        .HasColumnType("decimal (18,2)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdEleccion");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Elecciones");
                });

            modelBuilder.Entity("Votacion.Models.Entidades.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<decimal>("Activo")
                        .HasColumnType("decimal (18,2)");

                    b.Property<string>("ApellidoUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaveUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentoIdentidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Votacion.Models.Entidades.Votaciones", b =>
                {
                    b.Property<int>("IdVotacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVotacion"));

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdCandidato")
                        .HasColumnType("int");

                    b.Property<int?>("IdEleccion")
                        .HasColumnType("int");

                    b.Property<int?>("IdVotante")
                        .HasColumnType("int");

                    b.HasKey("IdVotacion");

                    b.HasIndex("IdCandidato");

                    b.HasIndex("IdEleccion");

                    b.HasIndex("IdVotante");

                    b.ToTable("Votaciones");
                });

            modelBuilder.Entity("Votacion.Models.Entidades.Votante", b =>
                {
                    b.Property<int>("IdVotante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVotante"));

                    b.Property<decimal>("Activo")
                        .HasColumnType("decimal (18,2)");

                    b.Property<string>("ApellidoVotante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentoIdentidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmitioVotacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdEleccion")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarioRegistro")
                        .HasColumnType("int");

                    b.Property<string>("NombreVotante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdVotante");

                    b.HasIndex("IdEleccion");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Votantes");
                });

            modelBuilder.Entity("Votacion.Models.Entidades.Candidato", b =>
                {
                    b.HasOne("Votacion.Models.Entidades.Eleccion", "Eleccion")
                        .WithMany()
                        .HasForeignKey("IdEleccion");

                    b.HasOne("Votacion.Models.Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario");

                    b.Navigation("Eleccion");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Votacion.Models.Entidades.Eleccion", b =>
                {
                    b.HasOne("Votacion.Models.Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Votacion.Models.Entidades.Votaciones", b =>
                {
                    b.HasOne("Votacion.Models.Entidades.Candidato", "Candidato")
                        .WithMany()
                        .HasForeignKey("IdCandidato");

                    b.HasOne("Votacion.Models.Entidades.Eleccion", "Eleccion")
                        .WithMany()
                        .HasForeignKey("IdEleccion");

                    b.HasOne("Votacion.Models.Entidades.Votante", "Votante")
                        .WithMany()
                        .HasForeignKey("IdVotante");

                    b.Navigation("Candidato");

                    b.Navigation("Eleccion");

                    b.Navigation("Votante");
                });

            modelBuilder.Entity("Votacion.Models.Entidades.Votante", b =>
                {
                    b.HasOne("Votacion.Models.Entidades.Eleccion", "Eleccion")
                        .WithMany()
                        .HasForeignKey("IdEleccion");

                    b.HasOne("Votacion.Models.Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario");

                    b.Navigation("Eleccion");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
