using System;

public class Persona {
    
    private string[] pajarosAsignados;
    private int rondasGanadas;

    public void SumarRondas(bool ganador) {
        if (ganador == true) {
            rondasGanadas += 1;
        }
    }

    public void RecibirPajaros(string pajaroAsignado) {
        for (int n = 0; n < pajarosAsignados.Length; n++) {
            if (String.Equals(pajarosAsignados[n], "")) {
                pajarosAsignados[n] = pajaroAsignado;
            }
        }
    }

    public string SacarPajaros(int posicion) {
        string pajaroParaSacar = "";
        if (!String.Equals(pajarosAsignados[posicion], "")) {
            pajaroParaSacar = pajarosAsignados[posicion];
            pajarosAsignados[posicion] = "";
        }
        return pajaroParaSacar;
    }
}