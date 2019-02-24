using System;
using System.Collections.Generic;

namespace DotNetCore2RestWebApplication.Models
{
    public class Adquirente
    {
        public string Adquirente_ { get; set; }
        private List<Taxa> taxas = new List<Taxa>();

        public List<Taxa> Taxas
        {
            get { return taxas; }
        }

        public void ObtemTaxasMaster() { }

        public void ObtemTaxasVisa() { }
    }

}
