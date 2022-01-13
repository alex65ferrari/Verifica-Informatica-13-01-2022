using System;

namespace treno {
    class Treni {
        // * Classe di base Treni
        public int codtreno { get; set; }
        public string tipo { get; set; }
        public string nome { get; set; }
        public double costo { get; set; }

        //Calcolo il costo del mezzo
        public double CalcolaCostoMezzo(){
            return costo;
        }

        //Calcolo il costo per l'utilizzo
        public double CalcolaCostoUtilizzo(int kmPercorsi){
            return kmPercorsi * 0;
        }
    }
}