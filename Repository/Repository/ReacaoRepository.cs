using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using Repository.DTO;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Repository
{
    public class ReacaoRepository : IReacaoRepository
    {
        private Context _con { get; set; }

        public ReacaoRepository(Context con)
        {
            _con = con;
        }

        public async Task<List<Reacao>> RetonarReacoesPaginada(int pagina, int quantidade)
        {
            return await _con.REACOES
                        .Skip((pagina - 1) * quantidade)
                        .Take(quantidade)
                        .ToListAsync();
        }

        public async Task<List<ReacaoPostagemDTO>> RetonarReacoesPostagem(int idPostagem)
        {
            return await _con.REACOES_POSTAGENS
                             .Where(x => x.idPostagem == idPostagem)
                             .Select(y => new ReacaoPostagemDTO
                             {
                                 idPostagem = y.idPostagem,
                                 idReacao = y.idReacao,
                                 Descricao = _con.REACOES.Where(r => r.idReacao == y.idReacao).First().Descricao
                                                                
                             }).ToListAsync();
        }
    }
}
