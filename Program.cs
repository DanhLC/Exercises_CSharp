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
			catch
			{
				Console.WriteLine("your input is not a integer number");
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
	}
}
