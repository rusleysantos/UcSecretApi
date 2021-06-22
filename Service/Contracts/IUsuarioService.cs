using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface IUsuarioService
    {
        public Task<bool> CriarUsuario(Usuario usuario);
    }
}
