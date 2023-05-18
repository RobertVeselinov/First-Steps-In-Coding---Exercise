using System;

namespace P09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            percent = percent / 100;

            int capacityAquarium = length * width * height;
            double capacityLiters = capacityAquarium * 0.001;
            double neededLiters = capacityLiters * (1 - percent);
            Console.WriteLine(neededLiters);
        }
    }
}
