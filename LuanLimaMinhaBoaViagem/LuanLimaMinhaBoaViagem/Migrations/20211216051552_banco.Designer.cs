﻿// <auto-generated />
using System;
using LuanLimaMinhaBoaViagem.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LuanLimaMinhaBoaViagem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211216051552_banco")]
    partial class banco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LuanLimaMinhaBoaViagem.Models.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("LuanLimaMinhaBoaViagem.Models.Destino", b =>
                {
                    b.Property<int>("DestinoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Desembarque")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Embarque")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hotel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Parcelas")
                        .HasColumnType("int");

                    b.Property<int>("Pessoas")
                        .HasColumnType("int");

                    b.Property<string>("UF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("DestinoId");

                    b.ToTable("Destinos");
                });

            modelBuilder.Entity("LuanLimaMinhaBoaViagem.Models.Promocao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<int>("Cupom")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Promocaos");
                });

            modelBuilder.Entity("LuanLimaMinhaBoaViagem.Models.PromocaoDestino", b =>
                {
                    b.Property<int>("PromocaoId")
                        .HasColumnType("int");

                    b.Property<int>("DestinoId")
                        .HasColumnType("int");

                    b.HasKey("PromocaoId", "DestinoId");

                    b.HasIndex("DestinoId");

                    b.ToTable("PromocaoDestino");
                });

            modelBuilder.Entity("LuanLimaMinhaBoaViagem.Models.PromocaoDestino", b =>
                {
                    b.HasOne("LuanLimaMinhaBoaViagem.Models.Destino", "Destino")
                        .WithMany("Promocaos")
                        .HasForeignKey("DestinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LuanLimaMinhaBoaViagem.Models.Promocao", "Promocao")
                        .WithMany("Destinos")
                        .HasForeignKey("PromocaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destino");

                    b.Navigation("Promocao");
                });

            modelBuilder.Entity("LuanLimaMinhaBoaViagem.Models.Destino", b =>
                {
                    b.Navigation("Promocaos");
                });

            modelBuilder.Entity("LuanLimaMinhaBoaViagem.Models.Promocao", b =>
                {
                    b.Navigation("Destinos");
                });
#pragma warning restore 612, 618
        }
    }
}
