using System;
using System.Reflection;
using System.Threading.Tasks;
using DotNetCore2RestWebApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCore2RestWebApplication.Controllers
{
    [ApiController]
    [Route("api/")]
    public class TaxasTransacaoController : Controller
    {

        /* OBS: Utilizacao do Assembly( Reflection ) para obter a instancia do 
         * Adquirente dinamicamente
         */
        // GET: api/values
        [HttpGet("mdr/adquirente/{adquirente}")]
        public async Task<IActionResult> Get(string adquirente)
        {
            Type adquirenteObj = Assembly.GetEntryAssembly().GetType("DotNetCore2RestWebApplication.Models." + adquirente);

            if (adquirenteObj != null)
            {
                object entity = Activator.CreateInstance(adquirenteObj);
                return Ok(entity);
            }
            else
            {
                return NotFound();
            }

        }

        // POST api/values
        [HttpPost("transaction")]
        public async Task<IActionResult> obtemValorLiquidoTransacao([FromBody] Transaction transaction)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Validar Json

            return Ok(transaction);
        }

    }
}
