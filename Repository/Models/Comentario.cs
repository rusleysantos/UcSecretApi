using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class Comentario
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_COMENTARIO")]
        public int idComentario { get; set; }

        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        [Column("DATA_HORA_COMENTARIO")]
        public DateTime DataHoraComentario { get; set; }

        [Column("ID_POSTAGEM_COMENTARIO")]
        [ForeignKey("idPostagem")]
        public int idPostagem { get; set; }
        public virtual Postagem Postagem { get; set; }
    }
}
