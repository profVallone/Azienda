using System;
using System.Collections.Generic;

namespace GestioneAzienda
{
    class Program
    {
        static void Main(string[] args)
        {
            Azienda az = new Azienda();
            Dipendente d1 = new Operaio("Mario", "Rossi", 38);
            Dipendente d2 = new CapoReparto("Mario", "Bianchi", 25);
            Dipendente d3 = new Dirigente("Franco", "Verdi", 54);
            Dipendente d4 = new Operaio("Francesco", "Salvi", 20);
            Dipendente d5 = new Operaio("Mattia", "Verdi", 34);
            Dipendente d6 = new CapoReparto("Maria", "Franca", 34);
            Dipendente d7 = new Dirigente("Giuseppe", "Bianchini", 64);
            az.add(d1);
            az.add(d2);
            az.add(d3);
            az.add(d4);
            az.add(d5);
            az.add(d6);
            az.add(d7);
            
            Console.WriteLine("-------Azienda-------------------------");
            //inizializza in maniera Random i giorni lavorativi di ogni dipendente da 1 a 100
            az.giorniRandom();
            Console.WriteLine(az);
            
            Console.WriteLine("-------Richiesta ferie-------------------------");
            //per ogni dipendente vengono richiesti giorni di ferie random tra 1 e 100
            az.prendiFerieRandom();
           
            Console.WriteLine("-------Cessione ferie-------------------------");
            //per ogni dipendente vengono ceduti giorni di ferie random tra 1 e 100
            //ad un altro dipendente scelto a caso
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
