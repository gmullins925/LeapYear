using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				//Declarations
				int nYear;
				bool isDiv4, isDiv100, isDiv400;

				//validate user entry year
				do
				{
					Console.WriteLine("Please enter a year to see if it's a Leap Year: ");
				}
				while (!int.TryParse(Console.ReadLine(), out nYear));

				//calculate factors
				isDiv4 = nYear % 4 == 0 ? true : false;
				isDiv100 = nYear % 100 == 0 ? true : false;
				isDiv400 = nYear % 400 == 0 ? true : false;

				//compound test to see if nYear is a Leap Year
				if ((isDiv4 && isDiv100 && isDiv400) || (isDiv4 && !isDiv100 && !isDiv400))
				{
					Console.WriteLine(nYear + "is a leap year.");
				}
				else
				{
					Console.WriteLine(nYear + "is not a leap year.");
				}
				Console.WriteLine("Would you like to try another year?");
			}
			while ((Console.ReadLine() == "Y") || (Console.ReadLine() == "y"));

		}
	}
}
