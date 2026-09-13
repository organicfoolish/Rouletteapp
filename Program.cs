using System;
using System.Security.Cryptography; 

namespace Roulette  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titulo = @"_\/_ Rouletteapp _\/_"; //todo lo que haya después de @"" será string
            Console.WriteLine(titulo); //ver como implementar una animacion en titulo

            Console.WriteLine("Ingrese su nombre: ");
            string nombreJugador = Console.ReadLine() ?? ""; //  ?? "" -> evitar romper el flujo con un nulo
            Console.WriteLine("Su monto inicial es de $300, buen juego!");
            Console.WriteLine("Presione cualquier tecla para continuar. . .");
            Console.ReadKey(); // lee tecla de entrada 
            Jugador jugador = new Jugador(nombreJugador, 300m);
            Ruleta ruleta = new Ruleta();
            string[] opcionesMenu = ["Girar ruleta","Salir",];
            MenuPrincipal menu = new MenuPrincipal(titulo,opcionesMenu);

            menu.mostrar_menu();
        }
    }
}
