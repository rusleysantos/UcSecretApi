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

        [Column("DESCRICAO")]
        public string Descricao { get; set; }
    }
}
