public class Partida {
    
    //Esto es inutil y lo sabemos.
    private int pajarosRepartir;

    //Empezamos la partida.
    public void EmpezarPartida(int numeroPajaros) {
        pajarosRepartir = numeroPajaros;
    }

    public int GetPajarosRepartir() {
        return pajarosRepartir;
    }
}