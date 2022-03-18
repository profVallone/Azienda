namespace GestioneAzienda
{
    public class Operaio : Dipendente
    {
        private static readonly int pagaOraria = 60;
        
        public Operaio(string Nome, string Cognome, int eta) : base(Nome, Cognome, eta)        {
            base.ferie = 25;
        }

        public override int getStipendio()
        {
            return Operaio.pagaOraria*this.giorniLavorati;
        }

        public override string ToString()
        {
            string s = base.ToString();
            return "|Operaio| " + s;
        }
    }
}