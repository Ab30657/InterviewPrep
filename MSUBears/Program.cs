using System;

namespace MSUBears
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 15 == 0)
				{  //Divisible by 15 means divisible by 5 and 3
					Console.WriteLine("MSUBears");
					continue;
				}
				if (i % 3 == 0)
				{
					Console.WriteLine("MSU");
					continue;
				}
				if (i % 5 == 0)
				{
					Console.WriteLine("Bears");
					continue;
				}
				Console.WriteLine(i);
			}
		}
	}
}
