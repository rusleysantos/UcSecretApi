using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Migraton_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CONTROLES",
                columns: table => new
                {
                    ID_CONTROLE = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RESTRICAO = table.Column<bool>(nullable: false),
                    APROVACAO = table.Column<bool>(nullable: false),
                    DESCRICAO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTROLES", x => x.ID_CONTROLE);
                });

            migrationBuilder.CreateTable(
                name: "FOTOS_FUNDO_POSTAGEM",
                columns: table => new
                {
                    ID_FOTO_FUNDO_POSTAGEM = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITULO = table.Column<string>(nullable: true),
                    ARRAY_BYTE = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FOTOS_FUNDO_POSTAGEM", x => x.ID_FOTO_FUNDO_POSTAGEM);
                });

            migrationBuilder.CreateTable(
                name: "FOTOS_USUARIO",
                columns: table => new
                {
                    ID_FOTO_USUARIO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ARRAY_BYTE = table.Column<byte>(nullable: false),
                    DESCRICAO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FOTOS_USUARIO", x => x.ID_FOTO_USUARIO);
                });

            migrationBuilder.CreateTable(
                name: "REACOES_POSTAGENS",
                columns: table => new
                {
                    ID_REACAO_POSTAGEM = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRICAO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REACOES_POSTAGENS", x => x.ID_REACAO_POSTAGEM);
                });

            migrationBuilder.CreateTable(
                name: "TAGS",
                columns: table => new
                {
                    ID_TAG = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(nullable: true),
                    DESCRICAO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAGS", x => x.ID_TAG);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    ID_USUARIO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(nullable: true),
                    SENHA = table.Column<string>(nullable: true),
                    EMAIL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.ID_USUARIO);
                });

            migrationBuilder.CreateTable(
                name: "CUSTOMIZACOES_POSTAGEM",
                columns: table => new
                {
                    ID_CUSTOMIZACAO_POSTAGEM = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COR = table.Column<string>(nullable: true),
                    ID_CUSTOMIZACAO_POSTAGEM_ = table.Column<int>(nullable: true),
                    FotoFundoPostagemidFotoFundoPostagem = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMIZACOES_POSTAGEM", x => x.ID_CUSTOMIZACAO_POSTAGEM);
                    table.ForeignKey(
                        name: "FK_CUSTOMIZACOES_POSTAGEM_FOTOS_FUNDO_POSTAGEM_FotoFundoPostagemidFotoFundoPostagem",
                        column: x => x.FotoFundoPostagemidFotoFundoPostagem,
                        principalTable: "FOTOS_FUNDO_POSTAGEM",
                        principalColumn: "ID_FOTO_FUNDO_POSTAGEM",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "REACOES",
                columns: table => new
                {
                    ID_REACAO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRICAO = table.Column<string>(nullable: true),
                    USUARIO_REACAO = table.Column<int>(nullable: false),
                    UsuarioidUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REACOES", x => x.ID_REACAO);
                    table.ForeignKey(
                        name: "FK_REACOES_USUARIOS_UsuarioidUsuario",
                        column: x => x.UsuarioidUsuario,
                        principalTable: "USUARIOS",
                        principalColumn: "ID_USUARIO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "POSTAGEM",
                columns: table => new
                {
                    ID_POSTAGEM = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRICAO = table.Column<string>(nullable: true),
                    DATA_HORA_POSTAGEM = table.Column<DateTime>(nullable: false),
                    ATIVA = table.Column<bool>(nullable: false),
                    ID_USUARIO_POSTAGEM = table.Column<int>(nullable: false),
                    UsuarioidUsuario = table.Column<int>(nullable: true),
                    ID_CUSTOMIZACAO_POSTAGEM = table.Column<int>(nullable: false),
                    CustomizacaoPostagemidCustomizacaoPostagem = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSTAGEM", x => x.ID_POSTAGEM);
                    table.ForeignKey(
                        name: "FK_POSTAGEM_CUSTOMIZACOES_POSTAGEM_CustomizacaoPostagemidCustomizacaoPostagem",
                        column: x => x.CustomizacaoPostagemidCustomizacaoPostagem,
                        principalTable: "CUSTOMIZACOES_POSTAGEM",
                        principalColumn: "ID_CUSTOMIZACAO_POSTAGEM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_POSTAGEM_USUARIOS_UsuarioidUsuario",
                        column: x => x.UsuarioidUsuario,
                        principalTable: "USUARIOS",
                        principalColumn: "ID_USUARIO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "COMENTARIOS",
                columns: table => new
                {
                    ID_COMENTARIO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRICAO = table.Column<string>(nullable: true),
                    DATA_HORA_COMENTARIO = table.Column<DateTime>(nullable: false),
                    ID_POSTAGEM_COMENTARIO = table.Column<int>(nullable: false),
                    PostagemidPostagem = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMENTARIOS", x => x.ID_COMENTARIO);
                    table.ForeignKey(
                        name: "FK_COMENTARIOS_POSTAGEM_PostagemidPostagem",
                        column: x => x.PostagemidPostagem,
                        principalTable: "POSTAGEM",
                        principalColumn: "ID_POSTAGEM",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "POSTAGENS_CONTROLES",
                columns: table => new
                {
                    ID_POSTAGEM_CONTROLE = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_POSTAGEM_POSTAGEM_CONTROLE = table.Column<int>(nullable: false),
                    PostagemidPostagem = table.Column<int>(nullable: true),
                    ID_CONTROLE_POSTAGEM_CONTROLE = table.Column<int>(nullable: false),
                    ControleidControle = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSTAGENS_CONTROLES", x => x.ID_POSTAGEM_CONTROLE);
                    table.ForeignKey(
                        name: "FK_POSTAGENS_CONTROLES_CONTROLES_ControleidControle",
                        column: x => x.ControleidControle,
                        principalTable: "CONTROLES",
                        principalColumn: "ID_CONTROLE",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_POSTAGENS_CONTROLES_POSTAGEM_PostagemidPostagem",
                        column: x => x.PostagemidPostagem,
                        principalTable: "POSTAGEM",
                        principalColumn: "ID_POSTAGEM",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TAGS_POSTAGEM",
                columns: table => new
                {
                    ID_TAG_POSTAGEM = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_POSTAGEM_TAG_POSTAGEM = table.Column<int>(nullable: false),
                    PostagemidPostagem = table.Column<int>(nullable: true),
                    ID_TAG_TAG_POSTAGEM = table.Column<int>(nullable: true),
                    TagidTag = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAGS_POSTAGEM", x => x.ID_TAG_POSTAGEM);
                    table.ForeignKey(
                        name: "FK_TAGS_POSTAGEM_POSTAGEM_PostagemidPostagem",
                        column: x => x.PostagemidPostagem,
                        principalTable: "POSTAGEM",
                        principalColumn: "ID_POSTAGEM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TAGS_POSTAGEM_TAGS_TagidTag",
                        column: x => x.TagidTag,
                        principalTable: "TAGS",
                        principalColumn: "ID_TAG",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_COMENTARIOS_PostagemidPostagem",
                table: "COMENTARIOS",
                column: "PostagemidPostagem");

            migrationBuilder.CreateIndex(
                name: "IX_CUSTOMIZACOES_POSTAGEM_FotoFundoPostagemidFotoFundoPostagem",
                table: "CUSTOMIZACOES_POSTAGEM",
                column: "FotoFundoPostagemidFotoFundoPostagem");

            migrationBuilder.CreateIndex(
                name: "IX_POSTAGEM_CustomizacaoPostagemidCustomizacaoPostagem",
                table: "POSTAGEM",
                column: "CustomizacaoPostagemidCustomizacaoPostagem");

            migrationBuilder.CreateIndex(
                name: "IX_POSTAGEM_UsuarioidUsuario",
                table: "POSTAGEM",
                column: "UsuarioidUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_POSTAGENS_CONTROLES_ControleidControle",
                table: "POSTAGENS_CONTROLES",
                column: "ControleidControle");

            migrationBuilder.CreateIndex(
                name: "IX_POSTAGENS_CONTROLES_PostagemidPostagem",
                table: "POSTAGENS_CONTROLES",
                column: "PostagemidPostagem");

            migrationBuilder.CreateIndex(
                name: "IX_REACOES_UsuarioidUsuario",
                table: "REACOES",
                column: "UsuarioidUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_TAGS_POSTAGEM_PostagemidPostagem",
                table: "TAGS_POSTAGEM",
                column: "PostagemidPostagem");

            migrationBuilder.CreateIndex(
                name: "IX_TAGS_POSTAGEM_TagidTag",
                table: "TAGS_POSTAGEM",
                column: "TagidTag");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COMENTARIOS");

            migrationBuilder.DropTable(
                name: "FOTOS_USUARIO");

            migrationBuilder.DropTable(
                name: "POSTAGENS_CONTROLES");

            migrationBuilder.DropTable(
                name: "REACOES");

            migrationBuilder.DropTable(
                name: "REACOES_POSTAGENS");

            migrationBuilder.DropTable(
                name: "TAGS_POSTAGEM");

            migrationBuilder.DropTable(
                name: "CONTROLES");

            migrationBuilder.DropTable(
                name: "POSTAGEM");

            migrationBuilder.DropTable(
                name: "TAGS");

            migrationBuilder.DropTable(
                name: "CUSTOMIZACOES_POSTAGEM");

            migrationBuilder.DropTable(
                name: "USUARIOS");

            migrationBuilder.DropTable(
                name: "FOTOS_FUNDO_POSTAGEM");
        }
    }
}
