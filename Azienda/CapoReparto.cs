namespace GestioneAzienda
{
    public class CapoReparto : Dipendente
    {
        private static readonly int pagaOraria = 100;

        public CapoReparto(string Nome, string Cognome, int eta) : base(Nome, Cognome, eta)
        {
            base.ferie = 30;
        }

        public override int getStipendio()
        {
            return CapoReparto.pagaOraria * this.giorniLavorati;
        }

        public override string ToString()
        {
            string s = base.ToString();
            return "|Caporeparto| " + s;
        }
    }
}