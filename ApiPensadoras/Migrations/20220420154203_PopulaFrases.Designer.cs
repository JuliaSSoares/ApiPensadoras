// <auto-generated />
using System;
using ApiPensadoras.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiPensadoras.Migrations
{
    [DbContext(typeof(ApiPensadorasDbContext))]
    [Migration("20220420154203_PopulaFrases")]
    partial class PopulaFrases
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiPensadoras.Models.Frase", b =>
                {
                    b.Property<int>("FraseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConteudoFrase")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("varchar(600)");

                    b.Property<int>("PensadoraId")
                        .HasColumnType("int");

                    b.HasKey("FraseId");

                    b.HasIndex("PensadoraId");

                    b.ToTable("Frases");
                });

            modelBuilder.Entity("ApiPensadoras.Models.Pensadora", b =>
                {
                    b.Property<int>("PensadoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataDeFalecimento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasMaxLength(600)
                        .HasColumnType("varchar(600)");

                    b.Property<string>("Nacionalidade")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Ocupacao")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("PensadoraId");

                    b.ToTable("Pensadoras");
                });

            modelBuilder.Entity("ApiPensadoras.Models.Frase", b =>
                {
                    b.HasOne("ApiPensadoras.Models.Pensadora", "Pensadora")
                        .WithMany("Frases")
                        .HasForeignKey("PensadoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pensadora");
                });

            modelBuilder.Entity("ApiPensadoras.Models.Pensadora", b =>
                {
                    b.Navigation("Frases");
                });
#pragma warning restore 612, 618
        }
    }
}
