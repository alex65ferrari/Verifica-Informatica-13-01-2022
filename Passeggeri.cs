using System;

namespace treno {
    class Passeggeri : Treni {
        // * Classe per i treni passeggeri
        public int numvagoni { get; set; }
        public string alimentazione { get; set; }
        new public double CalcolaCostoMezzo(){ //Faccio un override del metodo ereditato
            return costo + (costo * 25 / 100); //Aumento del 25% il costo
        }
        new public double CalcolaCostoUtilizzo(int kmPercorsi){ //Faccio un override del metodo ereditato
            return kmPercorsi * 150; //Aggiungo il costo specifico del treno passeggeri
        }
    }
}