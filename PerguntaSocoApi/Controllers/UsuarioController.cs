using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Domains;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;
using Repository.Models;

namespace UcSecretApi.Controllers
{
    [Route("api")]
    public class UsuarioController : Controller
    {
        private IUsuarioService _service { get; }
        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        public async Task<IActionResult> CriarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                if (await _service.CriarUsuario(usuario))
                {
                    return Ok(new MessageReturn("Sucesso",
                                                "",
                                                true));
                }
                else
                {
                    return Ok(new MessageReturn("Não foi possível",
                                                "erro",
                                                false));

                }
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro",
                                                     "Erro",
                                                     false));

            }
        }
    }
}
