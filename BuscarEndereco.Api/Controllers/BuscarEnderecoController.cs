using BuscarEndereco.Core.Interfaces;
using BuscarEndereco.Core.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace BuscarEndereco.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BuscarEnderecoController : ControllerBase
    {
        protected IBuscarEnderecoServico BuscarEnderecoServico { get; }
        public BuscarEnderecoController(IBuscarEnderecoServico buscarEnderecoServico)
        {
            BuscarEnderecoServico = buscarEnderecoServico;
        }

        [HttpGet("SalvarEndereco")]
        public async Task<IActionResult> SalvarEndereco([FromBody] Endereco endereco)
        {
            await BuscarEnderecoServico.SalvarEndereco(endereco);
            return Ok();
        }

    }
}
