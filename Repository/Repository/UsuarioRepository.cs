using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private Context _con { get; set; }

        public UsuarioRepository(Context con)
        {
            _con = con;
        }

        public async Task<bool> CriarUsuario(Usuario usuario)
        {
            await _con.USUARIOS.AddAsync(usuario);

            var salvar = await _con.SaveChangesAsync();

            return salvar > 0;
        }
    }
}
