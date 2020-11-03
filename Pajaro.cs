public class Pajaro {
    
    private string nombre;
    private string especie;
    private string poder;
    private int energia;

    //Constructor de pajaros.
    public Pajaro(string newNombre, string newEspecie, string newPoder, int newEnergia) {
        nombre = newNombre;
        especie = newEspecie;
        poder = newPoder;
        energia = newEnergia;
    }

    //Recibimos el valor de la energia de un pajaro.
    public int GetEnergia() {
        return energia;
    }

    //Recibimos el nombre del pajaro.
    public string GetNombre() {
        return nombre;
    }
}