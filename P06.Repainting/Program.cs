using System;

namespace P05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int makeUp = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sumNylon = (nylon + 2) * 1.50;
            double sumPaint = (paint * 0.10);
            double sumPaint1 = (sumPaint + paint) * 14.50;
            double sumMakeUp = makeUp * 5.00;

            double sumMaterials = sumNylon + sumPaint1 + sumMakeUp + 0.40;
            double sumWorkers = (sumMaterials * 0.30);
            double sumWorkers1 = sumWorkers * hours;
            double finishSum = sumMaterials + sumWorkers1;
            Console.WriteLine(finishSum);
        }
    }
}
