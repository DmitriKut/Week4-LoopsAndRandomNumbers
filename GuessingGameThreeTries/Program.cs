using System;

namespace GuessingGameThreeTries
{
	class Program
	{
		static void Main(string[] args)
		{

			//programm genereerib juhuslikult nimbrit 1 kuni 10;
			//kassutaja peab seda numbrit ära arvama;
			//kui kasutaja suutis seda nubrit ära arvata, siis ta on mängu võitnud;
			//kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega nubri ära arvata, siis võidab arvuti;
			//*programm genereerib juhustiku numbri ühte korda.

			Random rdn = new Random();
			int cpuNumber = rdn.Next(1, 11);

			int i = 0;

			while (i < 3)
			{
				Console.WriteLine("Arvata ära CPU juhuslikut nimbrit 1 kuni 10 ");
				int userNumber = Convert.ToInt32(Console.ReadLine());

				if (userNumber == cpuNumber)
				{
					Console.WriteLine("You Win!");
					break;
				}
				else
				{
					i++; 
					Console.WriteLine($"You Lost. {3 - i} katset on jäänud.");
				}
			}
		}

	}
}
