using System;

namespace AnotherStringToReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset tagur pidi
           // for loop
            string HelloW = "Hello World";
            for (int i = HelloW.Length - 1; i >= 0; i--)
            {
                Console.Write(HelloW[i]);

            }
           

            
        }
    }
}
