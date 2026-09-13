using System
namespace Roulette
{
	public class MenuPrincipal
	{
        private readonly string titulo;
        private readonly string[] opcionesMenu;
        public MenuPrincipal(string titulo,string[] opcionesMenu)
		{
			this.titulo = titulo;
			this.opcionesMenu = opcionesMenu;
		}
		public void mostrar_menu()
		{

			bool seguirJugando
			while (seguirJugando)
			{
				Console.Clear();
				Console.WriteLine(titulo);
				Console.WriteLine($"Bienvenido {nombreJugador}")
                //.Lenght recorre todos los elementos del arreglo *sin parentesis*
                for (int iterador = 0; iterador < opcionesMenu.Length; iterador++)
				{
					Console.WriteLine($"{iterador + 1} {opcionesMenu[iterador]}") // $ funciona como fstrings de python
				}
				string opcion = Console.ReadLine() ?? ""; //  ?? "" -> evitar romper el flujo con un nulo
				switch (opcion)
				{
					case "0":   //girar
						seguirJugando = true;
						break;
					case "1":     //salir
						seguirJugando = false;
						Console.WriteLine("Saliendo. . .");
                        break;
					default:
						Console.WriteLine("Ingrese una opción válida.");
						Console.ReadLine();

				}
			}
        }	
	}
}
