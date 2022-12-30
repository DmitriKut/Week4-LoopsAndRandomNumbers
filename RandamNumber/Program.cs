using System;

namespace RandamNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm genereerib juhuslikult nimbrit;
			//kui genereeritud number on 5, programm lõppetab oma tööd jasoovub kasutajale "kena päeva";
			//kui genereeritud number on midagi muud, siis programm jätkub oma tööd;

			Random rdn = new Random();
			int i = 0;

			while (i != 5)
			{

				int myRandomNumber = rdn.Next(1, 11);

				Console.WriteLine($"Juhuslik number on {myRandomNumber}");
				if (myRandomNumber == 5)
				{
					i = myRandomNumber;
				}
			}

				Console.WriteLine("Kena päeva!");

		}
	}
}
