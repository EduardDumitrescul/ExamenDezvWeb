﻿// <auto-generated />
using System;
using Examen.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen.Data.Migrations
{
    [DbContext(typeof(ExamenContext))]
    [Migration("20240125124611_Ev, PArt, PArt")]
    partial class EvPArtPArt
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Examen.Data.Models.Eveniment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Evenimente");
                });

            modelBuilder.Entity("Examen.Data.Models.Participant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Participanti");
                });

            modelBuilder.Entity("Examen.Data.Models.Participare", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EvenimentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdEveniment")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdParticipant")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ParticipantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EvenimentId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("Participari");
                });

            modelBuilder.Entity("Examen.Data.Models.Participare", b =>
                {
                    b.HasOne("Examen.Data.Models.Eveniment", null)
                        .WithMany("Participari")
                        .HasForeignKey("EvenimentId");

                    b.HasOne("Examen.Data.Models.Participant", null)
                        .WithMany("Participari")
                        .HasForeignKey("ParticipantId");
                });

            modelBuilder.Entity("Examen.Data.Models.Eveniment", b =>
                {
                    b.Navigation("Participari");
                });

            modelBuilder.Entity("Examen.Data.Models.Participant", b =>
                {
                    b.Navigation("Participari");
                });
#pragma warning restore 612, 618
        }
    }
}
