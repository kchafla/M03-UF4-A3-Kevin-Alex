public class Jugador {
    
    private Pajaro[] pajarosAsignados = new Pajaro[6];
    private int rondasGanadas;

    //Sumamos las rondas.
    public void SumarRondas(bool ganador) {
        if (ganador == true) {
            rondasGanadas += 1;
        }
    }

    //Añadir un pajaro a la lista.
    public void RecibirPajaros(Pajaro pajaroAsignado, int posicion) {
        pajarosAsignados[posicion] = pajaroAsignado;
    }

    //Seleccionar un pajaro y quitarlo de la lista.
    public Pajaro SacarPajaros(int posicion, int cuantosPajaros) {
        Pajaro pajaroParaSacar = pajarosAsignados[posicion];

        if (cuantosPajaros != 1) {
            for (int i = posicion; i < cuantosPajaros; i++) {
                pajarosAsignados[i] = pajarosAsignados[i+1];
            }
        }
        
        return pajaroParaSacar;
    }

    //Mostrar la lista de los pajaros.
    public Pajaro[] GetPajaros() {
        return pajarosAsignados;
    }

    //Mostramos las rondas.
    public int GetRondasGanadas() {
        return rondasGanadas;
    }
}