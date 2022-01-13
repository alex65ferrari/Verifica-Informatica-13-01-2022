using System;

namespace treno
{
    class Program
    {
        static void Main(string[] args)
        {
            // * Creo passeggeri1
            Passeggeri passeggeri1 = new Passeggeri(){
                codtreno = 1,
                tipo = "regionale",
                nome = "passeggeri1",
                costo = 100000,
                numvagoni = 24,
                alimentazione = ""
            };

            // * Creo merci2
            Merci merci2 = new Merci(){
                codtreno = 2,
                tipo = "nazionale",
                nome = "merci2",
                costo = 100000,
                numvagoni = 37,
                alimentazione = ""
            };

            // * Calcolo i costi del mezzo
            Console.WriteLine("\nCosto del mezzo: {0}, {1} \n", passeggeri1.nome, passeggeri1.CalcolaCostoMezzo());
            Console.WriteLine("Costo del mezzo: {0}, {1} \n", merci2.nome, merci2.CalcolaCostoMezzo());

            // * Prendo in input il numero di mk percorsi
            Console.WriteLine("Inserire il numero di km percorsi: \n");
            int distanzaInKm = -1; //-1 indica che il valore non è valido
            do{
                try { //Controllo se l'input è un numero.
                    distanzaInKm = Convert.ToInt32(Console.ReadLine());
                } catch { //Se non lo è gestisco l'errore...
                    Console.WriteLine("Inserire un numero.");
                    distanzaInKm = -1;
                } //...E ripeto la richiesta
            } while (distanzaInKm < 0);

            // * Calcolo il costi per l'utlizzo
            Console.WriteLine("\nCosto per l'utilizzo: {0}, {1} \n", passeggeri1.nome, passeggeri1.CalcolaCostoUtilizzo(distanzaInKm));
            Console.WriteLine("Costo per l'utilizzo: {0}, {1} \n", merci2.nome, merci2.CalcolaCostoUtilizzo(distanzaInKm));

            // * Calcolo i costi totali
            Console.WriteLine("Costo totale: {0}, {1} \n", passeggeri1.nome, passeggeri1.CalcolaCostoMezzo() + passeggeri1.CalcolaCostoUtilizzo(distanzaInKm));
            Console.WriteLine("Costo totale: {0}, {1} \n", merci2.nome, merci2.CalcolaCostoMezzo() + merci2.CalcolaCostoUtilizzo(distanzaInKm));
        }
    }
}
