using System;
namespace DotNetCore2RestWebApplication.Models
{
    class Cielo:Adquirente
    {
        public Cielo()
        {
            this.Adquirente_ = "Cielo";
        }

        public override void ObtemTaxasVisa()
        {    
            this.Taxas.Add(new Taxa("Visa", 2.25M, 2.00M));
        }

        public override void ObtemTaxasMaster()
        {
            this.Taxas.Add(new Taxa("Master", 2.35M, 1.98M));
        }

    }
}
