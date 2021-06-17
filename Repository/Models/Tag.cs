using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_TAG")]
        public int idTag { get; set; }

        [Column("NOME")]
        public string Nome { get; set; }

        [Column("DESCRICAO")]
        public string Descricao { get; set; }
    }
}
