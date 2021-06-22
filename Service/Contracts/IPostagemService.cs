﻿using Repository.DTO;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface IPostagemService
    {
        public Task<bool> CriarPostagem(PostagemDTO postagem);
        public Task<bool> DesativarPostagem(int idPostagem);
        public Task<bool> VerificarPostagemAtiva(int idPostagem);
        public Task<List<Postagem>> RetornarPostagemPaginada (int pagina, int quantidade);
        public Task<List<FotoFundoPostagem>> RetornarFotoFundoPostagemPaginada(int pagina, int quantidade);

    }
}