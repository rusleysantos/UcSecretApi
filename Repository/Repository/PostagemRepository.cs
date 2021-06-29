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

                postagemAdicionar.idCustomizacaoPostagem = customizacao.Entity.idFotoFundoPostagem;
            }

            postagemAdicionar.Ativa = false;
            postagemAdicionar.DataHoraPostagem = DateTime.Now;
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

        public async Task<List<Postagem>> RetornarPostagemPaginada(int pagina, int quantidade)
        {
            return await _con.POSTAGENS
                          .Skip((pagina - 1) * quantidade)
                          .Take(quantidade)
                          .ToListAsync();
        }

        public async Task<List<FotoFundoPostagem>> RetornarFotoFundoPostagemPaginada(int pagina, int quantidade)
        {
            return await _con.FOTOS_FUNDO_POSTAGEM
                         .Skip((pagina - 1) * quantidade)
                         .Take(quantidade)
                         .ToListAsync();
        }

        public async Task<bool> PostarComentario(PostagemComentarioDTO comentario)
        {
            var comentarioAdd = new Comentario
            {
                DataHoraComentario = DateTime.Now,
                Descricao = comentario.Comentario,
                idPostagem = comentario.idPostagem
            };

            _con.COMENTARIOS.Add(comentarioAdd);

            var salvar = await _con.SaveChangesAsync();
            return salvar > 0;
        }

        public async Task<List<Comentario>> RetornarComentario(int idPostagem, int pagina, int quantidade)
        {
            return await _con.COMENTARIOS
                       .Where(x=>x.idPostagem == idPostagem)
                       .Skip((pagina - 1) * quantidade)
                       .Take(quantidade)
                       .ToListAsync();
        }
    }
}
