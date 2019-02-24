using System;
using System.Collections.Generic;

namespace DotNetCore2RestWebApplication.Models
{
    abstract class Adquirente
    {
        public string Adquirente_ { get; set; }
        private List<Taxa> taxas = new List<Taxa>();

        public List<Taxa> Taxas
        {
            get { return taxas; }
        }

        public abstract void obtemTaxasMaster();

        public abstract void obtemTaxasVisa();
    }

}
