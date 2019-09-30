using System;

namespace RandomWordGenerator
{
	public class Word
	{
		private Random _random = new Random(Environment.TickCount);
		private string[] _vowels = { "a", "e", "i", "o", "u" };
		private string[] _consonants = {"b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", 
			  "r", "s", "t", "v", "w", "x", "y", "z"};

		public string CreateFakeWord()
		{
			int count = _random.Next(2, 4);
			var syllables = new string[count];

			for (int i = 0; i < count; i++)
			{
				syllables[i] = Syllable();
			}

			return String.Join(String.Empty, syllables);
		}

		private string Vowel()
		{
			int index = _random.Next(_vowels.Length);
			return _vowels[index];
		}

		private string Consonant()
		{
			int index = _random.Next(_consonants.Length);
			return _consonants[index];
		}

		private string CV()
		{
			return Consonant() + Vowel();
		}

		private string Cvc()
		{
			return CV() + Consonant();
		}

		private string Syllable()
		{
			var methods = new Func<string>[] { Vowel, CV, Cvc };
			int index = _random.Next(methods.Length);

			return methods[index]();
		}
	}
}
