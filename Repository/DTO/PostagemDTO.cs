using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DTO
{
    public class PostagemDTO
    {
        public string Descricao { get; set; }
        public DateTime DataHoraPostagem { get; set; }
        public bool Ativa { get; set; }
        public int idUsuario { get; set; }
        public string Cor { get; set; }
        public bool Customizada { get; set; }
        public int? idCustomizacaoPostagem { get; set; }
        public int? idFotoFundoPostagem { get; set; }

    }
}
