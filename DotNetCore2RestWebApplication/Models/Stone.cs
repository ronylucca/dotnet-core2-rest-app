using System;
namespace DotNetCore2RestWebApplication.Models
{
    class Stone: Adquirente
    {
        public Stone()
        {
            this.Adquirente_ = "Stone";
            obtemTaxasVisa();
            obtemTaxasMaster();
        }

        public override void obtemTaxasVisa()
        {
            this.Taxas.Add(new Taxa("Visa", 2.50M, 2.08M));
        }

        public override void obtemTaxasMaster()
        {
            this.Taxas.Add(new Taxa("Master", 2.65M, 1.75M));
        }
    }
}
