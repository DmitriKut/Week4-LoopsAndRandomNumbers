using System;

namespace GuessingGameinfinite
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm genereerib juhuslikult nimbrit 1 kuni 10;
			//kassutaja peab seda numbrit ära arvama;
			//kui kasutaja suutis seda nubrit ära arvata, siis ta on mängu võitnud;
			//katsete arv on piiramatu;
			//*programm genereerib juhustiku numbri ühte korda.

			Random rdn = new Random();
			int cpuNumber = rdn.Next(1, 11);
			
			bool loopActive = true;

			int i = 0;

			while (loopActive)

			{
				Console.WriteLine("Arvata ära CPU juhuslikut nimbrit 1 kuni 10 ");
				int userNumber = Convert.ToInt32(Console.ReadLine());




				if (userNumber == cpuNumber)
				{
					Console.WriteLine("You Win!");
					loopActive = false;
				}
				else
				{
					i++;
					Console.WriteLine("You Lost. Proovi uuesti!");
					Console.WriteLine($"Oled proovinud juba {i} korda sisestanud.");
				}
			}
		}

	}
}
