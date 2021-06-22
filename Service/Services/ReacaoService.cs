using Repository.Contracts;
using Repository.DTO;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ReacaoService : IReacaoService
    {
        public IReacaoRepository _repo { get; set; }
        public ReacaoService(IReacaoRepository repo)
        {
            _repo = repo;
        }

        public Task<List<Reacao>> RetonarReacoesPaginada(int pagina, int quantidade)
        {
            return _repo.RetonarReacoesPaginada(pagina, quantidade);
        }

        public Task<List<ReacaoPostagemDTO>> RetonarReacoesPostagem(int idPostagem)
        {
            return _repo.RetonarReacoesPostagem(idPostagem);
        }
    }
}
