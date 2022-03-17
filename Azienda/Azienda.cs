using System;
using System.Collections.Generic;

namespace GestioneAzienda
{
    public class Azienda
    {
        List<Dipendente> dipendenti;

        public Azienda()
        {
            this.dipendenti = new List<Dipendente>();
        }

        public void promuovi(Dipendente d)
        {
            if (d is Operaio)
            {
                d = (Dipendente)d;

                return;
            }
            if (d is CapoReparto)
            {
                d = (Dirigente)d;
                return;
            }
        }

        internal void add(Dipendente d)
        {
            dipendenti.Add(d);
        }

        internal void giorniRandom()
        {
            Random r = new Random();
            foreach(Dipendente d in dipendenti)
            {
                d.addGiorni(r.Next(1, 100));
            }
        }

        public void declassa(Dipendente d)
        {
            if (d is CapoReparto)
            {
                d = (Operaio)d;
                return;
            }
            if (d is Dirigente) 
            { 
                d = (CapoReparto)d;
                return;
            }
        }

        public void cessioneFerie(Dipendente d1, Dipendente d2, int g)
        {
            if (d1.GetType() == d2.GetType())
                if (d1.getFerie() > g)
                {
                    d2.aggiungiFerie(g);
                    d1.prendiFerie(g);

                }
        }

        public List<Dipendente> cercaDipendente(string nome, string cognome)
        {
            return dipendenti.FindAll(x => x.getNome() == nome || x.getCognome() == cognome);
        }
        public Dipendente cercaDipendente(string cognome)
        {
            return dipendenti.Find(x => x.getCognome() == cognome);
        }
        public override string ToString()
        {
            string s = "";
            foreach (Dipendente d in dipendenti)
            {
                s += d.ToString() + "\n";
            }
            return s;
        }
    }
}