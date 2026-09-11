using System; //Contexto principal del programa :) 

namespace Roulette  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titulo = "Ruleta :)";
            Console.WriteLine(titulo);

            MenuPrincipal menu = new MenuPrincipal();
            menu.MostrarMenu();



        }
    }
}
