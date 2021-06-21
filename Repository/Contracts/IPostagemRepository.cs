using Repository.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface IPostagemRepository
    {
        public Task<bool> CriarPostagem(PostagemDTO postagem);
        public Task<bool> DesativarPostagem(int idPostagem);
        public Task<bool> VerificarPostagemAtiva(int idPostagem);
    }
}
