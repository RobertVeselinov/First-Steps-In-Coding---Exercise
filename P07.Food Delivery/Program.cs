using System;

namespace P07.Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());

            double chickenMenuPrice = chickenMenu * 10.35;
            double fishMenuPrice = fishMenu * 12.40;
            double veganMenuPrice = veganMenu * 8.15;
            double sumMenus = chickenMenuPrice + fishMenuPrice + veganMenuPrice;
            double desertPrice = sumMenus * 0.20;
            double finalPrice = sumMenus + desertPrice + 2.50;
            Console.WriteLine(finalPrice);
        }
    }
}
