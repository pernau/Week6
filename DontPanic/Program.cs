using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't panic" nulliga - 0
            //programm asendad kõik 'a' tähed samas lauses 4ga

            string DontPanic = "Don't panic";
            DontPanic = DontPanic.Replace('o', '0');
            DontPanic = DontPanic.Replace('a', '4');
            Console.WriteLine(DontPanic);
        }
    }
}
