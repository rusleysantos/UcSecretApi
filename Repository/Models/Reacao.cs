using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class Reacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_REACAO")]
        public int idReacao { get; set; }

        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        [Column("USUARIO_REACAO")]
        [ForeignKey("idUsuario")]
        public virtual Usuario Usuario { get; set; }
        public int idUsuario { get; set; }
    }
}
