using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class Context : DbContext
    {

        [Key]
        public int DbContextId { get; set; }

        [NotMapped]
        private IConfiguration _conf { get; set; }

        public Context(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _conf = configuration;
        }

        public Context() : base()
        {

        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_conf.GetConnectionString("ConnDB"));
        }

        public DbSet<Comentario> COMENTARIOS { get; set; }
        public DbSet<Controle> CONTROLES { get; set; }
        public DbSet<CustomizacaoPostagem> CUSTOMIZACOES_POSTAGEM { get; set; }
        public DbSet<FotoFundoPostagem> FOTOS_FUNDO_POSTAGEM { get; set; }
        public DbSet<FotoUsuario> FOTOS_USUARIO { get; set; }
        public DbSet<Postagem> POSTAGEM { get; set; }
        public DbSet<PostagemControle> POSTAGENS_CONTROLES { get; set; }
        public DbSet<Reacao> REACOES { get; set; }
        public DbSet<ReacaoPostagem> REACOES_POSTAGENS { get; set; }
        public DbSet<Tag> TAGS { get; set; }
        public DbSet<TagPostagem> TAGS_POSTAGEM { get; set; }
        public DbSet<Usuario> USUARIOS { get; set; }
    }
}
