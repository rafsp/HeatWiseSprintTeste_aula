﻿// <auto-generated />
using HeatWise_Sprint_2.Net.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace HeatWise_Sprint_2.Net.Migrations
{
    [DbContext(typeof(HeatWiseDbContext))]
    partial class HeatWiseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HeatWise_Sprint_2.Net.Persistencia.Models.Analise", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<decimal>("IndiceEficiencia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("NumeroCliquesMouse")
                        .HasColumnType("int");

                    b.Property<int>("NumeroTeclasPressionadas")
                        .HasColumnType("int");

                    b.Property<string>("Relatorio")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<decimal>("SatisfacaoUsuario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("SiteId")
                        .HasColumnType("NUMBER(19)");

                    b.Property<int>("TarefasConcluidasPorTempo")
                        .HasColumnType("int");

                    b.Property<decimal>("TaxaErros")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TempoInatividade")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TempoMedioConclusaoTarefas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TempoMedioCorrecaoErros")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TempoTelaAtiva")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.ToTable("Analise");
                });

            modelBuilder.Entity("HeatWise_Sprint_2.Net.Persistencia.Models.Empresa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("NVARCHAR2(14)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<int>("FormaPagamento")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<long>("PlanoId")
                        .HasColumnType("NUMBER(19)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.HasKey("Id");

                    b.HasIndex("PlanoId");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("HeatWise_Sprint_2.Net.Persistencia.Models.Plano", b =>
                {
                    b.Property<long>("PlanoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PlanoId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("PlanoId");

                    b.ToTable("Plano");
                });

            modelBuilder.Entity("HeatWise_Sprint_2.Net.Persistencia.Models.Site", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<long>("EmpresaId")
                        .HasColumnType("NUMBER(19)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Site");
                });

            modelBuilder.Entity("HeatWise_Sprint_2.Net.Persistencia.Models.Analise", b =>
                {
                    b.HasOne("HeatWise_Sprint_2.Net.Persistencia.Models.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Site");
                });

            modelBuilder.Entity("HeatWise_Sprint_2.Net.Persistencia.Models.Empresa", b =>
                {
                    b.HasOne("HeatWise_Sprint_2.Net.Persistencia.Models.Plano", "Plano")
                        .WithMany()
                        .HasForeignKey("PlanoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plano");
                });

            modelBuilder.Entity("HeatWise_Sprint_2.Net.Persistencia.Models.Site", b =>
                {
                    b.HasOne("HeatWise_Sprint_2.Net.Persistencia.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });
#pragma warning restore 612, 618
        }
    }
}
