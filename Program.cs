using System;

class MainClass {
  public static void Main () {
    Pajaro[] todospajaros = new Pajaro[11];
    todospajaros[0] = new Pajaro();
    todospajaros[0].CrearPajaro("Red", "cardenal", "ninguno", 2);
    todospajaros[1] = new Pajaro();
    todospajaros[1].CrearPajaro("Chuck", "canario", "velocidad", 23);
    todospajaros[2] = new Pajaro();
    todospajaros[2].CrearPajaro("Jay", "azulejo", "dividirse", 64);
    todospajaros[3] = new Pajaro();
    todospajaros[3].CrearPajaro("Jake", "azulejo", "dividirse", 64);
    todospajaros[4] = new Pajaro();
    todospajaros[4].CrearPajaro("Jim", "azulejo", "dividirse", 64);
    todospajaros[5] = new Pajaro();
    todospajaros[5].CrearPajaro("Hal", "tucan", "bumerang", 45);
    todospajaros[6] = new Pajaro();
    todospajaros[6].CrearPajaro("Bomb", "cuervo", "explotar", 67);
    todospajaros[7] = new Pajaro();
    todospajaros[7].CrearPajaro("Matilda", "gallina", "huevo explosivo", 91);
    todospajaros[8] = new Pajaro();
    todospajaros[8].CrearPajaro("Bubbles", "gorrion", "hincharse", 13);
    todospajaros[9] = new Pajaro();
    todospajaros[9].CrearPajaro("Stella", "cacatua Galah", "burbujas", 31);
    todospajaros[10] = new Pajaro();
    todospajaros[10].CrearPajaro("Terence", "cardenal", "gordo", 44);

    Jugador jugador1 = new Jugador();
    Jugador jugador2 = new Jugador();

    Random rand = new Random();

    Partida partida = new Partida();
    Console.WriteLine("Con cuantos pajaros vas a jugar? (1, 3 o 5)");
    int cuantosPajaros = Convert.ToInt32(Console.ReadLine());
    if (cuantosPajaros == 1 || cuantosPajaros == 3 || cuantosPajaros == 5) {
      partida.EmpezarPartida(cuantosPajaros);

      for (int n = 0; n < partida.GetPajarosRepartir(); n++) {
        int pajarojugador1 = rand.Next(todospajaros.Length);
        jugador1.RecibirPajaros(todospajaros[pajarojugador1], n);

        int pajarojugador2 = rand.Next(todospajaros.Length);
        jugador2.RecibirPajaros(todospajaros[pajarojugador2], n);
      }

      Ronda ronda = new Ronda();
      for (int r = 0; r < cuantosPajaros; r++) {
        Console.WriteLine("\nJugador 1, que pajaro quieres sacar?");
        Pajaro[] j1pajaros = jugador1.GetPajaros();
        for (int n = 0; n < cuantosPajaros; n++) {
          if (n == cuantosPajaros-1) {
            Console.Write(j1pajaros[n].GetNombre() + ".\n");
          } else {
            Console.Write(j1pajaros[n].GetNombre() + ", ");
          }
        }
        int sacar1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nJugador 2, que pajaro quieres sacar?");
        Pajaro[] j2pajaros = jugador2.GetPajaros();
        for (int n = 0; n < cuantosPajaros; n++) {
          if (n == cuantosPajaros-1) {
            Console.Write(j2pajaros[n].GetNombre() + ".\n");
          } else {
            Console.Write(j2pajaros[n].GetNombre() + ", ");
          }
        }
        int sacar2 = Convert.ToInt32(Console.ReadLine());

        int puntuacion = ronda.CompararPajaros(jugador1.SacarPajaros(sacar1-1).GetEnergia(), jugador2.SacarPajaros(sacar2-1).GetEnergia());
        if (puntuacion == 1) {
          Console.WriteLine("\nHa ganado jugador 1!");
          cuantosPajaros--;
          jugador1.SumarRondas(true);
        }else if (puntuacion == 2) {
          Console.WriteLine("\nHa ganado jugador 2!");
          cuantosPajaros--;
          jugador2.SumarRondas(true);
        }else if (puntuacion == 3) {
          Console.WriteLine("\nEmpate!");
        }
      }

    } else {
      Console.WriteLine("Escribe 1, 3 o 5!!!");
    }
  }
}