using System;

namespace P05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pencil = int.Parse(Console.ReadLine());
            int marker = int.Parse(Console.ReadLine());
            int deskCleaner = int.Parse(Console.ReadLine());
            double procentDiscount = double.Parse(Console.ReadLine()) / 100;

            double pencilPrice = pencil * 5.80;
            double markerPrice = marker * 7.20;
            double deskCleanerPrice = deskCleaner * 1.20;
            double allPrice = pencilPrice + markerPrice + deskCleanerPrice;
            double allPriceDiscount = allPrice - (allPrice * procentDiscount);
            Console.WriteLine(allPriceDiscount);

        }
    }
}
