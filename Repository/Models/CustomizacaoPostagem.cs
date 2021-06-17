using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class CustomizacaoPostagem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_CUSTOMIZACAO_POSTAGEM")]
        public int idCustomizacaoPostagem { get; set; }
        
        [Column("COR")]
        public string Cor { get; set; }

        [Column("ID_CUSTOMIZACAO_POSTAGEM_")]
        [ForeignKey("idFotoFundoPostagem")]
        public int? idFotoFundoPostagem { get; set; }
        public virtual FotoFundoPostagem FotoFundoPostagem { get; set; }

    }
}
