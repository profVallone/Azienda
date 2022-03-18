using System;
using System.Collections.Generic;
using System.Linq;

namespace GestioneAzienda
{
    public class Azienda
    {
        List<Dipendente> dipendenti;

        public Azienda()
        {
            this.dipendenti = new List<Dipendente>();
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

        public override string ToString()
        {
            string s = "";
            foreach (Dipendente d in dipendenti)
            {
                s += d.ToString() + "\n";
            }
            return s;
        }

        public List<Dipendente> dipendentiMaxStipendio()
        {
            List<Dipendente> lRis = new List<Dipendente>();
            Dipendente dMax = null;
            foreach(Dipendente d in dipendenti)
            {
                if (lRis.Find(x => x.GetType() == d.GetType()) == null)
                {
                    dMax = d;
                    foreach (Dipendente tmp in dipendenti)
                    {
                        if (d.GetType() == tmp.GetType())
                        {
                            dMax = tmp.getStipendio() > dMax.getStipendio() ? tmp : dMax;
                        }
                    }
                    lRis.Add(dMax);
                }
            }
            return lRis;
        }

        public void prendiFerieRandom()
        {
            Random r = new Random();
            foreach (Dipendente d in dipendenti)
            {
                try
                {
                    d.prendiFerie(r.Next(1, 100));
                }catch(FerieNonSufficienti ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void stampaInOrdine()
        {
            dipendenti.Sort();
            foreach(Dipendente d in dipendenti)
            {
                Console.WriteLine(d);
            }
        }



        public void cediFerieRandom()
        {
            
            Random r = new Random();
            foreach (Dipendente d in dipendenti)
            {
                Console.WriteLine("Cessione ferie da --->");
                Console.WriteLine(d);
                Dipendente tmp = dipendenti.ElementAt<Dipendente>(r.Next(1, dipendenti.Count));
                try
                {
                    Console.WriteLine("---> verso --->");
                    Console.WriteLine(tmp);
                    d.cediFerie(tmp, r.Next(1, 100));
                    Console.WriteLine(tmp);
                }
                catch (GradoDipendentiErrato ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("\n");
            }
        }
    }
}