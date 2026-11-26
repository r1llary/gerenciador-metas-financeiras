using Microsoft.AspNetCore.Mvc;
using GerenciadorMetasFinanceiras.Core;
using GerenciadorMetasFinanceiras.Api.Models;
using GerenciadorMetasFinanceiras.Core.Services;

namespace GerenciadorMetasFinanceiras.Api.Controllers
{
    [ApiController]
    [Route("api/metas")]
    public class MetasFinanceirasController : ControllerBase
    {
        private readonly MetaFinanceiraService service;

        public MetasFinanceirasController(MetaFinanceiraService service)
        {
            this.service = service;
        }


        [HttpGet]
        public IActionResult ListarMetas()
        {
            return Ok(service.ListarMetas());
        }


        [HttpGet("{id}")]
        public IActionResult ConsultarMeta(int id)
        {
            MetaFinanceira? meta = service.ConsultarMeta(id);

            if (meta == null)
            {
                return NotFound("Meta financeira não encontrada.");
            }

            return Ok(meta);
        }

        [HttpPost]
        public IActionResult CadastrarMeta(CadastroMetaFinanceiraRequest cadastro)
        {
            try
            {
                MetaFinanceira meta = service.CadastrarMeta(
                    cadastro.Nome,
                    cadastro.ValorObjetivo,
                    cadastro.ValorEconomizado
                );

                return CreatedAtAction(
                    nameof(ConsultarMeta),
                    new { id = meta.Id },
                    meta
                );
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut("{id}")]
        public IActionResult AtualizarMeta(int id, CadastroMetaFinanceiraRequest cadastro)
        {
            try
            {
                MetaFinanceira? meta = service.AtualizarMeta(
                    id,
                    cadastro.Nome,
                    cadastro.ValorObjetivo,
                    cadastro.ValorEconomizado
                );

                if (meta == null)
                {
                    return NotFound("Meta financeira não encontrada.");
                }

                return Ok(meta);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("{id}")]
        public IActionResult AtualizarMetaParcial(
    int id, AtualizacaoParcialMetaFinanceira cadastro)
        {
            try
            {
                MetaFinanceira? meta = service.AtualizarMetaParcial(
                    id,
                    cadastro.Nome,
                    cadastro.ValorObjetivo,
                    cadastro.ValorEconomizado
                );

                if (meta == null)
                {
                    return NotFound("Meta financeira não encontrada.");
                }

                return Ok(meta);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirMeta(int id)
        {
            bool excluida = service.ExcluirMeta(id);

            if (excluida == false)
            {
                return NotFound("Meta financeira não encontrada.");
            }

            return NoContent();
        }
    }
}