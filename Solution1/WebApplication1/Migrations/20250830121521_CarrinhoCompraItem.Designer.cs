
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using WebApplication1.Context;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211130130759_CarrinhoCompraItem")]
    partial class CarrinhoCompraItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, (int)1L, 1);

            modelBuilder.Entity("WebApplication1.Models.CarrinhoCompraItem", b =>
            {
                b.Property<int>("CarrinhoCompraItemId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarrinhoCompraItemId"), (int)1L, 1);

                b.Property<string>("CarrinhoCompraId")
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<int?>("BebidaId")
                    .HasColumnType("int");

                b.Property<int>("Quantidade")
                    .HasColumnType("int");

                b.HasKey("CarrinhoCompraItemId");

                b.HasIndex("BebidaId");

                b.ToTable("CarrinhoCompraItens");
            });

            modelBuilder.Entity("WebApplication1.Models.Categoria", b =>
            {
                b.Property<int>("CategoriaId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"), (int)1L, 1);

                b.Property<string>("CategoriaNome")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<string>("Descricao")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.HasKey("CategoriaId");

                b.ToTable("Categorias");
            });

            modelBuilder.Entity("WebApplication1.Models.Bebida", b =>
            {
                b.Property<int>("BebidaId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BebidaId"), (int)1L, 1);

                b.Property<int>("CategoriaId")
                    .HasColumnType("int");

                b.Property<string>("DescricaoCurta")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("DescricaoDetalhada")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<bool>("EmEstoque")
                    .HasColumnType("bit");

                b.Property<string>("ImagemThumbnailUrl")
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>("ImagemUrl")
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<bool>("IsLanchePreferido")
                    .HasColumnType("bit");

                b.Property<string>("Nome")
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnType("nvarchar(80)");

                b.Property<decimal>("Preco")
                    .HasColumnType("decimal(10,2)");

                b.HasKey("BebidaId");

                b.HasIndex("CategoriaId");

                b.ToTable("Bebidas");
            });

            modelBuilder.Entity("WebApplication1.Models.CarrinhoCompraItem", b =>
            {
                b.HasOne("WebApplication1.Models.Bebida", "Bebida")
                    .WithMany()
                    .HasForeignKey("BebidaId");

                b.Navigation("Bebida");
            });

            modelBuilder.Entity("WebApplication1.Models.Bebida", b =>
            {
                b.HasOne("WebApplication1.Models.Categoria", "Categoria")
                    .WithMany("Bebidas")
                    .HasForeignKey("CategoriaId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Categoria");
            });

            modelBuilder.Entity("WebApplication1.Models.Categoria", b =>
            {
                b.Navigation("Bebidas");
            });
#pragma warning restore 612, 618
        }
    }
}
