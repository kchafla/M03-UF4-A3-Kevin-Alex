using System;

class MainClass {
  public static void Main () {
    Pajaro[] todospajaros = {
      new Pajaro("Red", "cardenal", "ninguno", 2),
      new Pajaro("Chuck", "canario", "velocidad", 23),
      new Pajaro("Jay", "azulejo", "dividirse", 64),
      new Pajaro("Jake", "azulejo", "dividirse", 64),
      new Pajaro("Jim", "azulejo", "dividirse", 64),
      new Pajaro("Hal", "tucan", "bumerang", 45),
      new Pajaro("Bomb", "cuervo", "explotar", 67),
      new Pajaro("Matilda", "gallina", "huevo explosivo", 91),
      new Pajaro("Bubbles", "gorrion", "hincharse", 13),
      new Pajaro("Stella", "cacatua Galah", "burbujas", 31),
      new Pajaro("Terence", "cardenal", "gordo", 44),
    };

    Partida partida = new Partida();
    Ronda ronda = new Ronda();
    int cuantosPajaros = 0;

    do {
      Console.WriteLine("Con cuantos pajaros vas a jugar? (1, 3 o 5)");
      cuantosPajaros = Convert.ToInt32(Console.ReadLine());

      if (cuantosPajaros == 1 || cuantosPajaros == 3 || cuantosPajaros == 5) {
        partida.EmpezarPartida(cuantosPajaros);
        Jugador jugador1 = new Jugador();
        Jugador jugador2 = new Jugador();

        Random rand = new Random();
        for (int n = 0; n < partida.GetPajarosRepartir(); n++) {
          int pajarojugador1 = rand.Next(todospajaros.Length);
          jugador1.RecibirPajaros(todospajaros[pajarojugador1], n);

          int pajarojugador2 = rand.Next(todospajaros.Length);
          jugador2.RecibirPajaros(todospajaros[pajarojugador2], n);
        }

        while (cuantosPajaros != 0) {
          Console.WriteLine("\nJugador 1, que pajaro quieres sacar?");
          Pajaro[] j1pajaros = jugador1.GetPajaros();
          for (int n = 1; n <= cuantosPajaros; n++) {
            if (n == cuantosPajaros) {
              Console.Write(j1pajaros[n-1].GetNombre() + "(" + n + ").\n");
            } else {
              Console.Write(j1pajaros[n-1].GetNombre() + "(" + n + "), ");
            }
          }
          int sacar1 = 0;
          do {
            sacar1 = Convert.ToInt32(Console.ReadLine());
            if (!(sacar1 > 0 && sacar1 <= cuantosPajaros)) {
              Console.WriteLine("\nEscribe un numero de las opciones mostradas!!");
            }
          } while (!(sacar1 > 0 && sacar1 <= cuantosPajaros));

          Console.WriteLine("\nJugador 2, que pajaro quieres sacar?");
          Pajaro[] j2pajaros = jugador2.GetPajaros();
          for (int n = 1; n <= cuantosPajaros; n++) {
            if (n == cuantosPajaros) {
              Console.Write(j2pajaros[n-1].GetNombre() + "(" + n + ").\n");
            } else {
              Console.Write(j2pajaros[n-1].GetNombre() + "(" + n + "), ");
            }
          }
          // LAS DOS SIGUIENTES LINEAS SON LA V4!!
          int sacar2 = rand.Next(1, cuantosPajaros+1);
          Console.WriteLine("Saco el pajaro numero " + sacar2 + "!!");

          /* ESTO ES PARA LA VERSION 3!!
          int sacar2 = 0;
          do {
            sacar2 = Convert.ToInt32(Console.ReadLine());
            if (!(sacar2 > 0 && sacar2 <= cuantosPajaros)) {
              Console.WriteLine("\nEscribe un numero de las opciones mostradas!!");
            }
          } while (!(sacar2 > 0 && sacar2 <= cuantosPajaros));
          */

          int puntuacion = ronda.CompararPajaros(jugador1.SacarPajaros(sacar1-1, cuantosPajaros).GetEnergia(), jugador2.SacarPajaros(sacar2-1, cuantosPajaros).GetEnergia());
          if (puntuacion == 1) {
            jugador1.SumarRondas(true);
            Console.WriteLine("\nHa ganado jugador 1! (" + jugador1.GetRondasGanadas() + " - " + jugador2.GetRondasGanadas() + ")");
          } else if (puntuacion == 2) {
            jugador2.SumarRondas(true);
            Console.WriteLine("\nHa ganado jugador 2! (" + jugador1.GetRondasGanadas() + " - " + jugador2.GetRondasGanadas() + ")");
          } else if (puntuacion == 3) {
            Console.WriteLine("\nEmpate! (" + jugador1.GetRondasGanadas() + " - " + jugador2.GetRondasGanadas() + ")");
          }
          cuantosPajaros--;
        }

        int rondasGanadasJ1 = jugador1.GetRondasGanadas();
        int rondasGanadasJ2 = jugador2.GetRondasGanadas();

        if (rondasGanadasJ1 > rondasGanadasJ2) {
          Console.WriteLine("\nEl jugador 1 ha ganado la partida!!!\n");
        } else if (rondasGanadasJ1 < rondasGanadasJ2) {
          Console.WriteLine("\nEl jugador 2 ha ganado la partida!!!\n");
        } else if (rondasGanadasJ1 == rondasGanadasJ2) {
          Console.WriteLine("\nLa partida ha acabado en empate!!!\n");
        }

      } else {
        Console.WriteLine("\nEscribe 1, 3 o 5!!!\n");
      }

    } while (cuantosPajaros != 1 || cuantosPajaros != 3 || cuantosPajaros != 5);
  }
}