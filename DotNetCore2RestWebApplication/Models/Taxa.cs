namespace DotNetCore2RestWebApplication.Models
{
    public class Taxa
    {

        public string Bandeira { get; set; }
        public decimal Credito { get; set; }
        public decimal Debito { get; set; }

        public Taxa(string bandeira, decimal credito, decimal debito)
        {
            this.Bandeira = bandeira;
            this.Credito = credito;
            this.Debito = debito;
        }

    }
}