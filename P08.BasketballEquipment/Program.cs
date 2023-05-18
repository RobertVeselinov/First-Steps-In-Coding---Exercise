using System;

namespace P08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int basketballPrice = int.Parse(Console.ReadLine());
            double sneakers = basketballPrice - basketballPrice * 0.40;
            double outfit = sneakers - sneakers * 0.20;
            double ball = outfit / 4;
            double accessories = ball / 5;
            double sum = basketballPrice + sneakers + outfit + ball + accessories;
            Console.WriteLine(sum);
        }
    }
}
