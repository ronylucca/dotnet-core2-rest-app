using System;
using System.Reflection;
using System.Threading.Tasks;
using DotNetCore2RestWebApplication.Models;
using Microsoft.Extensions.Logging;

namespace DotNetCore2RestWebApplication.Services
{
    public class TransacaoTaxasService : ITransacaoTaxasService
    {

        private readonly ILogger _logger;
        private static string VISA = "Visa";


        public TransacaoTaxasService(ILogger<TransacaoTaxasService> logger)
        {
            _logger = logger;
        }

        public Adquirente ObtemMdrAdquirente(string adquirente)
        {
            Type adquirenteObj = Assembly.GetEntryAssembly().GetType("DotNetCore2RestWebApplication.Models." + adquirente);
            if (adquirenteObj != null)
            {
                object entity = Activator.CreateInstance(adquirenteObj);
                ((Adquirente)entity).consultarTaxas();
                _logger.LogInformation("Processamento de consulta de MDR realizado com sucesso");
                return (Adquirente)entity;
            }
            else
            {
                return null;
            }

        }

        public decimal ObtemValorLiquidoTransacao(TransacaoTaxas transacaoTaxas)
        {
            Type adquirenteObj =  Assembly.GetEntryAssembly().GetType("DotNetCore2RestWebApplication.Models." + transacaoTaxas.adquirente);
            if(adquirenteObj != null)
            {
                object entity = Activator.CreateInstance(adquirenteObj);
                Adquirente adquirente = ((Adquirente)entity);
                _logger.LogInformation("Processamento de consulta do ValorLiquidoAdquirente realizado com sucesso");
                return RealizaCalculoTaxasTransacao(transacaoTaxas, adquirente);
            }
            else
            {
                return Decimal.Zero;
            }
        }

        private decimal RealizaCalculoTaxasTransacao(TransacaoTaxas transacaoTaxas, Adquirente adquirente)
        {
            if (transacaoTaxas.bandeira.Equals(VISA))
            {
                adquirente.ObtemTaxasVisa();
            }
            else
            {
                adquirente.ObtemTaxasMaster();
            }
            decimal valorTaxaAdquirenteBandeira = adquirente.Taxas[0].ObtemTaxaTransacao(transacaoTaxas.tipoTransacao);
            return transacaoTaxas.calculaValorTaxa(valorTaxaAdquirenteBandeira);
        }
    }
}
