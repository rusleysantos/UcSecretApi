using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class FotoFundoPostagem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_FOTO_FUNDO_POSTAGEM")]
        public int idFotoFundoPostagem { get; set; }
        
        [Column("TITULO")]
        public string Titulo { get; set; }

        [Column("ARRAY_BYTE")]
        public byte ArrayByte { get; set; }
    }
}
