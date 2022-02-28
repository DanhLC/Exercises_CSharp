using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		/// <summary>
		/// Main void
		/// </summary>
		/// <param name="args">arguments</param>
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Here we have some function for you to choose. \n" +
					"1. Check prime number \n" +
					"2. Get list prime number \n" +
					"3. Get list fibonacci \n" +
					"4. Calculate factorial \n" +
					"5. Check palindrome string \n" +
					"6. Get greatest common divisor \n" +
					"7. Get least common multiple \n" +
					"8. Calculate a quadratic equation \n" +
					"9. Exit (press Enter twice) \n" +
					"Please choose a number to excute a function: ");
				var numberFunction = int.Parse(Console.ReadLine());
				switch (numberFunction)
				{
					// Check prime number
					case 1:
						Console.Write("Please input a number to check: ");
						var inputNumber = int.Parse(Console.ReadLine());

						if (IsPrimeNumber(inputNumber)) Console.WriteLine("This is a prime number.\n");
						else Console.WriteLine("This is not a prime number.\n");
						Main(args);
						break;

					// Get list prime number
					case 2:
						Console.Write("Please input a number to get list prime (from 0 to your input number): ");
						inputNumber = int.Parse(Console.ReadLine());
						Console.WriteLine("Here is your list prime number (from 0 to {0}):", inputNumber);

						foreach (var item in GetListPrimeNumber(inputNumber))
						{
							Console.Write("{0} \t", item);
						}
						Console.WriteLine("\n");
						Main(args);
						break;

					// Get list fibonacci
					case 3:
						Console.Write("Please input a number to get list fibonacci number (from 0 to your input number): ");
						inputNumber = int.Parse(Console.ReadLine());
						Console.WriteLine("Here is your list fibonacci number (from 0 to {0}):", inputNumber);

						foreach (var item in GetListFibonacci(inputNumber))
						{
							Console.Write("{0} \t", item);
						}
						Console.WriteLine("\n");
						Main(args);
						break;

					// Calculate factorial
					case 4:
						Console.Write("Please input a number to calculate factorial: ");
						inputNumber = int.Parse(Console.ReadLine());
						Console.WriteLine("Here is your result: {0} \n", Factorial(inputNumber));
						Main(args);
						break;

					// Check palindrome string
					case 5:
						Console.Write("Please input a string to check (palindrome): ");
						var inputString = Console.ReadLine();
						if (IsPalindrome(inputString)) Console.WriteLine("This is a palindrome string \n");
						else Console.WriteLine("This is not a palindrome string \n");
						Main(args);
						break;

					// Get greatest common divisor
					case 6:
						Console.Write("Please input 2 number to get greatest common divisor.\n" +
							"First number: ");
						var firstNumber = int.Parse(Console.ReadLine());
						Console.Write("Second number: ");
						var secondNumber = int.Parse(Console.ReadLine());
						Console.WriteLine("The greatest common divisor is: {0} \n", GreatestCommonDivisor(firstNumber, secondNumber));
						Main(args);
						break;

					// Get least common multiple
					case 7:
						Console.Write("Please input 2 number to get least common multiple.\n" +
							"First number: ");
						firstNumber = int.Parse(Console.ReadLine());
						Console.Write("Second number: ");
						secondNumber = int.Parse(Console.ReadLine());
						Console.WriteLine("The least common multiple is: {0} \n", GreatestCommonDivisor(firstNumber, secondNumber));
						Main(args);
						break;

					// Calculate a quadratic equation
					case 8:
						Console.Write("Please input 3 number to calculate a quadratic equation (ax^2 + bx + c = 0).\n" +
							"a number: ");
						var aNumber = float.Parse(Console.ReadLine());
						Console.Write("b number: ");
						var bNumber = float.Parse(Console.ReadLine());
						Console.Write("c number: ");
						var cNumber = float.Parse(Console.ReadLine());

						if (QuadraticEquation(aNumber, bNumber, cNumber) == null) Console.Write("The equation has no solution. \n");
						else
						{
							if (QuadraticEquation(aNumber, bNumber, cNumber).Count == 2) Console.WriteLine("The equation has two solution: ");
							foreach (var item in QuadraticEquation(aNumber, bNumber, cNumber))
							{
								if (QuadraticEquation(aNumber, bNumber, cNumber).Count == 2) Console.WriteLine("x = {0}", item);
								else Console.Write("The equation has one solution: x = {0}", item);
							}
						}
						Main(args);
						break;

					case 9:
					default:
						break;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("An error occur: {0}, please try again \n", ex.ToString());
				Main(args);
			}
		}

		/// <summary>
		/// Is prime number
		/// </summary>
		/// <param name="number">Number</param>
		/// <returns>True if prime number| False if not prime number</returns>
		static bool IsPrimeNumber(int number)
		{
			if (number < 2) return false;
			else
			{
				for (var i = 2; i <= (int)Math.Sqrt(number); i++)
				{
					if (number % i == 0) return false;
				}
			}
			return true;
		}


		/// <summary>
		/// Get list prime number less or equal to input number
		/// </summary>
		/// <param name="number">Number</param>
		/// <returns>List prime number</returns>
		static List<int> GetListPrimeNumber(int number)
		{
			var listNumber = new List<int> ();
			for (var i = 2; i <= number; i++)
			{
				if (IsPrimeNumber(i))
				{
					listNumber.Add(i);
				}
				else continue;

			}
			return listNumber;
		}

		/// <summary>
		/// Get list fibonacci
		/// </summary>
		/// <param name="number">Number</param>
		/// <returns>List fibonacci number</returns>
		static List<int> GetListFibonacci(int number)
		{
			var nextNumber = 0;
			var firstNumber = 0;
			var secondnumber = 1;
			var listNumber = new List<int>();
			listNumber.Add(firstNumber);
			listNumber.Add(secondnumber);
			for (var i = 2; i < number; i++)
			{
				nextNumber = firstNumber + secondnumber;
				listNumber.Add(nextNumber);
				firstNumber = secondnumber;
				secondnumber = nextNumber;
			}
			return listNumber;
		}

		/// <summary>
		/// Calculate factorial
		/// </summary>
		/// <param name="number">Number</param>
		/// <returns>Fatorial result</returns>
		static int Factorial(int number)
		{
			var calculate = 1;
			for (var i = 1; i <= number; i++)
			{
				calculate = calculate * i;
			}
			return calculate;
		}

		/// <summary>
		/// Is palindrome string
		/// </summary>
		/// <param name="inputString"></param>
		/// <returns>Result check</returns>
		static bool IsPalindrome(string inputString)
		{
			var first = inputString.Substring(0, inputString.Length / 2);
			var array = inputString.ToCharArray();

			Array.Reverse(array);

			var tempString = new string(array);
			var second = tempString.Substring(0, tempString.Length / 2);

			return first.Equals(second);
		}

		/// <summary>
		/// Greatest common divisor
		/// </summary>
		/// <returns>Greatest common divisor result</returns>
		static int GreatestCommonDivisor(int firstNumber, int secondNumber)
		{
			var remainder = 0;
			while (secondNumber != 0)
			{
				remainder = firstNumber % secondNumber;
				firstNumber = secondNumber;
				secondNumber = remainder;
			}

			return firstNumber;
		}

		/// <summary>
		/// Least common multiple
		/// </summary>
		/// <param name="firstNumber">First number</param>
		/// <param name="secondNumber">Second number</param>
		/// <returns>Least common multiple result</returns>
		static int LeastCommonMultiple(int firstNumber, int secondNumber)
		{
			return (firstNumber / GreatestCommonDivisor(firstNumber, secondNumber)) * secondNumber;
		}

		/// <summary>
		/// Quadratic equation
		/// </summary>
		/// <returns>Results quadratic equation</returns>
		static List<float> QuadraticEquation(float firstNumber, float secondNumber, float thirdNumber)
		{
			var listNumber = new List<float>();
			if (firstNumber == 0)
			{
				if (secondNumber == 0) return null;
				else
				{
					listNumber.Add((-thirdNumber / secondNumber));
					return listNumber;
				}
			}

			var delta = (float)Math.Sqrt(((secondNumber * secondNumber) - (4 * firstNumber * thirdNumber)));
			if (delta > 0)
			{
				listNumber.Add((- secondNumber + delta) / (2 * firstNumber));
				listNumber.Add((- secondNumber - delta) / (2 * firstNumber));
				return listNumber;
			}
			else if (delta == 0)
			{
				listNumber.Add((-secondNumber) / (2 * firstNumber));
				return listNumber;
			}
			else return null;
		}
	}
}
