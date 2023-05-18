using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine()) + 2;
            double paint = double.Parse(Console.ReadLine());
            int makeUp = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            paint = paint + paint * 0.10;
            double sumNylon = nylon * 1.50;
            double sumPaint = paint * 14.50;
            double sumMakeUp = makeUp * 5.00;
            double sumMaterials = sumNylon + sumPaint + sumMakeUp + 0.40;
            double sumWorker = (sumMaterials * 0.30) * hours;
            double finishSum = sumMaterials + sumWorker;
            Console.WriteLine(finishSum);
        }
    }
}
