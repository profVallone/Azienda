using System;

namespace GestioneAzienda
{
    public abstract class Dipendente
    {
        protected string Nome;
        protected string Cognome;
        protected int eta;
        protected DateTime data;
        protected int ferie;
        protected int giorniLavorati;


        public Dipendente(string Nome, string Cognome, int eta, string data)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.eta = eta;
            string[] sl = data.Split("-");
            int y = Int32.Parse(sl[2]);
            int m = Int32.Parse(sl[1]);
            int d = Int32.Parse(sl[0]);
            this.data = new DateTime(y,m,d);
            this.giorniLavorati = 0;
        }

        public abstract int getStipendio();

        public void aggiungiFerie(int g)
        {
            this.ferie += g;
        }

        public int getFerie()
        {
            return this.ferie;
        }

        public void addGiorni(int g)
        {
            if (g < 1)
                throw new ParametroErrato(g, "Non puoi aggiungere giorni con valore negativo!");
            this.giorniLavorati += g; 
        }

        internal string getCognome()
        {
            return this.Cognome;
        }

        internal string getNome()
        {
            return this.Nome;
        }

        public bool prendiFerie(int g)
        {
            if (g < 1)
                throw new ParametroErrato(g);
            if (g > this.ferie)            
                return false;
            this.ferie -= g;
            return true;
        }

        public override string ToString()
        {
            return Nome + " " + Cognome + " eta' " + eta + " giorni lavorativi " 
                + giorniLavorati + " stipendio " + getStipendio();     
        }

    }


}