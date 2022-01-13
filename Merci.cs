using System;

namespace treno {
    class Merci : Treni {
        // * Classe per i treni merci
        public int numvagoni { get; set; }
        public string alimentazione { get; set; }
        new public double CalcolaCostoMezzo(){ //Faccio un override del metodo ereditato
            return costo + (costo * 35 / 100); //Aggiungo del 35% il costo
        }
        new public double CalcolaCostoUtilizzo(int kmPercorsi){ //Faccio un override del metodo ereditato
            return kmPercorsi * 100; //Aggiungo il costo specifico del treno merci
        }
    }
}