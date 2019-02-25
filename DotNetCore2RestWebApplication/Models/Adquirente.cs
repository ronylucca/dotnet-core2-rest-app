using System;
using System.Collections.Generic;

namespace DotNetCore2RestWebApplication.Models
{
    public abstract class Adquirente
    {
        public string Adquirente_ { get; set; }
        private List<Taxa> taxas = new List<Taxa>();

        public List<Taxa> Taxas
        {
            get { return taxas; }
        }

        public void consultarTaxas()
        {
            ObtemTaxasVisa();
            ObtemTaxasMaster();
        }

        public abstract void ObtemTaxasMaster();

        public abstract void ObtemTaxasVisa();

      
    }

}
