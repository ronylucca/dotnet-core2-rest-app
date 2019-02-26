using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetCore2RestWebApplication.Models
{
    public class TransacaoTaxas
    {
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal valor { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string adquirente { get; set; }

        [Required]
        [RegularExpression(@"(Master|Visa)")]
        public string bandeira { get; set; }

        [Required]
        [RegularExpression(@"(Credito|Debito)")]
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
            return Decimal.Subtract(valor, Decimal.Divide(Decimal.Multiply( valor, valorTaxaAdquirenteBandeira), 100));

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


