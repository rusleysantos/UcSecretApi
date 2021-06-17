using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class Controle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_CONTROLE")]
        public int idControle { get; set; }

        [Column("RESTRICAO")]
        public bool Regritacao { get; set; }

        [Column("APROVACAO")]
        public bool Aprovacao { get; set; }

        [Column("DESCRICAO")]
        public string Descricao { get; set; }

    }
}
