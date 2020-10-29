using System;

public class Pajaro {
    
    private string nombre;
    private string especie;
    private string poder;
    private int energia;

    public void CrearPajaro(string newNombre, string newEspecie, string newPoder, int newEnergia){
        nombre = newNombre;
        especie = newEspecie;
        poder = newPoder;
        energia = newEnergia;
    }
}