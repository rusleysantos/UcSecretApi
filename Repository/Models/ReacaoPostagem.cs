using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class ReacaoPostagem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_REACAO_POSTAGEM")]
        public int idReacaoPostagem { get; set; }

        [Column("ID_REACAO_POSTAGEM_REACAO")]
        [ForeignKey("idReacao")]
        public int idReacao { get; set; }
        public virtual Reacao Reacao { get; set; }

        [Column("ID_REACAO_POSTAGEM_POSTAGEM")]
        [ForeignKey("idPostagem")]
        public int idPostagem { get; set; }
        public virtual Postagem Postagem { get; set; }
    }
}
