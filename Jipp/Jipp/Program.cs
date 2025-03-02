using System;

class Program
{
	static void Main()
	{
		Console.Write("Podaj swoje imię: ");
		string userName = Console.ReadLine();
		Console.WriteLine($"Hello {userName}");

		int sumResult = 5 + 9;
		Console.WriteLine($"Wynik: {sumResult}");

		int number = 30;
		float money = 78.50f;
		string text = "C# jest super!";
		bool isLogged = true;
		char myChar = 'X';
		decimal price = 249.99m;

		Console.WriteLine($"Number: {number}");
		Console.WriteLine($"Money: {money}");
		Console.WriteLine($"Text: {text}");
		Console.WriteLine($"IsLogged: {isLogged}");
		Console.WriteLine($"MyChar: {myChar}");
		Console.WriteLine($"Price: {price}");

		string myAge = "Age: ";
		int wifeAge = 18;
		string ageResult = myAge + wifeAge;
		Console.WriteLine(ageResult);

		bool isTrue = true;
		bool isFalse = false;
		bool isReallyTrue = true;

		bool andResult = isTrue && isFalse;
		bool orResult = isTrue || isReallyTrue;
		bool negativeResult = !isFalse;

		Console.WriteLine($"AND: {andResult}");
		Console.WriteLine($"OR: {orResult}");
		Console.WriteLine($"NEGATION: {negativeResult}");

		int a = 8;
		int b = 20;

		int addition = a + b;
		int subtraction = a - b;
		int division = a / b;
		int multiplication = a * b;
		int modulo = a % b;

		Console.WriteLine($"Addition: {addition}");
		Console.WriteLine($"Subtraction: {subtraction}");
		Console.WriteLine($"Division: {division}");
		Console.WriteLine($"Multiplication: {multiplication}");
		Console.WriteLine($"Modulo: {modulo}");

		string part1 = "Kasia ";
		string part2 = "kocha ";
		string part3 = "zwierzęta.";
		string sentence = part1 + part2 + part3;

		Console.WriteLine(sentence);
	}
}
