using System;
using System.Collections.Generic;

namespace GestioneAzienda
{
    class Program
    {
        static void Main(string[] args)
        {
            Azienda az = new Azienda();
            az.add(new Operaio("Mario", "Rossi", 38, "02-03-2001"));
            az.add(new CapoReparto("Mario", "Bianchi", 25, "02-03-2015"));
            az.add(new Dirigente("Franco", "Verdi", 54, "02-03-1992"));
            az.add(new Operaio("Francesco", "Salvi", 20, "02-03-2010"));
            az.add(new Operaio("Mattia", "Verdi", 34, "02-03-1989"));
            az.add(new CapoReparto("Maria", "Franca", 34, "02-03-1989"));
            az.add(new Dirigente("Giuseppe", "Bianchini", 64, "02-03-2005"));
            
            Console.WriteLine("-------Azienda-------------------------");
            //inizializza in maniera Random i giorni lavorativi di ogni dipendente
            //da 1 a 100
            //attraverso il metodo
            //addGiorni(int g); della classe Dipendente
            az.giorniRandom();
            Console.WriteLine(az);
            
            Console.WriteLine("-------Richiesta ferie-------------------------");
            //per ogni dipendente vengono richiesti giorni di ferie random
            //tra 1 e 50
            //attraverso il metodo
            //prendiFerie(int g); della classe Dipendente
            az.prendiFerieRandom();
           
            Console.WriteLine("-------Cessione ferie-------------------------");
            //per ogni dipendente vengono ceduti giorni di ferie random tra 1 e 50
            //ad un altro dipendente scelto a caso
            //attraverso il metodo
            //cediFerie(Dipendente d, int g); della classe Dipendente
            az.cediFerieRandom();

            Console.WriteLine("-------Dipendenti guadagno massimo-------------------------");
            foreach(Dipendente d in az.dipendentiMaxStipendio())
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("-------Dipendenti in ordine di età-------------------------");
            az.stampaInOrdine();
        }
    }
}
