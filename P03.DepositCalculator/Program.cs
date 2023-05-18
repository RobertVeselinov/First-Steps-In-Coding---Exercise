using System;

namespace P03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int depositMonths = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine()) / 100;
            double finishDeposit = deposit + depositMonths * ((deposit * interest) / 12);
            Console.WriteLine(finishDeposit);
        }
    }
}
