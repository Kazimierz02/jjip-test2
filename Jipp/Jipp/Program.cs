using System;

namespace MyConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Podaj swoje imię:");
			var name = Console.ReadLine();

			Console.WriteLine("Hello " + name);

			int result = 5 + 9;
			Console.WriteLine("Wynik działania 5 + 9 to: " + result);
		}
	}
}
