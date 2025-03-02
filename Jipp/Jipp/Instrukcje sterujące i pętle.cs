using System;

class Program
{
	static void Main()
	{
		int n1 = 10;
		int n2 = 20;

		if (n1 > n2)
		{
			Console.WriteLine("n1 jest większe od n2");
		}
		else if (n1 < n2)
		{
			Console.WriteLine("n1 jest mniejsze od n2");
		}
		else
		{
			Console.WriteLine("n1 jest równe n2");
		}

		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine("C#");
		}

		int count = 0;
		while (count < 10)
		{
			Console.WriteLine("C#");
			count++;
		}

		int n = 10;
		for (int i = 0; i <= n; i++)
		{
			if (i % 2 == 0)
			{
				Console.WriteLine($"{i} - Parzysta");
			}
			else
			{
				Console.WriteLine($"{i} - Nieparzysta");
			}
		}

		int rows = 5;
		for (int i = 1; i <= rows; i++)
		{
			for (int j = 1; j <= i; j++)
			{
				Console.Write("* ");
			}
			Console.WriteLine();
		}

		int exam = 57;

		if (exam < 0 || exam > 100)
		{
			Console.WriteLine("Wartość poza zakresem.");
		}
		else if (exam <= 39)
		{
			Console.WriteLine("Ocena Niedostateczna");
		}
		else if (exam <= 54)
		{
			Console.WriteLine("Ocena Dopuszczająca");
		}
		else if (exam <= 69)
		{
			Console.WriteLine("Ocena Dostateczna");
		}
		else if (exam <= 84)
		{
			Console.WriteLine("Ocena Dobra");
		}
		else if (exam <= 98)
		{
			Console.WriteLine("Ocena Bardzo Dobra");
		}
		else
		{
			Console.WriteLine("Ocena Celująca");
		}
	}
}
