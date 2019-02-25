using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCore2RestWebApplication.Models
{
    public class TransacaoTaxas
    {
        [Required]
        public decimal valor { get; set; }
        [Required]
        public string adquirente { get; set; }
        [Required]
        public string bandeira { get; set; }
        [Required]
        public string tipoTransacao { get; set; }


        public TransacaoTaxas(decimal valor, string adquirente, string bandeira, string tipoTransacao)
        {
            this.valor = valor;
            this.adquirente = adquirente;
            this.bandeira = bandeira;
            this.tipoTransacao = tipoTransacao;
        }

        public TransacaoTaxas() { }

        internal decimal calculaValorTaxa(decimal valorTaxaAdquirenteBandeira)
        {
            return valor - ((valor * valorTaxaAdquirenteBandeira) / 100);
        }
    }
}

    public class ValorLiquidoResponse{

        public decimal valorLiquido;
        
        public ValorLiquidoResponse(decimal valor)
        {
            this.valorLiquido = valor;
        }
    }


