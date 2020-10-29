using System;

public class Persona {
    
    private object[] pajarosAsignados;
    private int rondasGanadas;

    public void SumarRondas(bool ganador) {
        if (ganador == true)
        {
            rondasGanadas += 1;
        }
    }

    public void RecibirPajaros( ) {
        
    }

    public void SacarPajaros( ) {
        
    }

}