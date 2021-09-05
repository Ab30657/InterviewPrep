using System;

namespace Fib
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the number: ");
			var num = int.Parse(Console.ReadLine());
			Console.WriteLine(Fib2(num));
		}
		//
		// RECURSION
		//
		// static int Fib(int n)
		// {
		// 	if (n == 0 || n == 1)
		// 	{
		// 		return 1;
		// 	}
		// 		return Fib(n - 1) + Fib(n - 2);
		// }


		//Alternative Approach
		static int Fib2(int n)
		{
			if (n == 0) return 1;
			int[] nums = new int[n + 1];
			nums[0] = 1;
			nums[1] = 1;
			for (int i = 2; i <= n; i++)
			{
				nums[i] = nums[i - 2] + nums[i - 1];
			}
			return nums[n];
		}
	}
}
