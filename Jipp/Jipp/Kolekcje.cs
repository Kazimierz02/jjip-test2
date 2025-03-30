using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		string[] colors = { "Niebieski", "Zielony", "Żółty", "Czerwony" };
		Console.WriteLine($"Mój pierwszy kolor to: {colors[0]}");
		Console.WriteLine($"Mój ostatni kolor to: {colors[colors.Length - 1]}");

		int[] numbers = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

		Console.WriteLine("\nPętla for:");
		for (int i = 0; i < numbers.Length; i++)
		{
			Console.WriteLine($"Liczba: {numbers[i]}");
		}

		Console.WriteLine("\nPętla foreach:");
		foreach (int num in numbers)
		{
			Console.WriteLine($"Liczba: {num}");
		}

		Console.WriteLine("\nPętla while:");
		int index = 0;
		while (index < numbers.Length)
		{
			Console.WriteLine($"Liczba: {numbers[index]}");
			index++;
		}

		List<string> fruits = new List<string> { "Pomidor", "Jabłko", "Marchewka", "Gruszka" };
		Console.WriteLine("\nLista owoców przed usunięciem:");
		Console.WriteLine(string.Join(", ", fruits));

		fruits.RemoveAt(0);
		fruits.RemoveAt(fruits.Count - 1);

		Console.WriteLine("\nLista owoców po usunięciu:");
		Console.WriteLine(string.Join(", ", fruits));
	}
}
