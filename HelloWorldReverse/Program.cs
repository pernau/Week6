using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello World!" tagurpidi


            string fullWord = "Hello World!";

            for (int i = fullWord.Length - 1; i >= 0; i--)
            {
                Console.Write(fullWord[i]);
            }
        }
    }
}
