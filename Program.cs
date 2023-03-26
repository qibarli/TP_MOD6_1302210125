using System;

namespace TP_MOD6_1302210125
{
    class Program
    {
        static void Main(string[] args)

        {
            SayaTubeVideo saya = new SayaTubeVideo(" Tutorial Design By Contract - Mochamad Rifqi Barliant ");

            saya.IncreasePlayCount(0);

            saya.PrintVideoDetails();

            Console.WriteLine();

            SayaTubeVideo saya1 = new SayaTubeVideo(" Mochamad Rifqi Barliant");

            saya1.IncreasePlayCount(1000000000);

            saya1.PrintVideoDetails();

        }
    }
}