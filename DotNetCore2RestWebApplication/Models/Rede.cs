using System;
namespace DotNetCore2RestWebApplication.Models
{
    class Rede: Adquirente
    {
        public Rede()
        {
            this.Adquirente_ = "Rede";
            obtemTaxasVisa();
            obtemTaxasMaster();
        }

        public override void obtemTaxasVisa()
        {
            this.Taxas.Add(new Taxa("Visa", 2.75M, 2.16M));
        }

        public override void obtemTaxasMaster()
        {
            this.Taxas.Add(new Taxa("Master", 3.10M, 1.58M));
        }
    }
}
