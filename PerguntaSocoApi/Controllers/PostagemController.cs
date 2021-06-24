using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Domains;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;
using Repository.DTO;

namespace UcSecretApi.Controllers
{
    [Route("api")]
    public class PostagemController : Controller
    {
        private IPostagemService _service { get; }
        public PostagemController(IPostagemService service)
        {
            _service = service;
        }

        [HttpPost("[action]")]
        public IActionResult CriarPostagem([FromBody] PostagemDTO postagem)
        {
            try
            {
                if (_service.CriarPostagem(postagem).Result)
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

        [HttpPost("[action]")]
        public IActionResult DesativarPostagem([FromQuery] int idPostagem)
        {
            try
            {
                if (_service.DesativarPostagem(idPostagem).Result)
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

        [HttpPost("[action]")]
        public IActionResult VerificarPostagemAtiva([FromQuery] int idPostagem)
        {
            try
            {
                if (_service.VerificarPostagemAtiva(idPostagem).Result)
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

        [HttpPost("[action]")]
        public async Task<IActionResult> RetornarPostagemPaginada([FromQuery] int pagina, int quantidade)
        {
            try
            {
                return Ok(new MessageReturn(
                    "Sucesso",
                    "",
                    true,
                    await _service.RetornarPostagemPaginada(pagina, quantidade)));
                
               
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
