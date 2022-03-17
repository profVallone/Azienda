using System;

namespace GestioneAzienda
{
    class Program
    {
        static void Main(string[] args)
        {
            Azienda az = new Azienda();
            az.add(new Operaio("Mario", "Rossi", 38, "02-03-2001"));
            az.add(new CapoReparto("Mario", "Bianchi", 25, "02-03-2015"));
            az.add(new Dirigente("Franco", "Verdi", 54, "02-03-1981"));
            az.add(new Operaio("Francesco", "Salvi", 20, "02-03-2010"));
            az.add(new Operaio("Mattia", "Verdi", 34, "02-03-1989"));
            az.add(new CapoReparto("Maria", "Franca", 34, "02-03-1989"));
            Console.WriteLine(az);
            az.giorniRandom();
            Console.WriteLine(az);
            Dipendente d = az.cercaDipendente("Rossi");
            Console.WriteLine(d);
            az.promuovi(d);
            Console.WriteLine(d);
            d = az.cercaDipendente("Franca");
            Console.WriteLine(d);
            az.declassa(d);
            Console.WriteLine(d);







        }
    }
}
