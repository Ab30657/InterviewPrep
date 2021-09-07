using System.IO;
using System;

namespace FileBear
{
	class Program
	{
		static void Main(string[] args)
		{
			var line = "";
			using (StreamReader sr = new StreamReader("test.txt"))
			{
				line = sr.ReadLine();
			}
			if (line != null)
			{
				if (line.Contains("bear"))
				{
					Console.WriteLine("Yes, the file contains the word bear in its first line");
					return;
				}//Check with the interviewer whether it is bear or "bear."
				Console.WriteLine("There is no bear on the first line of the file");
				return;
			}
			Console.WriteLine("File is empty");
		}
	}
}
