using System;
using System.Reflection;
using DotNetCore2RestWebApplication.Models;

namespace DotNetCore2RestWebApplication.Services
{
    public class TransacaoTaxasService : ITransacaoTaxasService
    {


        public Adquirente ObtemMdrAdquirente(string adquirente)
        {
            Type adquirenteObj = Assembly.GetEntryAssembly().GetType("DotNetCore2RestWebApplication.Models." + adquirente);
            if (adquirenteObj != null)
            {
                object entity = Activator.CreateInstance(adquirenteObj);
                return (DotNetCore2RestWebApplication.Models.Adquirente)entity;
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
                Adquirente adquirente = ((DotNetCore2RestWebApplication.Models.Adquirente)entity);

                //cruzar dados da transacaoTaxas com Adquirente
                adquirente.ObtemTaxasMaster();
                return adquirente.Taxas[0].Credito;
            }
            else
            {
                return Decimal.Zero;
            }
        }

    }
}
