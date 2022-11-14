﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using squadAPI2.Database;

#nullable disable

namespace squadAPI2.Migrations
{
    [DbContext(typeof(ConfigDbContext))]
    partial class ConfigDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("squadAPI2.Model.CadastroEmpresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cidade");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cnpj");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("complemento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("estado");

                    b.Property<string>("NomeRepresentante")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome_representante");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("numero");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("razao_social");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("rua");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("cadastro_empresa", (string)null);
                });

            modelBuilder.Entity("squadAPI2.Model.CadastroEscola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cidade");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cnpj");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("complemento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("estado");

                    b.Property<string>("NomeRepresentante")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome_representante");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("numero");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("razao_social");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("rua");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("cadastro_escola", (string)null);
                });

            modelBuilder.Entity("squadAPI2.Model.DemandaEscola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("DataDemanda")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_demanda");

                    b.Property<string>("Demanda")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("demanda");

                    b.Property<string>("DescricaoDemanda")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("descricao_demanda");

                    b.HasKey("Id");

                    b.ToTable("demanda_escola", (string)null);
                });

            modelBuilder.Entity("squadAPI2.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("razao_social");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("senha");

                    b.HasKey("Id");

                    b.ToTable("usuario", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
