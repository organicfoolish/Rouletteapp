using System;
using System.Security.Cryptography;           //librerìa donde se encuentra el generador aleatorio
namespace Roulette
{
	public class Ruleta
	{
		private readonly List<int> numerosNegros;
		private readonly List<int> numerosRojos;
		private readonly List<int> cero; // revisar si implemento o no 
		public Ruleta()
		{
			numerosNegros = new List<int> { 2, 4, 6, 8, 10,
				11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
			numerosRojos = new List<int> { 1, 3, 5, 7, 9,
				12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
			cero = new List<int> { 0 };  //  revisar si implemento o no
		}
		private int giro()       //retorna posición de la bola 
		{
			int resultadoDelGiro = RandomNumberGenerator.GetInt32(0, 37); //aleatorio de 0 a 36 
			return resultadoDelGiro
		}
	}
}