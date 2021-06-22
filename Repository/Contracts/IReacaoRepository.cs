using Repository.DTO;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface IReacaoRepository
    {
        public Task<List<Reacao>> RetonarReacoesPaginada(int pagina, int quantidade);
        public Task<List<ReacaoPostagemDTO>> RetonarReacoesPostagem(int idPostagem);
    }
}
