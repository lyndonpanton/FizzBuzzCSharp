// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace FizzBuzzCSharp
{
	public class Program
	{
		static void Main(string[] args)
		{

		}

		public void FizzBuzz(int upperLimit)
		{
			if (upperLimit <= 0)
			{
				Console.WriteLine("Upper Limit must be greater than 0...");
				Console.WriteLine("Returning default output...");

				upperLimit = 100;
			}

			for (int i = 1 i <= upperLimit; i++)
			{
				if (i % 15 == 0)
					Console.WriteLine("FizzBuzz");
				else if (i % 5 == 0)
					Console.WriteLine("Buzz");
				else if (i % 3 == 0)
					Console.WriteLine("Fizz");
				else
					Console.WriteLine(i);
			}
		}
	}
}