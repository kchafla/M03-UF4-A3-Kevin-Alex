public class Ronda{
    
    //Comparamos los pajaros para ver quien ha ganado.
    public int CompararPajaros(int pj1, int pj2) {
        if (pj1 > pj2) {
            return 1;             
        } else if(pj1 < pj2) {
            return 2;
        } else {
            return 3;
        }
    }
}