namespace Jugadores
{
    public class Jugador {
      public string Nombre { get; set; }
      public int Edad { get; set; }

      public Jugador(string Nombre, int Edad) {
        this.Nombre = Nombre;
        this.Edad = Edad;
      }
    }

    public class Arma {
      public string Nombre { get; set; }
      public int Balas { get; set; }
      public Arma(string Nombre, int Balas) {
        this.Nombre = Nombre;
        this.Balas = Balas;
      }

      public void Disparar() {
        --this.Balas;
      }
    }
}
