using System;
using System.Linq;

public class Jugador {
    
    private Pajaro[] pajarosAsignados = new Pajaro[5];
    private int rondasGanadas;

    public void SumarRondas(bool ganador) {
        if (ganador == true) {
            rondasGanadas += 1;
        }
    }

    public void RecibirPajaros(Pajaro pajaroAsignado, int posicion) {
        pajarosAsignados[posicion] = pajaroAsignado;
    }

    public Pajaro SacarPajaros(int posicion) {
        Pajaro pajaroParaSacar;

        pajaroParaSacar = pajarosAsignados[posicion];
        pajarosAsignados[posicion] = null;

        return pajaroParaSacar;
    }
}