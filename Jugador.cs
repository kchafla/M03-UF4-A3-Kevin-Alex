public class Jugador {
    
    private Pajaro[] pajarosAsignados = new Pajaro[6];
    private int rondasGanadas;

    public void SumarRondas(bool ganador) {
        if (ganador == true) {
            rondasGanadas += 1;
        }
    }

    public void RecibirPajaros(Pajaro pajaroAsignado, int posicion) {
        pajarosAsignados[posicion] = pajaroAsignado;
    }
    
    public Pajaro SacarPajaros(int posicion, int cuantosPajaros) {
        Pajaro pajaroParaSacar = pajarosAsignados[posicion];

        if (cuantosPajaros != 1) {
            for (int i = posicion; i < cuantosPajaros; i++) {
                pajarosAsignados[i] = pajarosAsignados[i+1];
            }
        }
        
        return pajaroParaSacar;
    }

    public Pajaro[] GetPajaros() {
        return pajarosAsignados;
    }

    public int GetRondasGanadas() {
        return rondasGanadas;
    }
}