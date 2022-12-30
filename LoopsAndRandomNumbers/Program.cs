using System;

namespace LoopsAndRandomNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib kasutajalt sisestada PIN-koodi;
			//programm võrdleb sisestadud PIN-koodi arvuga 1234;
			//kui sisestadud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
			//Kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale Pin. Proovi uuesti";
			//kasutajal on kolm katset. i < 3

			int i = 0; //i - interation

			while (i < 3) //While-loop
			{
				Console.WriteLine("Sisesta PIN:");
				int userPIN = Convert.ToInt32(Console.ReadLine());

				if (userPIN == 1234)
				{
					Console.WriteLine("Tere tulemast!");
					break;
				}
				else
				{
					i++; // i = i + 1 = i++
					Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");
				}



			}

			Console.WriteLine("Kena päeva!");


		}
	}
}
