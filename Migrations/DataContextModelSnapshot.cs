﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Siemens_WEBAPI.Data;

namespace Siemens_WEBAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Siemens_WEBAPI.Models.Cidade", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cidade");

                    b.HasData(
                        new
                        {
                            id = 1,
                            estado = "PR",
                            nome = "Curitiba"
                        },
                        new
                        {
                            id = 2,
                            estado = "SP",
                            nome = "Sao Paulo"
                        },
                        new
                        {
                            id = 3,
                            estado = "RJ",
                            nome = "Rio de Janeiro"
                        },
                        new
                        {
                            id = 4,
                            estado = "MG",
                            nome = "Belo Horizonte"
                        },
                        new
                        {
                            id = 5,
                            estado = "RS",
                            nome = "Porto Alegre"
                        });
                });

            modelBuilder.Entity("Siemens_WEBAPI.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("dataNasc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CidadeId = 1,
                            dataNasc = "29-12-1994",
                            idade = 28,
                            nome = "Paulo",
                            sexo = "Masculino"
                        },
                        new
                        {
                            id = 2,
                            CidadeId = 1,
                            dataNasc = "21-02-1990",
                            idade = 32,
                            nome = "Henrique",
                            sexo = "Masculino"
                        },
                        new
                        {
                            id = 3,
                            CidadeId = 2,
                            dataNasc = "12-04-1980",
                            idade = 42,
                            nome = "Guilherme",
                            sexo = "Masculino"
                        },
                        new
                        {
                            id = 4,
                            CidadeId = 3,
                            dataNasc = "10-07-1996",
                            idade = 26,
                            nome = "Paula",
                            sexo = "Feminino"
                        },
                        new
                        {
                            id = 5,
                            CidadeId = 4,
                            dataNasc = "09-10-1992",
                            idade = 30,
                            nome = "Mariana",
                            sexo = "Feminino"
                        },
                        new
                        {
                            id = 6,
                            CidadeId = 5,
                            dataNasc = "15-03-1989",
                            idade = 33,
                            nome = "Francisca",
                            sexo = "Feminino"
                        });
                });

            modelBuilder.Entity("Siemens_WEBAPI.Models.Cliente", b =>
                {
                    b.HasOne("Siemens_WEBAPI.Models.Cidade", "Cidade")
                        .WithMany("Clientes")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}