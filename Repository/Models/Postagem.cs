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
        public string Descricao { get; set; }
        public DateTime DataHoraPostagem { get; set; }
        public bool Ativa { get; set; }

        [Column("ID_USUARIO_POSTAGEM")]
        [ForeignKey("idUsuario")]
        public virtual Usuario Usuario { get; set; }
        public int idUsuario { get; set; }

        [Column("ID_CUSTOMIZACAO_POSTAGEM")]
        [ForeignKey("idCustomizacaoPostagem")]
        public virtual CustomizacaoPostagem CustomizacaoPostagem { get; set; }
        public int idCustomizacaoPostagem { get; set; }
    }
}
