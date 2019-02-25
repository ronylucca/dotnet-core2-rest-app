using System.Threading.Tasks;
using DotNetCore2RestWebApplication.Models;

namespace DotNetCore2RestWebApplication.Services
{
    public interface ITransacaoTaxasService
    {
        Adquirente ObtemMdrAdquirente(string adquirente);

        decimal ObtemValorLiquidoTransacao(TransacaoTaxas transacaoTaxas);

    }
}
