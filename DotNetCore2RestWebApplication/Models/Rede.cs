using System;
namespace DotNetCore2RestWebApplication.Models
{
    class Rede: Adquirente
    {
        public Rede()
        {
            this.Adquirente_ = "Rede";
            ObtemTaxasVisa();
            ObtemTaxasMaster();
        }

        public override void ObtemTaxasVisa()
        {
            this.Taxas.Add(new Taxa("Visa", 2.75M, 2.16M));
        }

        public override void ObtemTaxasMaster()
        {
            this.Taxas.Add(new Taxa("Master", 3.10M, 1.58M));
        }
    }
}
