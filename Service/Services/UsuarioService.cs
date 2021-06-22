using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _repo { get; }

        public UsuarioService(IUsuarioRepository repo)
        {
            _repo = repo;
        }

        public Task<bool> CriarUsuario(Usuario usuario)
        {
            return _repo.CriarUsuario(usuario);
        }
    }
}
