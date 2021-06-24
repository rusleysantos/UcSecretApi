using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Adiciona_Valores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COMENTARIOS_POSTAGEM_PostagemidPostagem",
                table: "COMENTARIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_POSTAGEM_CUSTOMIZACOES_POSTAGEM_CustomizacaoPostagemidCustomizacaoPostagem",
                table: "POSTAGEM");

            migrationBuilder.DropForeignKey(
                name: "FK_POSTAGEM_USUARIOS_UsuarioidUsuario",
                table: "POSTAGEM");

            migrationBuilder.DropForeignKey(
                name: "FK_POSTAGENS_CONTROLES_POSTAGEM_PostagemidPostagem",
                table: "POSTAGENS_CONTROLES");

            migrationBuilder.DropForeignKey(
                name: "FK_TAGS_POSTAGEM_POSTAGEM_PostagemidPostagem",
                table: "TAGS_POSTAGEM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_POSTAGEM",
                table: "POSTAGEM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FOTOS_USUARIO",
                table: "FOTOS_USUARIO");

            migrationBuilder.DropColumn(
                name: "DESCRICAO",
                table: "REACOES_POSTAGENS");

            migrationBuilder.RenameTable(
                name: "POSTAGEM",
                newName: "POSTAGENS");

            migrationBuilder.RenameTable(
                name: "FOTOS_USUARIO",
                newName: "FOTOS_USUARIOS");

            migrationBuilder.RenameIndex(
                name: "IX_POSTAGEM_UsuarioidUsuario",
                table: "POSTAGENS",
                newName: "IX_POSTAGENS_UsuarioidUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_POSTAGEM_CustomizacaoPostagemidCustomizacaoPostagem",
                table: "POSTAGENS",
                newName: "IX_POSTAGENS_CustomizacaoPostagemidCustomizacaoPostagem");

            migrationBuilder.AddColumn<int>(
                name: "PostagemidPostagem",
                table: "REACOES_POSTAGENS",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReacaoidReacao",
                table: "REACOES_POSTAGENS",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID_REACAO_POSTAGEM_POSTAGEM",
                table: "REACOES_POSTAGENS",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_REACAO_POSTAGEM_REACAO",
                table: "REACOES_POSTAGENS",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ID_CUSTOMIZACAO_POSTAGEM",
                table: "POSTAGENS",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_POSTAGENS",
                table: "POSTAGENS",
                column: "ID_POSTAGEM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FOTOS_USUARIOS",
                table: "FOTOS_USUARIOS",
                column: "ID_FOTO_USUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_REACOES_POSTAGENS_PostagemidPostagem",
                table: "REACOES_POSTAGENS",
                column: "PostagemidPostagem");

            migrationBuilder.CreateIndex(
                name: "IX_REACOES_POSTAGENS_ReacaoidReacao",
                table: "REACOES_POSTAGENS",
                column: "ReacaoidReacao");

            migrationBuilder.AddForeignKey(
                name: "FK_COMENTARIOS_POSTAGENS_PostagemidPostagem",
                table: "COMENTARIOS",
                column: "PostagemidPostagem",
                principalTable: "POSTAGENS",
                principalColumn: "ID_POSTAGEM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_POSTAGENS_CUSTOMIZACOES_POSTAGEM_CustomizacaoPostagemidCustomizacaoPostagem",
                table: "POSTAGENS",
                column: "CustomizacaoPostagemidCustomizacaoPostagem",
                principalTable: "CUSTOMIZACOES_POSTAGEM",
                principalColumn: "ID_CUSTOMIZACAO_POSTAGEM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_POSTAGENS_USUARIOS_UsuarioidUsuario",
                table: "POSTAGENS",
                column: "UsuarioidUsuario",
                principalTable: "USUARIOS",
                principalColumn: "ID_USUARIO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_POSTAGENS_CONTROLES_POSTAGENS_PostagemidPostagem",
                table: "POSTAGENS_CONTROLES",
                column: "PostagemidPostagem",
                principalTable: "POSTAGENS",
                principalColumn: "ID_POSTAGEM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_REACOES_POSTAGENS_POSTAGENS_PostagemidPostagem",
                table: "REACOES_POSTAGENS",
                column: "PostagemidPostagem",
                principalTable: "POSTAGENS",
                principalColumn: "ID_POSTAGEM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_REACOES_POSTAGENS_REACOES_ReacaoidReacao",
                table: "REACOES_POSTAGENS",
                column: "ReacaoidReacao",
                principalTable: "REACOES",
                principalColumn: "ID_REACAO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TAGS_POSTAGEM_POSTAGENS_PostagemidPostagem",
                table: "TAGS_POSTAGEM",
                column: "PostagemidPostagem",
                principalTable: "POSTAGENS",
                principalColumn: "ID_POSTAGEM",
                onDelete: ReferentialAction.Restrict);

            //string[] columns = new string[] { "TITULO", "ARRAY_BYTE" };
            ////string[,]values = new string[2,2] {{ "TITULO", "ARRAY_BYTE" }, { "ARRAY_BYTE", "FOFO" } };
            //string[] values = new string[] { "TITULO", "ARRAY_BYTE" };

            //migrationBuilder.InsertData(table: "FOTOS_FUNDO_POSTAGEM", columns: columns, values: values, default);
            //migrationBuilder.Sql(@"INSERT INTO STATUS
            //                        (DESCRIPTION, TIPO) 
            //                       VALUES
            //                        ('Em Andamento','TA'),
            //                        ('Impedida','TA'),
            //                        ('Concluída','TA'),
            //                        ('Bloqueada','TA'),
            //                        ('Excluir','TA')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_COMENTARIOS_POSTAGENS_PostagemidPostagem",
                table: "COMENTARIOS");

            migrationBuilder.DropForeignKey(
                name: "FK_POSTAGENS_CUSTOMIZACOES_POSTAGEM_CustomizacaoPostagemidCustomizacaoPostagem",
                table: "POSTAGENS");

            migrationBuilder.DropForeignKey(
                name: "FK_POSTAGENS_USUARIOS_UsuarioidUsuario",
                table: "POSTAGENS");

            migrationBuilder.DropForeignKey(
                name: "FK_POSTAGENS_CONTROLES_POSTAGENS_PostagemidPostagem",
                table: "POSTAGENS_CONTROLES");

            migrationBuilder.DropForeignKey(
                name: "FK_REACOES_POSTAGENS_POSTAGENS_PostagemidPostagem",
                table: "REACOES_POSTAGENS");

            migrationBuilder.DropForeignKey(
                name: "FK_REACOES_POSTAGENS_REACOES_ReacaoidReacao",
                table: "REACOES_POSTAGENS");

            migrationBuilder.DropForeignKey(
                name: "FK_TAGS_POSTAGEM_POSTAGENS_PostagemidPostagem",
                table: "TAGS_POSTAGEM");

            migrationBuilder.DropIndex(
                name: "IX_REACOES_POSTAGENS_PostagemidPostagem",
                table: "REACOES_POSTAGENS");

            migrationBuilder.DropIndex(
                name: "IX_REACOES_POSTAGENS_ReacaoidReacao",
                table: "REACOES_POSTAGENS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_POSTAGENS",
                table: "POSTAGENS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FOTOS_USUARIOS",
                table: "FOTOS_USUARIOS");

            migrationBuilder.DropColumn(
                name: "PostagemidPostagem",
                table: "REACOES_POSTAGENS");

            migrationBuilder.DropColumn(
                name: "ReacaoidReacao",
                table: "REACOES_POSTAGENS");

            migrationBuilder.DropColumn(
                name: "ID_REACAO_POSTAGEM_POSTAGEM",
                table: "REACOES_POSTAGENS");

            migrationBuilder.DropColumn(
                name: "ID_REACAO_POSTAGEM_REACAO",
                table: "REACOES_POSTAGENS");

            migrationBuilder.RenameTable(
                name: "POSTAGENS",
                newName: "POSTAGEM");

            migrationBuilder.RenameTable(
                name: "FOTOS_USUARIOS",
                newName: "FOTOS_USUARIO");

            migrationBuilder.RenameIndex(
                name: "IX_POSTAGENS_UsuarioidUsuario",
                table: "POSTAGEM",
                newName: "IX_POSTAGEM_UsuarioidUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_POSTAGENS_CustomizacaoPostagemidCustomizacaoPostagem",
                table: "POSTAGEM",
                newName: "IX_POSTAGEM_CustomizacaoPostagemidCustomizacaoPostagem");

            migrationBuilder.AddColumn<string>(
                name: "DESCRICAO",
                table: "REACOES_POSTAGENS",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID_CUSTOMIZACAO_POSTAGEM",
                table: "POSTAGEM",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_POSTAGEM",
                table: "POSTAGEM",
                column: "ID_POSTAGEM");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FOTOS_USUARIO",
                table: "FOTOS_USUARIO",
                column: "ID_FOTO_USUARIO");

            migrationBuilder.AddForeignKey(
                name: "FK_COMENTARIOS_POSTAGEM_PostagemidPostagem",
                table: "COMENTARIOS",
                column: "PostagemidPostagem",
                principalTable: "POSTAGEM",
                principalColumn: "ID_POSTAGEM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_POSTAGEM_CUSTOMIZACOES_POSTAGEM_CustomizacaoPostagemidCustomizacaoPostagem",
                table: "POSTAGEM",
                column: "CustomizacaoPostagemidCustomizacaoPostagem",
                principalTable: "CUSTOMIZACOES_POSTAGEM",
                principalColumn: "ID_CUSTOMIZACAO_POSTAGEM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_POSTAGEM_USUARIOS_UsuarioidUsuario",
                table: "POSTAGEM",
                column: "UsuarioidUsuario",
                principalTable: "USUARIOS",
                principalColumn: "ID_USUARIO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_POSTAGENS_CONTROLES_POSTAGEM_PostagemidPostagem",
                table: "POSTAGENS_CONTROLES",
                column: "PostagemidPostagem",
                principalTable: "POSTAGEM",
                principalColumn: "ID_POSTAGEM",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TAGS_POSTAGEM_POSTAGEM_PostagemidPostagem",
                table: "TAGS_POSTAGEM",
                column: "PostagemidPostagem",
                principalTable: "POSTAGEM",
                principalColumn: "ID_POSTAGEM",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
