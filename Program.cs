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

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
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
		/// <returns></returns>
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
		/// <returns></returns>
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
	}
}
