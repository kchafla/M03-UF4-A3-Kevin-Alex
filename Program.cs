using System;

class MainClass {
  public static void Main () {
    Pajaro rojo = new Pajaro();
    rojo.CrearPajaro("Red", "cardenal", "ninguno", 2);
    Pajaro amarillo = new Pajaro();
    amarillo.CrearPajaro("Chuck", "canario", "velocidad", 23);
    Pajaro azul1 = new Pajaro();
    azul1.CrearPajaro("Jay", "azulejo", "dividirse", 64);
    Pajaro azul2 = new Pajaro();
    azul2.CrearPajaro("Jake", "azulejo", "dividirse", 64);
    Pajaro azul3 = new Pajaro();
    azul3.CrearPajaro("Jim", "azulejo", "dividirse", 64);
    Pajaro verde = new Pajaro();
    verde.CrearPajaro("Hal", "tucan", "bumerang", 45);
    Pajaro blanco = new Pajaro();
    blanco.CrearPajaro("Bomb", "cuervo", "explotar", 67);
    Pajaro negro = new Pajaro();
    negro.CrearPajaro("Matilda", "gallina", "huevo explosivo", 91);
    Pajaro naranja = new Pajaro();
    naranja.CrearPajaro("Bubbles", "gorrion", "hincharse", 13);
    Pajaro rosa = new Pajaro();
    rosa.CrearPajaro("Stella", "cacatua Galah", "burbujas", 31);
    Pajaro rojoGordo = new Pajaro();
    rojoGordo.CrearPajaro("Terence", "cardenal", "gordo", 44);

    Jugador jugador1 = new Jugador();
    Jugador jugador2 = new Jugador();
  }
}