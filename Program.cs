using System;
using Jugadores;

namespace clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            var jugador = new Jugador("Juan", 20);

            var arma1 = new Arma("Pistola", 100);
            var arma2 = new Arma("Misil", 150);
            var arma3 = new Arma("Cuchillo", 200);
            
            arma3.Disparar();

            Arma[] armas = {arma1, arma2, arma3};

            foreach (Arma elemento in armas) {
              Console.WriteLine(elemento.Balas);
            }      
            
        }
    }
}
