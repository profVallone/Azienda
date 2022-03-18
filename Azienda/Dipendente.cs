using System;

namespace GestioneAzienda
{
    public abstract class Dipendente: IComparable
    {
        protected string nome;
        protected string cognome;
        protected int eta;
        protected DateTime data;
        protected int ferie;
        protected int giorniLavorati;


        public Dipendente(string Nome, string Cognome, int eta)
        {
            this.nome = Nome;
            this.cognome = Cognome;
            this.eta = eta;
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
            this.giorniLavorati += g; 
        }

        public string getCognome()
        {
            return this.cognome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public bool prendiFerie(int g)
        {
            Console.WriteLine("Il dipendente {0} {1} ha richiesto {2} ferie", this.nome, this.cognome, g);
            if (g > this.ferie)
                throw new FerieNonSufficienti("Hai richiesto troppe ferie!");
            this.ferie -= g;
            return true;
        }

        public bool cediFerie(Dipendente d, int g)
        {
            if (this.GetType() != d.GetType())
                throw new GradoDipendentiErrato("Dipendente non dello stesso grado!");
            try 
            { 
                this.prendiFerie(g);
            }
            catch(FerieNonSufficienti ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            d.aggiungiFerie(g);
            return true;
        }

        public override string ToString()
        {
            return nome + " " + cognome + " eta' " + eta + " giorni lavorativi " 
                + giorniLavorati + " stipendio " + getStipendio() + " Ferie " + ferie;     
        }

        public int CompareTo(object obj)
        {
            Dipendente d = obj as Dipendente;
            if (this.eta > d.eta)
                return 1;
            if (this.eta < d.eta)
                return -1;
            return 0;

        }
    }


}