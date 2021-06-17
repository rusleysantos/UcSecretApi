using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class PostagemControle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_POSTAGEM_CONTROLE")]
        public int idPostagemControle { get; set; }

        [Column("ID_POSTAGEM_POSTAGEM_CONTROLE")]
        [ForeignKey("idPostagem")]
        public int idPostagem { get; set; }
        public virtual Postagem Postagem { get; set; }

        [Column("ID_CONTROLE_POSTAGEM_CONTROLE")]
        [ForeignKey("idControle")]
        public int idControle { get; set; }
        public virtual Controle Controle { get; set; }

    }
}
