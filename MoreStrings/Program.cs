using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib sisestada eesnime ja perekonnanime
            //programm tervitab kasitajat kasutades tema initsiaale
            //-->Harry Potter-->H. P.
            Console.WriteLine("Sisestage eesnimi");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Sisestage perekonnanimi");
            string LastName = Console.ReadLine();

            Console.WriteLine($"Tere,{FirstName[0]}. {LastName[0]}.");



        }
    }
}
