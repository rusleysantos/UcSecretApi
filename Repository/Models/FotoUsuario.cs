using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class FotoUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_FOTO_USUARIO")]
        public int idFotoUsuario { get; set; }

        [Column("ARRAY_BYTE")]
        public byte ArrayByte { get; set; }

        [Column("DESCRICAO")]
        public string Descricao { get; set; }
    }
}
