using System;

namespace RandomWordGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			var word = new Word();

			for (int i = 0; i < 100; i++)
				Console.WriteLine(word.CreateFakeWord());

			Console.ReadKey();
		}
	}
}
