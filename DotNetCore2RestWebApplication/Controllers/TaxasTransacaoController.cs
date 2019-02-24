using System;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCore2RestWebApplication.Controllers
{
    [Route("api/")]
    public class TaxasTransacaoController : Controller
    {

        /* OBS: Utilizacao do Assembly( Reflection ) para obter a instancia do 
         * Adquirente dinamicamente
         */
        // GET: api/values
        [HttpGet("mdr/adquirente/{adquirente}")]
        public IActionResult Get(string adquirente)
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
        public void Post([FromBody]string value)
        {
            //Validar Json
        }

    }
}
