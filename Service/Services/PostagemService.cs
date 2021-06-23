using Repository.Contracts;
using Repository.DTO;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class PostagemService : IPostagemService
    {
        public IPostagemRepository _repo { get; set; }
        
        public PostagemService(IPostagemRepository repo)
        {
            _repo = repo;
        }

        public Task<bool> CriarPostagem(PostagemDTO postagem)
        {
            return _repo.CriarPostagem(postagem);
        }

        public Task<bool> DesativarPostagem(int idPostagem)
        {
            return _repo.DesativarPostagem(idPostagem);
        }

        public Task<List<FotoFundoPostagem>> RetornarFotoFundoPostagemPaginada(int pagina, int quantidade)
        {
            return _repo.RetornarFotoFundoPostagemPaginada(pagina,quantidade);
        }

        public Task<List<Postagem>> RetornarPostagemPaginada(int pagina, int quantidade)
        {
            return _repo.RetornarPostagemPaginada(pagina, quantidade);
        }

        public Task<bool> VerificarPostagemAtiva(int idPostagem)
        {
            return _repo.VerificarPostagemAtiva(idPostagem);
        }
    }
}
