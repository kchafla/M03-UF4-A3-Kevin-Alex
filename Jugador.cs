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
        Pajaro pajaroParaSacar = pajarosAsignados[posicion];

        for (int i = posicion-1; i < 4; i++) {
            pajarosAsignados[i] = pajarosAsignados[i + 1];
        }
        
        return pajaroParaSacar;
    }

    public Pajaro[] GetPajaros() {
        return pajarosAsignados;
    }
}