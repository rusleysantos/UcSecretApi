﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Models;

namespace Repository.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210623013927_Adiciona_Valores")]
    partial class Adiciona_Valores
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Repository.Models.Comentario", b =>
                {
                    b.Property<int>("idComentario")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_COMENTARIO")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataHoraComentario")
                        .HasColumnName("DATA_HORA_COMENTARIO")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnName("DESCRICAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PostagemidPostagem")
                        .HasColumnType("int");

                    b.Property<int>("idPostagem")
                        .HasColumnName("ID_POSTAGEM_COMENTARIO")
                        .HasColumnType("int");

                    b.HasKey("idComentario");

                    b.HasIndex("PostagemidPostagem");

                    b.ToTable("COMENTARIOS");
                });

            modelBuilder.Entity("Repository.Models.Controle", b =>
                {
                    b.Property<int>("idControle")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_CONTROLE")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aprovacao")
                        .HasColumnName("APROVACAO")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .HasColumnName("DESCRICAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Regritacao")
                        .HasColumnName("RESTRICAO")
                        .HasColumnType("bit");

                    b.HasKey("idControle");

                    b.ToTable("CONTROLES");
                });

            modelBuilder.Entity("Repository.Models.CustomizacaoPostagem", b =>
                {
                    b.Property<int>("idCustomizacaoPostagem")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_CUSTOMIZACAO_POSTAGEM")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cor")
                        .HasColumnName("COR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FotoFundoPostagemidFotoFundoPostagem")
                        .HasColumnType("int");

                    b.Property<int?>("idFotoFundoPostagem")
                        .HasColumnName("ID_CUSTOMIZACAO_POSTAGEM_")
                        .HasColumnType("int");

                    b.HasKey("idCustomizacaoPostagem");

                    b.HasIndex("FotoFundoPostagemidFotoFundoPostagem");

                    b.ToTable("CUSTOMIZACOES_POSTAGEM");
                });

            modelBuilder.Entity("Repository.Models.FotoFundoPostagem", b =>
                {
                    b.Property<int>("idFotoFundoPostagem")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_FOTO_FUNDO_POSTAGEM")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("ArrayByte")
                        .HasColumnName("ARRAY_BYTE")
                        .HasColumnType("tinyint");

                    b.Property<string>("Titulo")
                        .HasColumnName("TITULO")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idFotoFundoPostagem");

                    b.ToTable("FOTOS_FUNDO_POSTAGEM");
                });

            modelBuilder.Entity("Repository.Models.FotoUsuario", b =>
                {
                    b.Property<int>("idFotoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_FOTO_USUARIO")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("ArrayByte")
                        .HasColumnName("ARRAY_BYTE")
                        .HasColumnType("tinyint");

                    b.Property<string>("Descricao")
                        .HasColumnName("DESCRICAO")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idFotoUsuario");

                    b.ToTable("FOTOS_USUARIOS");
                });

            modelBuilder.Entity("Repository.Models.Postagem", b =>
                {
                    b.Property<int>("idPostagem")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_POSTAGEM")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativa")
                        .HasColumnName("ATIVA")
                        .HasColumnType("bit");

                    b.Property<int?>("CustomizacaoPostagemidCustomizacaoPostagem")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHoraPostagem")
                        .HasColumnName("DATA_HORA_POSTAGEM")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnName("DESCRICAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioidUsuario")
                        .HasColumnType("int");

                    b.Property<int?>("idCustomizacaoPostagem")
                        .HasColumnName("ID_CUSTOMIZACAO_POSTAGEM")
                        .HasColumnType("int");

                    b.Property<int>("idUsuario")
                        .HasColumnName("ID_USUARIO_POSTAGEM")
                        .HasColumnType("int");

                    b.HasKey("idPostagem");

                    b.HasIndex("CustomizacaoPostagemidCustomizacaoPostagem");

                    b.HasIndex("UsuarioidUsuario");

                    b.ToTable("POSTAGENS");
                });

            modelBuilder.Entity("Repository.Models.PostagemControle", b =>
                {
                    b.Property<int>("idPostagemControle")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_POSTAGEM_CONTROLE")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ControleidControle")
                        .HasColumnType("int");

                    b.Property<int?>("PostagemidPostagem")
                        .HasColumnType("int");

                    b.Property<int>("idControle")
                        .HasColumnName("ID_CONTROLE_POSTAGEM_CONTROLE")
                        .HasColumnType("int");

                    b.Property<int>("idPostagem")
                        .HasColumnName("ID_POSTAGEM_POSTAGEM_CONTROLE")
                        .HasColumnType("int");

                    b.HasKey("idPostagemControle");

                    b.HasIndex("ControleidControle");

                    b.HasIndex("PostagemidPostagem");

                    b.ToTable("POSTAGENS_CONTROLES");
                });

            modelBuilder.Entity("Repository.Models.Reacao", b =>
                {
                    b.Property<int>("idReacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_REACAO")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnName("DESCRICAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioidUsuario")
                        .HasColumnType("int");

                    b.Property<int>("idUsuario")
                        .HasColumnName("USUARIO_REACAO")
                        .HasColumnType("int");

                    b.HasKey("idReacao");

                    b.HasIndex("UsuarioidUsuario");

                    b.ToTable("REACOES");
                });

            modelBuilder.Entity("Repository.Models.ReacaoPostagem", b =>
                {
                    b.Property<int>("idReacaoPostagem")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_REACAO_POSTAGEM")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PostagemidPostagem")
                        .HasColumnType("int");

                    b.Property<int?>("ReacaoidReacao")
                        .HasColumnType("int");

                    b.Property<int>("idPostagem")
                        .HasColumnName("ID_REACAO_POSTAGEM_POSTAGEM")
                        .HasColumnType("int");

                    b.Property<int>("idReacao")
                        .HasColumnName("ID_REACAO_POSTAGEM_REACAO")
                        .HasColumnType("int");

                    b.HasKey("idReacaoPostagem");

                    b.HasIndex("PostagemidPostagem");

                    b.HasIndex("ReacaoidReacao");

                    b.ToTable("REACOES_POSTAGENS");
                });

            modelBuilder.Entity("Repository.Models.Tag", b =>
                {
                    b.Property<int>("idTag")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_TAG")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnName("DESCRICAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnName("NOME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTag");

                    b.ToTable("TAGS");
                });

            modelBuilder.Entity("Repository.Models.TagPostagem", b =>
                {
                    b.Property<int>("idTagPostagem")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_TAG_POSTAGEM")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PostagemidPostagem")
                        .HasColumnType("int");

                    b.Property<int?>("TagidTag")
                        .HasColumnType("int");

                    b.Property<int>("idPostagem")
                        .HasColumnName("ID_POSTAGEM_TAG_POSTAGEM")
                        .HasColumnType("int");

                    b.Property<int?>("idTag")
                        .HasColumnName("ID_TAG_TAG_POSTAGEM")
                        .HasColumnType("int");

                    b.HasKey("idTagPostagem");

                    b.HasIndex("PostagemidPostagem");

                    b.HasIndex("TagidTag");

                    b.ToTable("TAGS_POSTAGEM");
                });

            modelBuilder.Entity("Repository.Models.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_USUARIO")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnName("EMAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnName("NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnName("SENHA")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.ToTable("USUARIOS");
                });

            modelBuilder.Entity("Repository.Models.Comentario", b =>
                {
                    b.HasOne("Repository.Models.Postagem", "Postagem")
                        .WithMany()
                        .HasForeignKey("PostagemidPostagem");
                });

            modelBuilder.Entity("Repository.Models.CustomizacaoPostagem", b =>
                {
                    b.HasOne("Repository.Models.FotoFundoPostagem", "FotoFundoPostagem")
                        .WithMany()
                        .HasForeignKey("FotoFundoPostagemidFotoFundoPostagem");
                });

            modelBuilder.Entity("Repository.Models.Postagem", b =>
                {
                    b.HasOne("Repository.Models.CustomizacaoPostagem", "CustomizacaoPostagem")
                        .WithMany()
                        .HasForeignKey("CustomizacaoPostagemidCustomizacaoPostagem");

                    b.HasOne("Repository.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioidUsuario");
                });

            modelBuilder.Entity("Repository.Models.PostagemControle", b =>
                {
                    b.HasOne("Repository.Models.Controle", "Controle")
                        .WithMany()
                        .HasForeignKey("ControleidControle");

                    b.HasOne("Repository.Models.Postagem", "Postagem")
                        .WithMany()
                        .HasForeignKey("PostagemidPostagem");
                });

            modelBuilder.Entity("Repository.Models.Reacao", b =>
                {
                    b.HasOne("Repository.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioidUsuario");
                });

            modelBuilder.Entity("Repository.Models.ReacaoPostagem", b =>
                {
                    b.HasOne("Repository.Models.Postagem", "Postagem")
                        .WithMany()
                        .HasForeignKey("PostagemidPostagem");

                    b.HasOne("Repository.Models.Reacao", "Reacao")
                        .WithMany()
                        .HasForeignKey("ReacaoidReacao");
                });

            modelBuilder.Entity("Repository.Models.TagPostagem", b =>
                {
                    b.HasOne("Repository.Models.Postagem", "Postagem")
                        .WithMany()
                        .HasForeignKey("PostagemidPostagem");

                    b.HasOne("Repository.Models.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagidTag");
                });
#pragma warning restore 612, 618
        }
    }
}
