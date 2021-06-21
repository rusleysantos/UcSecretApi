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
    public class PostagemRepository : IPostagemRepository
    {
        private Context _con { get; set; }

        public PostagemRepository(Context con)
        {
            _con = con;
        }

        public async Task<bool> CriarPostagem(PostagemDTO postagem)
        {
            var customizacao = (dynamic)null;
            Postagem postagemAdicionar = new Postagem();

            if (postagem.Customizada)
            {
                customizacao = await _con.CUSTOMIZACOES_POSTAGEM.AddAsync(new CustomizacaoPostagem
                {
                    Cor = postagem.Cor,
                    idFotoFundoPostagem = postagem.idFotoFundoPostagem
                });

                await _con.SaveChangesAsync();
            }

            postagemAdicionar.Ativa = false;
            postagemAdicionar.DataHoraPostagem = DateTime.Now;
            if (postagem.Customizada)
            {
                postagemAdicionar.idCustomizacaoPostagem = customizacao.Entity.idFotoFundoPostagem;
            }
            postagemAdicionar.Descricao = postagem.Descricao;
            postagemAdicionar.idUsuario = postagem.idUsuario;

            await _con.POSTAGENS.AddAsync(postagemAdicionar);

            var salvar = await _con.SaveChangesAsync();

            return salvar > 0;
        }

        public async Task<bool> DesativarPostagem(int idPostagem)
        {
            var postagem = await _con.POSTAGENS.Where(x => x.idUsuario == idPostagem).FirstAsync();

            if (postagem != null)
            {
                postagem.Ativa = false;
            }
            _con.POSTAGENS.Update(postagem);

            var salvar = await _con.SaveChangesAsync();
            return salvar > 0;
        }

        public async Task<bool> VerificarPostagemAtiva(int idPostagem)
        {
            var postagem = await _con.POSTAGENS.Where(x => x.idUsuario == idPostagem).FirstAsync();

            if (postagem != null)
            {
                return postagem.Ativa;
            }
            else
            {
                return false;
            }
        }
    }
}
