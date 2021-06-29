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
        public async Task<IActionResult> CriarPostagem([FromBody] PostagemDTO postagem)
        {
            try
            {
                if (await _service.CriarPostagem(postagem))
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
        public async Task<IActionResult> DesativarPostagem([FromQuery] int idPostagem)
        {
            try
            {
                if (await _service.DesativarPostagem(idPostagem))
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
        public async Task<IActionResult> VerificarPostagemAtiva([FromQuery] int idPostagem)
        {
            try
            {
                if (await _service.VerificarPostagemAtiva(idPostagem))
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

        [HttpPost("[action]")]
        public async Task<IActionResult> RetornarPostagemPaginada([FromQuery] int idPostagem, int pagina, int quantidade)
        {
            try
            {
                return Ok(new MessageReturn(
                    "Sucesso",
                    "",
                    true,
                    await _service.RetornarComentario(idPostagem, pagina, quantidade)));


            }
            catch
            {
                return BadRequest(new MessageReturn("Erro",
                                                     "Erro",
                                                     false));

            }
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> PostarComentario([FromBody] PostagemComentarioDTO comentario)
        {
            try
            {
                if (await _service.PostarComentario(comentario))
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
