using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class TagPostagem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_TAG_POSTAGEM")]
        public int idTagPostagem { get; set; }

        [Column("ID_POSTAGEM_TAG_POSTAGEM")]
        [ForeignKey("idPostagem")]
        public int idPostagem { get; set; }
        public virtual Postagem Postagem { get; set; }

        [Column("ID_TAG_TAG_POSTAGEM")]
        [ForeignKey("idTag")]
        public int? idTag { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
