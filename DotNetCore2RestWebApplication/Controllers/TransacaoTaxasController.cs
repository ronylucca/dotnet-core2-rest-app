using System;
using System.Reflection;
using System.Threading.Tasks;
using DotNetCore2RestWebApplication.Models;
using DotNetCore2RestWebApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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

        /* OBS: Utilizacao do Assembly( Reflection ) para obter a instancia do 
         * Adquirente dinamicamente
         */
        // GET: api/values
        [HttpGet("mdr/adquirente/{adquirente}")]
        public async Task<IActionResult> ObtemMdrAdquirente(string adquirente)
        {
            Adquirente adquirenteObj = _transacaoTaxasService.ObtemMdrAdquirente(adquirente);

            if (adquirenteObj != null)
            {
                return Ok(adquirenteObj);
            }
            else
            {
                return NotFound();
            }

        }

        // POST api/values
        [HttpPost("transaction")]
        public async Task<IActionResult> ObtemValorLiquidoTransacao([FromBody] TransacaoTaxas transacaoTaxas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Validar Json

            return Ok(_transacaoTaxasService.ObtemValorLiquidoTransacao(transacaoTaxas));
        }

    }
}
