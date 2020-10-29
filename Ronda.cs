using System;

public class Ronda{
    
    int numeroRonda;

    public int CompararPajaros(Pajaro pj1, Pajaro pj2) {
        if (pj1.GetEnergia() > pj2.GetEnergia()) {
            return 1;             
        }else if(pj1.GetEnergia() < pj2.GetEnergia()) {
            return 2;
        }else {
            return 3;
        }
    }
}