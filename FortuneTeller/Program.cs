﻿using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis juhtub kasutajaga homme (kasutame random klassi)

            string[] predictions = { "win a million", "fall in love", "buy youtube premium", "join the darkside for cookies" };

            Random rnd = new Random();
            int userNumber = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Tomorrow you will {predictions[userNumber]}");
        }
    }
}
