using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class Postagem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_POSTAGEM")]
        public int idPostagem { get; set; }

        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        [Column("DATA_HORA_POSTAGEM")]
        public DateTime DataHoraPostagem { get; set; }

        [Column("ATIVA")]
        public bool Ativa { get; set; }

        [Column("ID_USUARIO_POSTAGEM")]
        [ForeignKey("idUsuario")]
        public int idUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }

        [Column("ID_CUSTOMIZACAO_POSTAGEM")]
        [ForeignKey("idCustomizacaoPostagem")]
        public int idCustomizacaoPostagem { get; set; }
        public virtual CustomizacaoPostagem CustomizacaoPostagem { get; set; }
    }
}
