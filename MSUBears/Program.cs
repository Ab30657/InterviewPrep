using System;

namespace MSUBears
{
	class Program
	{
		static void Main(string[] args)
		{

			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 == 0)
				{
					if (i % 5 == 0)
					{
						Console.WriteLine("MSUBears");
					}
					else
					{
						Console.WriteLine("MSU");
					}
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
