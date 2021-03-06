namespace GestioneAzienda
{
    public class Dirigente : Dipendente
    {
        private static readonly int pagaOraria = 200;

        public Dirigente(string Nome, string Cognome, int eta) : base(Nome, Cognome, eta)
        {
            base.ferie = 40;
        }
        public override int getStipendio()
        {
            return Dirigente.pagaOraria * this.giorniLavorati;
        }

        public override string ToString()
        {
            string s = base.ToString();
            return "|Dirigente| " + s;
        }

    }
}