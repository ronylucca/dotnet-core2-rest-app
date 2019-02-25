using System.Threading.Tasks;
using DotNetCore2RestWebApplication.Models;
using DotNetCore2RestWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCore2RestWebApplication.Controllers
{
    [ApiController]
    [Route("api/")]
    public class TransacaoTaxasController : Controller
    {

        private readonly ITransacaoTaxasService _transacaoTaxasService;

        public TransacaoTaxasController(ITransacaoTaxasService transacaoTaxasService)
        {
            _transacaoTaxasService = transacaoTaxasService;
        }

        /* OBS: Utilizacao do Reflection como factory do
         * Adquirente referente.
         */
        // GET: api/mdr/adquirente/{Nome}
        [HttpGet("mdr/adquirente/{adquirente}")]
        public async Task<IActionResult> ObtemMdrAdquirente(string adquirente)
        {
            dynamic result = _transacaoTaxasService.ObtemMdrAdquirente(adquirente);
            Adquirente adquirenteObj = result;

            if (adquirenteObj != null)
            {
                return Ok(adquirenteObj);
            }
            else
            {
                return NotFound();
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
                dynamic result = _transacaoTaxasService.ObtemValorLiquidoTransacao(transacaoTaxas);
                return Ok(new ValorLiquidoResponse(result));
            }
           
        }

    }
}
