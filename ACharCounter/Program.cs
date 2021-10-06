using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib kasutajal sisestada perekonnanime
            //programm kuvab,mitu "a" tähte kasutaja eesnimes ja
            //programmnimes kokku on

            
            
            Console.WriteLine("Sisestage eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisestage perekonnanimi");
            string LastName = Console.ReadLine();
            string fullname = $"{firstname}{LastName}".ToLower();

            int counter = 0;
            // "a"
            for (int i = 0; i < fullname.Length; i++)
            {

                if (fullname[i] == 'a')
                {
                    counter++;
                
                }
            }
            if(counter == 1)
            {
                Console.WriteLine($"Sinu nimes on {counter} 'a' täht.");
            }
            
            


        }
    }
}
