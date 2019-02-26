using System;
using System.Threading.Tasks;
using DotNetCore2RestWebApplication.Models;
using DotNetCore2RestWebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCore2RestWebApplication.Controllers
{
    [ApiController]
    [Route("api/")]
    public class TransacaoTaxasController : Controller
    {
        private readonly ILogger _logger;
        private readonly ITransacaoTaxasService _transacaoTaxasService;

        public TransacaoTaxasController(ITransacaoTaxasService transacaoTaxasService, ILogger<TransacaoTaxasController> logger)
        {
            _transacaoTaxasService = transacaoTaxasService;
            _logger = logger;
        }

        /* OBS: Utilizacao do Reflection como factory do
         * Adquirente referente.
         */
        // GET: api/mdr/adquirente/{Nome}
        [HttpGet("mdr/adquirente/{adquirente}")]
        public async Task<IActionResult> ObtemMdrAdquirente(string adquirente)
        {
            try
            {
                var result = _transacaoTaxasService.ObtemMdrAdquirente(adquirente);
                Adquirente adquirenteObj = result;

                if (adquirenteObj != null)
                {
                    await Task.Run(() => adquirenteObj);
                    return Ok(adquirenteObj);
                }
                else
                {
                    return NotFound();
                }
            }catch(Exception e)
            {
                return NoContent();
            }
        }

        // POST api/transaction
        [HttpPost("transaction")]
        public async Task<IActionResult> ObtemValorLiquidoTransacao([FromBody] TransacaoTaxas transacaoTaxas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                try
                {
                    dynamic result = _transacaoTaxasService.ObtemValorLiquidoTransacao(transacaoTaxas);
                    await Task.Run(() => result);
                    return Ok(new ValorLiquidoResponse(result));

                }catch(Exception e)
                {
                    _logger.LogInformation("Ocorreu um erro ao processar o valor liquido de transacao. " + e.Message);
                    return StatusCode(500);
                }
            }
           
        }

    }
}
