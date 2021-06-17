using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_USUARIO")]
        public int idUsuario { get; set; }
        //public 
        

        //[Column("ID_CATEGORIA_PARTIDA")]
        //[ForeignKey("idCategoria")]
        //public virtual Categoria Categoria { get; set; }
        //public int? idCategoria { get; set; }
    }
}
